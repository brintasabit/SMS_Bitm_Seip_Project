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
drop table Suppliers
create table SuppliersPurchase(ID int identity (1,1),Date varchar(50),Bill varchar(50),Supplier varchar(50))
create table ProductsPurchase(ID int identity (1,1),Category varchar(50),Products varchar(50),Code varchar(50),AvailableQty varchar(50),
ManufacturedDate varchar(50),ExpireDate varchar(50),Remarks varchar(50),Quantity varchar(50),UnitPrice varchar(50),TotalPrice varchar(50),
PreviousUnitPrice varchar(50),PreviousMRP varchar(50),MRP varchar(50))
create table Sales(ID int identity (1,1),Customer varchar(50),Date varchar(50),LoyalityPoint varchar(50),Category varchar(50),Product varchar(50),AvailableQuantity varchar(50),
Quantity varchar(50),MRP varchar(50),TotalMRP varchar(50),)
select * from Sales
select * from ProductsPurchase
select Code,Name,Category,ReOrderLevel,ExpireDate,Quantity from [Product] join ProductsPurchase on [Product].ProductPurchaseId=ProductsPurchase.ID 
select t1.Code,t1.Name,t1.Category,t1.ReOrderLevel
from Product t1
inner join ProductsPurchase on Product.ID=ProductsPurchase.ID
where Product.ID=x and Product.ID='y'
select ExpireDate,Quantity from ProductsPurchase



select p.Code as ProductCode,p.Name as productName,c.Name, ReOrderLevel,Description
 from Product as p
 Left join Category as c on c.Name = p.Category

 Select * from Category
Select * from Product





select Code,Name,Category,ReOrderLevel,ExpireDate,Quantity from Product left join ProductsPurchase on Product.ID=ProductsPurchase.ID
select * from Product a left join ProductsPurchase b on a.ID=b.ID































































