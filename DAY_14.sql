use NGATraining;
Go

--Creating a Procedure USP(User Stored Procedure)

CREATE TABLE Employees
(
    EmpId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Salary INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

Select * from Employees;

Create Procedure usp_AddEmployee 
	@Name varchar(50),
	@Salary int,
	@EmpId int output

	AS
	Begin
		Begin Try
			Begin Transaction

			Insert into Employees(Name, Salary)
			Values(@Name, @Salary)

			Set @EmpId = SCOPE_IDENTITY()
			Commit Transaction
		End try
	Begin catch
		RollBack Transaction
		throw
	End catch
End

--To Call this procedure with a real value

Declare @Id int
Exec usp_AddEmployee 'Muski',90000,@Id output
Select @Id

Select * from Employees;
--We can have stored procedures for deleting, updating in transactions also.


--Creating a trigger 
Select * from Employees;

--If we hvae Logging/Auditing 
--The below table will record all the entries related to auditing purpose
--This table is write only Table
--No Application will insert into this table directly
CREATE TABLE EmployeeSalaryAudit
(
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    EmpId INT,
    OldSalary INT,
    NewSalary INT,
    ChangedOn DATETIME DEFAULT GETDATE()
);

Select * from EmployeeSalaryAudit;

--Creating after Update trigger

Create Trigger trg_AuditEmployeeSalary
On Employees

After Update 
AS
	Begin
		If Not Update(salary)
			Return;
				Insert into EmployeeSalaryAudit(EmpId, OldSalary, NewSalary)
					Select
						d.Empid,
						d.salary As OldSalary,
						i.salary As NewSalary
						from deleted d
						Inner join inserted i
						on d.EmpId = i.EmpId;
End

--Calling Trigger with Data
--Performing Update operation that calls trigger indirectly and performs entry into Audit table
Update Employees
Set Salary = Salary + 12000
Where EmpId = 1;




