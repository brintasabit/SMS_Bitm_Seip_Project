Create Database StockManagementSystem


create table Category(ID int identity (1,1),Code varchar(50),Name varchar(50))
select * from Category where Code='CA-23'
insert into Category values('CA-12','Stationary')
insert into Category values('CA-23','Electronics')
insert into Category values('CA-31','Textile')
select Name from Category
update Category set Code='St23',Name='Staionary' where Code='CA-12'


create table Product(ID int identity (1,1),Category varchar(50),Code varchar(50),
Name varchar(50),ReOrderLevel varchar(50),Description varchar(100))
select * from Product
insert into Product values('Electronics','BA-23','Mobile','23','Quality is fine')
insert into Product values('Stationary','CA-23','Pen','23','Fountain Pen')
update Product set Category='Tex',Code='3456',Name='Shirt',ReOrderLevel='56',Description='Yea' where Code='BA-23'
delete from Product where Code='CA-23'



drop table Sales
drop table Category
drop table Product
drop table Supplier
drop table ProductsPurchase
drop table SuppliersPurchase

create table SuppliersPurchase(ID int identity (1,1),Date varchar(50),
Bill varchar(50),Supplier varchar(50))
select * from SuppliersPurchase
insert into SuppliersPurchase values('20/10/2019','201019','Rangs')
insert into SuppliersPurchase values('21/10/2019','211019','Lg')


create table ProductsPurchase(ID int identity (1,1),Date varchar(50),
Bill varchar(50),Supplier varchar(50),Category varchar(50),
Products varchar(50),Code varchar(50),AvailableQty int,
ManufacturedDate varchar(50),ExpireDate varchar(50),Remarks varchar(50),
Quantity int,UnitPrice float,TotalPrice float,
PreviousUnitPrice float,PreviousMRP float,MRP float,Profit float)
insert into ProductsPurchase 
values ('Electronics','Mobile','0978',4,'20/10/19','12/12/19','Not Applicable',
6,50,300,40,40,40)
select * from ProductsPurchase
select Quantity from ProductsPurchase where Products='Shirt'

create table Sales(ID int identity (1,1),CustomerName varchar(50),Date varchar(50),
LoyalityPoint int,Category varchar(50),Product varchar(50),AvailableQty int,
Quantity int,MRP float,TotalMRP float)
select * from Sales
insert into sales 
values('Bob','23-10-19','10','Electronics','Mobile',10,5,10000,15000)

select Code,Name,Category,ReOrderLevel,ExpireDate,Quantity from [Product] join ProductsPurchase on [Product].ProductPurchaseId=ProductsPurchase.ID 
select t1.Code,t1.Name,t1.Category,t1.ReOrderLevel
from Product t1
inner join ProductsPurchase on Product.ID=ProductsPurchase.ID
where Product.ID=x and Product.ID='y'
select ExpireDate,Quantity from ProductsPurchase



select p.Code as ProductCode,p.Name as productName,c.Name, ReOrderLevel,Description
 from Product as p
 Left join Category as c on c.Name = p.Category
select p.Code,p.Name,pp.Category,ReOrderLevel,ExpireDate,Quantity 
from Product as p left join ProductsPurchase as pp on pp.Products=p.Name where Name='Mobile'

select * 
from Product as p left join ProductsPurchase as pp on pp.Products=p.Name

select p.Category,p.Name,p.Code from Product as p left join Category as c on c.Name=p.Name






Select * from Category
Select * from Product





select Code,Name,Category,ReOrderLevel,ExpireDate,Quantity from Product left join ProductsPurchase on Product.ID=ProductsPurchase.ID
select * from Product a left join ProductsPurchase b on a.ID=b.ID



create table Supplier(ID int identity (1,1),Code varchar(50),Name varchar(50),
Address varchar(50),Email varchar(50),Contact varchar(50),ContactPerson varchar(50))
insert into Supplier values('23bc','Bob','LA','bob@la.com','0345','Alice-056')
select * from Supplier
delete from Supplier where Name='Bob'


select Name from Product as p where p.Category='Electronics'
select Code,Products,Category,AvailableQty,UnitPrice as CurrentPrice,MRP from ProductsPurchase

























































