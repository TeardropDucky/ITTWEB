CREATE TABLE [dbo].[BudgetPeriode](
    [Id]					INT IDENTITY(1,1) NOT NULL,
	[Name]					NVARCHAR(MAX) NOT NULL,	
	[PeriodeStart]			DATETIME NULL,
	[PeriodeEnd]			DATETIME NULL,
    CONSTRAINT [dbo.BudgetPeriode] PRIMARY KEY ([Id])
)

CREATE TABLE [dbo].[Employee](
    [Id]					INT IDENTITY(1,1) NOT NULL,
	[Name]					NVARCHAR(MAX) NOT NULL,	
	[Teacher]				BIT NOT NULL DEFAULT(1),
	[MinutesPerDay]			INT NOT NULL,
    CONSTRAINT [dbo.Employee] PRIMARY KEY ([Id])
)

CREATE TABLE [dbo].[Activity](
    [Id]					INT IDENTITY(1,1) NOT NULL,
	[Title]					NVARCHAR(MAX) NOT NULL
    CONSTRAINT [dbo.Activity] PRIMARY KEY ([Id])
)

CREATE TABLE [dbo].[BudgetHoursOnActivity]( 
    [Id]					INT IDENTITY(1,1) NOT NULL,	
	[ActivityId]			INT NOT NULL,
	[EmployeeId]			INT NOT NULL,
	[BudgetPeriodeId]		INT NOT NULL,
	[Minutes]				INT NOT NULL,
    CONSTRAINT [dbo.BudgetHoursOnActivity] PRIMARY KEY ([Id])
)