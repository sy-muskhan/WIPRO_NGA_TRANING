create DATABASE ms_dynamicsDB;
GO
use ms_dynamicsDB;
Go

Create Table FPO(
FPOID int Identity(1, 1) Primary KEY,
FPOName Varchar(100) not null,
State Varchar(50) not null,
MemberCount Int Check(MemberCount > 0),
Registrations Date not null
);

Insert into FPO
values
('Greenharvest FPO','Maharashtra',250,'2022-06-15'),
('Agro Unity FPO', 'Karnataka', 180, '2022-09-10');

Select * from FPO;






