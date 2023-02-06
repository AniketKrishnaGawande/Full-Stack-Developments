create database PMS;

use PMS;

create table profiles(
pId int primary key,
pName varchar(30),
pAge int,
pBDate DATE,
password varchar(20) not null,
roll varchar(20) not null
);

insert into profiles values(100,"Aniket",23,'1999-09-19',"Aniket","admin"),
                                         (101,"Apurva",26,'1997-12-05',"Apurva","user"),
                                         (102,"Anuja",28,'1995-12-05',"Anuja","user"),
                                         (103,"Chhaya",23,'1999-10-19',"Chhaya","user");