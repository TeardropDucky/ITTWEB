// Userlist data array for filling in info box
var exerciseListData = [];

// DOM Ready =============================================================
$(document).ready(function() {

    // Populate the user table on initial page load
    populateTable();
	
	// Add User button click
	$('#btnAddExercise').on('click',addExercise);
	
	// Delete User link click
	$('#exerciseList table tbody').on('click', 'td a.linkdeleteuser', deleteExercise);
});

// Functions =============================================================

// Fill table with data
function populateTable() {

    // Empty content string
    var tableContent = '';

    // jQuery AJAX call for JSON
    $.getJSON( '/users/userlist', function( data ) {
		
		// Stick our user data array into a userlist variable in the global object
		exerciseListData = data;
		
        // For each item in our JSON, add a table row and cells to the content string
        $.each(data, function(){
            tableContent += '<tr>';
            tableContent += '<td>' + this.exercise + '</td>';
            tableContent += '<td>' + this.description + '</td>';
			tableContent += '<td>' + this.set + '</td>';
			tableContent += '<td>' + this.amount + '</td>';
            tableContent += '<td><a href="#" class="linkdeleteuser" rel="' + this._id + '">delete</a></td>';
            tableContent += '</tr>';
        });

        // Inject the whole content string into our existing HTML table
        $('#exerciseList table tbody').html(tableContent);
    });
};

//Add User function
function addExercise(event){
	event.preventDefault();
	
	//Basic calidation
	var errorCount = 0;
	$('#addExercise input').each(function(index, val) {
		if($(this).val() === '') { errorCount++ }
	});
	
	if(errorCount === 0) {
		
		//compile all user info into object
		var newExercise = {
			'exercise': $('#addExercise fieldset input#inputExerciseName').val(),
            'description': $('#addExercise fieldset input#inputDescription').val(),
            'set': $('#addExercise fieldset input#inputSet').val(),
            'amount': $('#addExercise fieldset input#inputAmount').val()
		}
		
		//User AJAX to post to adduser service
		$.ajax({
			type: 'POST',
			data: newExercise,
			url: '/users/adduser',
			dataType: 'JSON'
		}).done(function( response ) {
			
            // Check for successful (blank) response
            if (response.msg === '') {

                // Clear the form inputs
                $('#addExercise fieldset input').val('');

                // Update the table
                populateTable();

            }
            else {

                // If something goes wrong, alert the error message that our service returned
                alert('Error: ' + response.msg);

            }
        });
	}
	else {
		//we have error
		alert('Please fill in all fields');
		return false;
	}
};

// Delete User
function deleteExercise(event) {

    event.preventDefault();

    // Pop up a confirmation dialog
    var confirmation = confirm('Are you sure you want to delete this user?');

    // Check and make sure the user confirmed
    if (confirmation === true) {

        // If they did, do our delete
        $.ajax({
            type: 'DELETE',
            url: '/users/deleteuser/' + $(this).attr('rel')
        }).done(function( response ) {

            // Check for a successful (blank) response
            if (response.msg === '') {
            }
            else {
                alert('Error: ' + response.msg);
            }

            // Update the table
            populateTable();

        });

    }
    else {

        // If they said no to the confirm, do nothing
        return false;

    }

};