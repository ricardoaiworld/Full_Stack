--1 a view is the result set of a stored query on the data, which the database users can query just as they would in a persistent database collection object. 
--This pre-established query command is kept in the database dictionary.
--2 No
--3 A stored procedure is a subroutine available to applications that access a relational database management system. Such procedures are stored in the database data dictionary. 
--Uses for stored procedures include data-validation or access-control mechanisms.
--4 View can only show data while stored procedure can modifiy data by inserting, delelting.
--5 The function must return a value but in Stored Procedure it is optional. Even a procedure can return zero or n values. Functions can have only input parameters for 
--it whereas Procedures can have input or output parameters. Functions can be called from Procedure whereas Procedures cannot be called from a Function
--6 Yes
--7 Yes
--8  trigger is procedural code that is automatically executed in response to certain events on a particular table or view in a database.
-- There are DML, DDL, and Database triggers
--9 If you want to automatically execute something when data get changed.
--10 Trigger is a stored procedure runs automatically.

--1
insert into region(RegionID, RegionDescription) values (5, 'Middle Earth')
insert into Territories(TerritoryID,TerritoryDescription,RegionID) VALUES (98105, 'Gondor', 5)
insert into Employees(EmployeeID,FirstName,LastName) values (10, 'Aragorn', 'King')
insert into EmployeeTerritories(EmployeeID, TerritoryID) values(10, 98105)
--2
update Territories set TerritoryDescription='Arnor' where TerritoryDescription='Aragorn'
--3
delete from Region where RegionDescription='Middle Earth'
--4 
create VIEW view_product_order_Wang as (select ProductID, sum(Quantity) as TotalSum from [Order Details] group by ProductID)
--5
create PROCEDURE sp_product_order_quantity_wang
    @input INT,
    @output int OUTPUT
    as 
    select @output= temp.Total from (select ProductID, count(*) as Total from [Order Details] group by ProductID) temp where temp.ProductID=@input
--6
create PROCEDURE sp_product_order_city_wang 
    @input varchar(20),
    @output1 varchar(20) output,
    @output2 int output
    as
    select top 5 @output1=o.ShipCity,@output2=count(*) from orders o inner join [Order Details] d on o.OrderID=d.OrderID inner join Products p on p.ProductID=d.ProductID
where ProductName=@input
group by p.ProductName, o.ShipCity
order by count(*) desc
--7
create PROCEDURE sp_move_employees_wang 
    @total int
    as 
    begin
    set @total = (select e.EmployeeID from EmployeeTerritories e inner join Territories t on e.TerritoryID=t.TerritoryID where TerritoryDescription='Tory')
    IF @total >=0
        BEGIN
        insert into Territories values ('Stevens Point')
--8

        

