create database Showroom;
use Showroom;


create table Vehicles(

vId int primary key auto_increment,
vName varchar(30) not null,
vCompany varchar(30) not null,
vPrice double(9,2)
);

insert into Vehicles(vName,vCompany,vPrice) values("nexon","tata",2000),
                                                                                        ("tiago","tata",3000),
                                                                                        ("thar","mahindra",4000),
                                                                                        ("swift","maruti",5000),
                                                                                        ("harrier","tata",8000);

select * from Vehicles;

