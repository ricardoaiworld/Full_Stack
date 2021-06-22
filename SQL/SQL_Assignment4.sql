--1
insert into Region(RegionDescription) VALUES ('Middle Earth')
insert into Territories(TerritoryDescription, RegionID) values ('Gondor', (select RegionID from Region where RegionDescription='Middle Earth'))
insert into EmployeeTerritories(TerritoryID) values ((select TerritoryID from Territories where TerritoryDescription='Gondor'))

--2
update Territories set TerritoryDescription = 'Arnor' where TerritoryDescription = 'Gondor'

--3
delete from EmployeeTerritories where TerritoryID = (select TerritoryID from Territories where RegionID = (select RegionID from Region where RegionDescription='Middle Earth'))
delete from Territories where RegionID = (select RegionId from Region where RegionDescription='Middle Earth')
delete from Region where RegionDescription='Middle Earth'

--4
create view view_product_order_zhenming as (
    select p.ProductID, sum(Quantity) as "TotalOrdered" from Products p left join [Order Details] od on p.ProductID = od.ProductID
    group by p.ProductID
)

--5
create procedure sp_product_order_quantity_zhenming
    @pid int,
    @quantity int output
as 
begin 
    select @quantity=sum(Quantity) from [Order Details] od where ProductID = @pid 
end
DECLARE @get int;
exec sp_product_order_quantity_zhenming 3, @get output;
select @get

--6
create procedure sp_product_order_city_zhenming
	@ProductName int,
	@City nvarchar(20) OUTPUT,
	@TotalQuantity int OUTPUT
as 
	select @City=M.City,@TotalQuantity=M.quantity
	from (select top 5 C.City as City,Count(O.OrderID) as num,SUM(D.Quantity) as quantity
	from Orders O left join Customers C on O.CustomerID=C.CustomerID left join [Order Details] D on O.OrderID=D.OrderID left join Products P on D.ProductID=P.ProductID
	where P.ProductName=@ProductName
	group by C.City
	order by Count(O.OrderID) DESC
	)M
return

--7
create procedure sp_move_employees_zhenming
as 
	begin 
	    declare @target varchar(20)='Tory';
		declare @res int;

		declare @temtable table(EmployeeID int Primary key,TerritoryDescription varchar(20) not null);

		insert into @temtable(EmployeeID,TerritoryDescription)
		select E.EmployeeID as EmployeeID,T.TerritoryDescription as TerritoryDescription
		from Employees E inner join EmployeeTerritories ET on E.EmployeeID=ET.EmployeeID inner join Territories T on ET.TerritoryID=T.TerritoryID

		select @res=count(EmployeeID)
		from @temtable
		where TerritoryDescription = @target
		select @res;
		IF @res>0
		BEGIN
			insert into Territories values(98301,'Stevens Point',3)
			update EmployeeTerritories set TerritoryID=98301 where EmployeeID in (select * from @temtable where TerritoryDescription=@target)
		END
	END

--8
create trigger movezhenming on EmployeeTerritories
After insert,update
as
begin 
	declare @count int
	declare @target nchar='Stevens Point'
	select @count=count(distinct ET.EmployeeID)
	from EmployeeTerritories ET inner join Territories T on ET.TerritoryID=T.TerritoryID
	where T.TerritoryDescription=@target
	if @count>100
	begin
		update EmployeeTerritories set TerritoryID=(select TerritoryID from Territories where TerritoryDescription='Troy') 
		where TerritoryID=(select TerritoryID from Territories where TerritoryDescription=@target)
	end
end

--9
--10
create procedure sp_birthday_employees_zhenming
as
	begin
		create table birthday_employees_zhenming(EmployeeID int,LastName nchar(20), FirstName nchar(20));
		insert into birthday_employees_zhenming select EmployeeID,LastName,FirstName from Employees where MONTH(BirthDate)=2
	end

go
exec sp_birthday_employees_zhenming

--11
create procedure sp_zhenming_1 
as	
	select M.City 
	from
	(select C.CustomerID as ID,C.City as City,count(distinct D.ProductID) as count
	from Customers C left join Orders O on C.CustomerID=O.CustomerID left join [Order Details] D on O.OrderID=D.OrderID
	group by C.CustomerID,C.City
	having count(distinct D.ProductID)<2)M
	group by City 
	having count(ID)>=2

go

create procedure sp_zhenming_2 
as	
	with M as (
		select C.CustomerID as ID,C.City as City,count(distinct D.ProductID) as count
		from Customers C left join Orders O on C.CustomerID=O.CustomerID left join [Order Details] D on O.OrderID=D.OrderID
		group by C.CustomerID,C.City
		having count(distinct D.ProductID)<2
	)
	select M.City 
	from M
	group by City 
	having count(ID)>=2

--12
--by add foreign key constrains

--14
/*
select [First name] + ' ' + [Last Name]+ case When Middle Name='' then '' else [Middle Name]+'.' End from table
*/

--15
/*
select top 1 Marks
from table
where Sex='F'
order by Marks DESC
*/

--16
/*
select *
from table 
order by Makrs,Sex
*/