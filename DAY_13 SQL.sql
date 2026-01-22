use NGATraining;
Go
--WHY WE NEED JOINS
--Suppose if we have 3 different tables
-- Courses( Master table )
-- Students ( transaction Table)
-- Trainers( Self Join use cases)

Create table MyCourses(
	CourseId int primary key,
	StudentName varchar(100),
);

CREATE TABLE My_Students (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    CourseId INT
);
CREATE TABLE Trainers (
    TrainerId INT PRIMARY KEY,
    TrainerName VARCHAR(50),
    ManagerId INT
);

INSERT INTO MyCourses VALUES
(101, 'Full Stack'),
(102, 'Python'),
(103, 'Java');


INSERT INTO My_Students VALUES
(1, 'Rahul', 101),
(2, 'Neha', 102),
(3, 'Amit', 101),
(4, 'Sonal', NULL);

INSERT INTO Trainers VALUES
(1, 'Arjun', NULL),
(2, 'Ravi', 1),
(3, 'Sneha', 1),
(4, 'Kiran', 2);


--Implementing Joins
--Types of joins
--1.Inner Join-It will return commnon values in both the tables

Select s.My_Students, c.MyCourses
from My_Students s
Inner Join MyCourses c
on s.CourseId = c.CourseID;

--Left Join: Will re

--Right Join : All right record + Matching Record
--It will display all courses even if there is no enrolled student

Select s.StudentName, s.StudentId, c.CourseName, c.CourseId
from My_Students s
Right Join MyCourses c
on s.CourseId = c.CourseId;

--Full Outer Join
--It returns all the records from both table
--Complete Enrollement Audit

Select s.StudentName, s.StudentId,c.CourseName, c.CourseId
From My_Students s
Full Outer Join MyCourses
on s.CourseId = c.CourseId;

--Self Join
--Table Joins to itself

--Cross Join
