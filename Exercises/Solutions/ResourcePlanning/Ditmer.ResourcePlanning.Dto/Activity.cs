using System.ComponentModel.DataAnnotations;

namespace Ditmer.ResourcePlanning.Dto
{
    public class Activity
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
