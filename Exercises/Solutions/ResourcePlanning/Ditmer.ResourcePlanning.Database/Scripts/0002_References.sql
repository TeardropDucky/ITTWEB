ALTER TABLE [dbo].[BudgetHoursOnActivity]  WITH CHECK ADD  CONSTRAINT [FK_BudgetHoursOnActivity_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO

ALTER TABLE [dbo].[BudgetHoursOnActivity]  WITH CHECK ADD  CONSTRAINT [FK_BudgetHoursOnActivity_Activity] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activity] ([Id])
GO

ALTER TABLE [dbo].[BudgetHoursOnActivity]  WITH CHECK ADD  CONSTRAINT [FK_BudgetHoursOnActivity_BudgetPeriode] FOREIGN KEY([BudgetPeriodeId])
REFERENCES [dbo].[BudgetPeriode] ([Id])

GO