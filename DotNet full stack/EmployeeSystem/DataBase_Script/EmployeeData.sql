create database Organisation;
use Organisation;

create table Employees(
eId int primary key auto_increment,
eName varchar(20) not null,
eDepartment varchar(20),
eSalary double(9,2)
);

alter table Employees auto_increament=100;


insert into Employees(eName,eDepartment,eSalary) values("Aniket Gawande","Development",90000),
                                                                                                ("Apurva Gawande","Finance",50000),
                                                                                                ("Anuja Gawande","Finance",60000),
                                                                                                ("Swanand Kale","Testing",40000),
                                                                                                ("Prajwal Patil","Quality",70000);
