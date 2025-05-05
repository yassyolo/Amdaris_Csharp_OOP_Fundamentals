/*Top 20 customers wit most sales*/
/*SELECT TOP 20 c.CustomerID, COUNT(so.SalesOrderID) AS TotalOrders
FROM Sales.Customer c
JOIN Sales.SalesOrderHeader so ON c.CustomerID = so.CustomerID
GROUP BY c.CustomerID
ORDER BY TotalOrders DESC;*/

/*Top 10 salesmen with most orders*/
/*SELECT TOP 10 SalesPersonID, COUNT(SalesOrderID) AS TotalOrders
FROM Sales.SalesOrderHeader
GROUP BY SalesPersonID
ORDER BY TotalOrders DESC;*/

/*Difference in sales quota versus actual sales*/
/*SELECT BusinessEntityID, SalesQuota, SalesYTD, SalesYTD - SalesQuota AS DifferenceFromQuota
FROM Sales.SalesPerson
WHERE SalesQuota IS NOT NULL
ORDER BY DifferenceFromQuota DESC;*/

/*Returns duplicate store names*/
/*SELECT Name, COUNT(BusinessEntityID) AS TotalStores
FROM Sales.Store
GROUP BY Name
HAVING COUNT(*) > 1
ORDER BY TotalStores DESC;*/

/*Returns sum of the last years sales*/
/*SELECT SUM(SalesLastYear) AS TotalSalesLastYear FROM Sales.SalesTerritory;*/

/*Returns average tax rate*/
/*SELECT AVG(TaxRate) AS AverageTaxRate
FROM Sales.SalesTaxRate;*/

/*Returns average tax rate per type*/
/*SELECT TaxType, AVG(TaxRate) AS AvgTaxRate
FROM Sales.SalesTaxRate
GROUP BY TaxType;*/

/*Returns cards number by type*/
SELECT CardType, COUNT(*) AS CardsCount
FROM Sales.CreditCard
GROUP BY CardType;




