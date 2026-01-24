Create Database NGATraining;
Go

Use NGATraining;
Go

-- Create table
CREATE TABLE Students
(
    StudentId INT PRIMARY KEY,
    Email VARCHAR(50),
    Age INT,
    CourseId INT
);

-- Insert records
INSERT INTO Students VALUES (1, 'rahul@gmail.com', 20, 101);
INSERT INTO Students VALUES (2, 'neha@gmail.com', 22, 102);
INSERT INTO Students VALUES (3, 'amit@gmail.com', 19, 101);
INSERT INTO Students VALUES (4, 'amitabh@gmail.com', 21, 101);

-- Display all records
SELECT * FROM Students;


--Counting
SELECT COUNT(*) AS TotalStudents
FROM Students;

--Average
SELECT AVG(Age) AS AverageAge
FROM Students;

--Scalar Functions
SELECT 
    StudentId,
    LEN(Email) AS EmailLength,
    GETDATE() AS CurrentDate
FROM Students;


--Grouping
SELECT 
    CourseId,
    COUNT(*) AS StudentCount
FROM Students
GROUP BY CourseId;

--Transactions: Commit, RollBack,Save Point
--ROLLBACK
BEGIN TRANSACTION;
    UPDATE Students
    SET Age = Age + 1
    Where CourseId = 101;

ROLLBACK; -- Above changes are not reflected hence rollbacked to previous consistent state
--No change Due to ROllBack

--COMMIT
BEGIN TRANSACTION;
    UPDATE Students
    SET Age = Age + 1
    Where CourseId = 101;
COMMIT;

--SAVEPOINT
--All the changes will be saved till this savepoint
BEGIN TRANSACTION;
UPDATE students Set Age = 25 Where StudentId = 2;
SAVE Transaction s1; 
--Above operations are now permanent and its state is saved as S1


--Below Update is roll backed and previous state that is S1 is achieved
UPDATE Students Set Age = 30 where StudentId = 1;
RollBack Transaction s1;
Commit;

--ACCESS CONTROL: Grant & Revoke

--Grant: Here User1 is allowed to perform these operations.
Grant select, Insert on students to User1;
--Revoke: Here Revoking user1 to perform insert Operations.
Revoke Insert on Students From User1;

--DDL with Alter:
Alter table Students
Add Phone varchar(50);

Select * from Students; 
--Q: What can be done if we dont want to write select command again and again
--Ans: Creating a function that displays/run select * from table
Create Function fn_DisplayStudentsTable()
returns Table
As return
(
Select StudentID, Email, Age, CourseId from students
);

Select * from fn_DisplayStudentsTable();


--A function with Parameters
Create Function dbo.GetStudentByCourseId(@CourseId int)
Returns Table
As
Return 
(
Select studentId, Email, Age from Students
where CourseId = @CourseId
);

Select * from fn_DisplayStudentsTable();
Select * from dbo.GetStudentByCourseId(101);

--Foreign Key Implementation
--This Enforces a logic that there can not be student without values of course
--Which means first we have to insert values for courses table then we will insert students value in wipro university


--Parent Table
Create Table Courses(
    CourseId int primary Key,
    CourseName varchar(100) not null,
    DurationInMonths int check(DurationInMonths >0)

);

--This Enforces a logic that there can not be student without values of course
--Which means first we have to insert values for courses table then we will insert students value in wipro university
--So we are inserting courses here first


Insert into Courses values (101, 'Full Stack Java Development', 6);
Insert into Courses values (102, 'Data Analytics', 10);
Insert into Courses values(103, 'Cloud Engineering', 19);

Select * from courses;

--This is the child Table
Create Table WiproUniversity
(
StudentId INT PRIMARY KEY,
    Email VARCHAR(100) Unique,
    Age INT check (Age >= 18),
    CourseId INT,
    Constraint fk_Students_Courses
    Foreign Key (CourseId)
    References Courses(CourseId)
);

--after initializing courses table now we have to initialize this table values

INSERT INTO WiproUniversity VALUES (1, 'rahul@gmail.com', 20, 101);
INSERT INTO WiproUniversity VALUES (2, 'neha@gmail.com', 22, 102);
INSERT INTO WiproUniversity VALUES (3, 'amit@gmail.com', 19, 103);

Select * from WiproUniversity;

--The above line will give you error because the courseId in the line is 109 which is not present in the courses table
INSERT INTO WiproUniversity VALUES (3, 'amit@gmail.com', 19, 109);
--Output: This CourseId is not in the courses table

--Here Usage of delete will also give you error because if there is atleast one value of courseId present in the WiprUniversity table there is no chance to delete the data.
Delete from Courses where courseId = 101;

--If you really want to delete use CASCADE TABLE by dropping the tables
Drop table WiproUniversity;

Create Table WiproUniversity
(
StudentId INT PRIMARY KEY,
    Email VARCHAR(100) Unique,
    Age INT check (Age >= 18),
    CourseId INT,
    Constraint fk_Students_Courses
    Foreign Key (CourseId)
    References Courses(CourseId)
    On delete CASCADE
);
--Now we can delete parent column so that the child column will be automatically deleted.

INSERT INTO WiproUniversity VALUES (1, 'rahul@gmail.com', 20, 101);
INSERT INTO WiproUniversity VALUES (2, 'neha@gmail.com', 22, 102);
INSERT INTO WiproUniversity VALUES (3, 'amit@gmail.com', 19, 103);
INSERT INTO WiproUniversity VALUES (4, 'muski@gmail.com', 27, 101);

Select * from WiproUniversity;
delete from WiproUniversity where CourseId = 101;

--Now row 1 and row 4 will be deleted because we used cascade deleting here. So courseId with 101 will be deleted.
