/*
1 result set is a set of data, could be empty or not, returned by a select statement, or a stored procedure, that is saved in RAM or displayed on a screen.
2 UNION remove depulicate elements, UNION ALL does not. 
3 intersection and minus
4 JOIN combines data into new columns. UNION combines data into new rows.
5 INNER JOIN returns matches in both tables. FULL JOIN combines the results of both left outer join and right outer join.
6 LEFT JOIN returns all data from left table, even if there are no matching in right table. OUTER JOIN returns all data of both left join and right join.
7 CROSS JOIN returns the Cartesian product of the sets of records from the two joined tables. It equals a inner join with join codition always be TRUE.
8 WHERE filter the data before grouping. HAVING filter the data after grouping.
9 Yes
*/

/*1*/
select count(distinct ProductID) from Production.Product
/*2*/
select count(distinct ProductID) from Production.Product where ProductSubcategoryID is not null
/*3*/
select ProductSubcategoryID, count(ProductSubcategoryID) as CountedProducts from Production.Product where ProductSubcategoryID is not null group by ProductSubcategoryID
/*4*/
select count(*) from Production.Product where ProductSubcategoryID is null
/*5*/
select ProductID, sum(Quantity) as TheSum from Production.ProductInventory group by ProductID
/*6*/
select ProductID, sum(Quantity) as TheSum from Production.ProductInventory where LocationID = 40 group by ProductID having sum(Quantity) < 100
/*7*/
select Shelf, ProductID, sum(Quantity) as TheSum from Production.ProductInventory where LocationID=40 group by shelf, ProductID having sum(Quantity) < 100
/*8*/
select ProductID,avg(Quantity) as TheAvg from Production.ProductInventory where LocationID=10 group by ProductID
/*9*/
select ProductID, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory group by ProductID, Shelf
/*10*/
select ProductID, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory where Shelf is not null group by ProductID, Shelf
/*11*/

/*12*/
select c.Name as Country, StateProvinceCode as Province from Person.CountryRegion as c inner join Person.StateProvince as s on c.CountryRegionCode = s.CountryRegionCode
/*13*/
select c.Name as Country, StateProvinceCode as Province from Person.CountryRegion as c inner join Person.StateProvince as s on c.CountryRegionCode = s.CountryRegionCode where c.Name='Germany' or c.name='Canada'
/*14*/
select d.OrderID, OrderDate from [Order Details] as d inner join Orders as o on d.OrderID = o.OrderID where Year(CURRENT_TIMESTAMP) - Year(OrderDate) < 25
/*15*/
select top 5 ShipPostalCode, count(*) as Total from [Order Details] as d inner join Orders as o on d.OrderID = o.OrderID group by ShipPostalCode order by count(*) desc
/*16*/
select top 5 ShipPostalCode, count(*) as Total from [Order Details] as d inner join Orders as o on d.OrderID = o.OrderID 
where year(CURRENT_TIMESTAMP)- year(OrderDate) < 20
group by ShipPostalCode order by count(*) desc
/*17*/
select City, count(*) as NumberOfCustomers from Customers group by City
/*18*/
select City, count(*) as NumberOfCustomers from Customers group by City having count(*) > 10 
/*19*/
select distinct ContactName from Orders as o inner join Customers as c on o.CustomerID = c.CustomerID
where OrderDate > DATEFROMPARTS(1998,01,01)
/*20*/
select ContactName, max(OrderDate) from Orders as o inner join Customers as c on o.CustomerID = c.CustomerID
group by o.CustomerID, ContactName
/*21*/
select ContactName, count(*) as Count from Orders as o inner join Customers as c on o.CustomerID = c.CustomerID
group by o.CustomerID, ContactName
order by Count desc
/*22*/
select CustomerID, count(*) as Count from Orders
group by CustomerID
having count(*) > 100
/*23*/
select s1.CompanyName, s2.CompanyName from Shippers as s1 cross join Suppliers as s2
/*24*/
select OrderDate, ProductName from Orders as o inner join [Order Details] as d on o.OrderID = d.OrderID inner join Products as p on p.ProductID = d.ProductID
order by OrderDate
/*25*/
select e1.EmployeeID, e2.EmployeeID from Employees as e1 inner join Employees as e2 on e1.Title = e2.Title
where e1.EmployeeID <> e2.EmployeeID
/*26*/
select ReportsTo as Manager from Employees
group by ReportsTo
having count(*) > 2
/*27*/
/*28*/
select * from T1 inner join T2 on T1.F1 = T2.F2
/*result:
2 2
3 3
*/
/*29*/
select * from T1 left outer join T2 on T1.F1 = T2.F2
/*result:
1 Null
2 2
3 3
*/



