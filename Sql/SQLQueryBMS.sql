Create Database StockManagementSystem
create table Category(ID int identity (1,1),Code varchar(50),Name varchar(50))
select * from Category where Code='CA-23'
insert into Category values('-Select-','-Select-')
insert into Category values('CA-23','Electronics')
create table Product(ID int identity (1,1),Category varchar(50),Code varchar(50),Name varchar(50),ReOrderLevel varchar(50),Description varchar(100))
select * from Product
insert into Product values('Electronics','BA-23','Mobile','23','Quality is fine')
select Name from Category
drop table Category
drop table Product























































