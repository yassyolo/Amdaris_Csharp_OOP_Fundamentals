/*SELECT FirstName, LastName, BusinessEntityID AS Employee_id
FROM Person.Person
ORDER BY LastName ASC;*/

/*SELECT p.BusinessEntityID, p.FirstName, p.LastName, ph.PhoneNumber
FROM Person.Person p
JOIN Person.PersonPhone ph ON p.BusinessEntityID = ph.BusinessEntityID
WHERE p.LastName LIKE 'L%'
ORDER BY p.LastName, p.FirstName;*/

/*SELECT ROW_NUMBER() OVER (PARTITION BY a.PostalCode ORDER BY sp.SalesYTD DESC) AS RowNum,
p.LastName, sp.SalesYTD, a.PostalCode
FROM Sales.SalesPerson sp
JOIN Person.Person p ON sp.BusinessEntityID = p.BusinessEntityID
JOIN Person.BusinessEntityAddress bea ON p.BusinessEntityID = bea.BusinessEntityID
JOIN Person.Address a ON bea.AddressID = a.AddressID
WHERE sp.TerritoryID IS NOT NULL AND sp.SalesYTD <> 0
ORDER BY a.PostalCode ASC, sp.SalesYTD DESC;*/

SELECT SalesOrderID, SUM(OrderQty * UnitPrice) AS TotalCost
FROM Sales.SalesOrderDetail
GROUP BY SalesOrderID
HAVING SUM(OrderQty * UnitPrice) > 100000;


