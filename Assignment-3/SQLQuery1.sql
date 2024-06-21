USE Northwind 
GO

--1.      List all cities that have both Employees and Customers.
SELECT DISTINCT c.City 
FROM Customers c 
WHERE c.City IN (
	SELECT DISTINCT e.City 
	FROM Employees e);
--2.      List all cities that have Customers but no Employee.

	--a.      Use sub-query
	SELECT DISTINCT c.City 
	FROM Customers c 
	WHERE c.City NOT IN (
		SELECT DISTINCT e.City 
		FROM Employees e);
	--b.      Do not use sub-query
	SELECT DISTINCT C.City
	FROM Customers C
	LEFT JOIN Employees E ON C.City = E.City
	WHERE E.City IS NULL;

--3.      List all products and their total order quantities throughout all orders.
SELECT p.ProductId, SUM(od.Quantity) AS TotalQuantityOrdered
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductId
GROUP BY p.ProductID
ORDER BY TotalQuantityOrdered DESC;
--4.      List all Customer Cities and total products ordered by that city.

SELECT c.City, SUM(od.Quantity) AS TotalQuantityOrdered
FROM Customers c JOIN Orders o ON c.CustomerId = o.CustomerId JOIN [Order Details] od ON o.OrderId = od.OrderId
GROUP BY c.City
ORDER BY TotalQuantityOrdered DESC;
--5.      List all Customer Cities that have at least two customers.

	--a.      Use union
	SELECT City
	FROM Customers
	GROUP BY City
	HAVING COUNT(CustomerId) >= 2
	--b.      Use sub-query and no union

--6.      List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Customers c JOIN Orders o ON c.CustomerId = o.CustomerId JOIN [Order Details] od ON o.OrderId = od.OrderId
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;

--7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.

SELECT DISTINCT c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c JOIN Orders o ON c.CustomerId = o.CustomerId
WHERE c.City != o.ShipCity;
--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it. 
SELECT TOP 5
    p.ProductID, 
    p.ProductName,
    AVG(p.UnitPrice) AS AveragePrice,
    (SELECT TOP 1 c.City
     FROM Orders o
     JOIN [Order Details] od ON o.OrderID = od.OrderID
     JOIN Customers c ON o.CustomerID = c.CustomerID
     WHERE od.ProductID = p.ProductID
     GROUP BY c.City
     ORDER BY SUM(od.Quantity) DESC) AS TopCity
FROM 
    Products p
JOIN 
    [Order Details] od ON p.ProductID = od.ProductID
GROUP BY 
    p.ProductID, p.ProductName
ORDER BY 
    SUM(od.Quantity) DESC;

--9.      List all cities that have never ordered something but we have employees there.

	--a.      Use sub-query
	SELECT DISTINCT E.City
	FROM Employees E
	WHERE E.City NOT IN (
		SELECT DISTINCT C.City
		FROM Customers C
		JOIN Orders O ON C.CustomerID = O.CustomerID
	);

	--b.      Do not use sub-query
	SELECT DISTINCT E.City
	FROM Employees E LEFT JOIN (
		SELECT DISTINCT C.City
		FROM Customers C
		JOIN Orders O ON C.CustomerID = O.CustomerID
	) AS CustomerOrders ON E.City = CustomerOrders.City
	WHERE CustomerOrders.City IS NULL;
--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT eo.EmployeeCity AS EmployeeCityWithMostOrders, pq.CustomerCity AS CustomerCityWithMostTotalQuantity
FROM (
    SELECT e.City AS EmployeeCity, COUNT(o.OrderID) AS TotalOrders, RANK() OVER (ORDER BY COUNT(o.OrderID) DESC) AS OrderRank
	FROM Employees e LEFT JOIN Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
    ) eo
, (
	SELECT c.City AS CustomerCity, SUM(od.Quantity) AS TotalQuantity, RANK() OVER (ORDER BY SUM(od.Quantity) DESC) AS QuantityRank
    FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY c.City
    ) pq 
	WHERE eo.OrderRank = 1 AND pq.QuantityRank = 1;


--11. How do you remove the duplicates record of a table?

--WITH CTE AS (
--    SELECT ID, Column1, Column2, ROW_NUMBER() OVER(PARTITION BY Column1, Column2 ORDER BY ID) AS RowNumber
--    FROM YourTable
--)
--DELETE FROM CTE
--WHERE RowNumber > 1;