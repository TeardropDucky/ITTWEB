SET IDENTITY_INSERT [dbo].[BudgetPeriode] ON
INSERT [dbo].[BudgetPeriode] ([Id], [Name], [PeriodeStart], [PeriodeEnd]) VALUES (1, N'Budget F16', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2016-01-06 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[BudgetPeriode] OFF

SET IDENTITY_INSERT [dbo].[Employee] ON 
INSERT [dbo].[Employee] ([Id], [Name], [Teacher], [MinutesPerDay]) VALUES (1, N'Kenneth', 1, 450)
SET IDENTITY_INSERT [dbo].[Employee] OFF
 
SET IDENTITY_INSERT [dbo].[Activity] ON 
INSERT [dbo].[Activity] ([Id], [Title]) VALUES (1, N'ITTWEB-01')
SET IDENTITY_INSERT [dbo].[Activity] OFF

SET IDENTITY_INSERT [dbo].[BudgetHoursOnActivity] ON
INSERT [dbo].[BudgetHoursOnActivity] ([Id], [ActivityId], [EmployeeId], [BudgetPeriodeId], [Minutes]) VALUES (1, 1, 1, 1, 3600)
SET IDENTITY_INSERT [dbo].[BudgetHoursOnActivity] OFF