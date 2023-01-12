create database EmployeeInfo;
use EmployeeInfo;
create table Employees(
Eid int primary key auto_increment,
Ename varchar(25) not null,
Dept varchar(30),
Salary double(9,2)
);

alter table Employees
auto_increment=100;

insert into Employees(Ename,Dept,Salary) values("Aniket","Architecture",500000),
                                              ("Prajwal","Production",5000),
                                              ("Swanand","developer",50000),
                                              ("Akshay","HR",80000),
                                              ("Akshobhya","Quality",40000),
                                              ("Prathamesh","Finance",60000),
                                              ("Akash","Production",8000);





