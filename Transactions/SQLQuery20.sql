BEGIN TRANSACTION;
INSERT INTO Sales.SpecialOffer (Description, DiscountPct, Type, Category, StartDate, EndDate, MinQty, MaxQty, rowguid, ModifiedDate)
VALUES ('Summer Clearance 2025', 0.20, 'Reseller', 'Clearance', '2025-07-01', '2025-08-31', 1, NULL, NEWID(), GETDATE());
COMMIT TRANSACTION;

BEGIN TRANSACTION
UPDATE Sales.SpecialOffer
SET Description = 'Updated Volume Discount for Resellers'
WHERE Description = 'Volume Discount';
COMMIT TRANSACTION;

BEGIN TRANSACTION;
INSERT INTO Sales.SpecialOffer (Description, DiscountPct, Type, Category, StartDate, EndDate, MinQty, MaxQty, rowguid, ModifiedDate)
VALUES ('Back to School Promo', 0.05, 'Reseller', 'Seasonal', '2025-08-01', '2025-09-15', 1, NULL, NEWID(), GETDATE());
COMMIT TRANSACTION;

BEGIN TRANSACTION;
UPDATE Sales.SpecialOffer
SET DiscountPct = 0.10
WHERE Description = 'Back to School Promo';
COMMIT TRANSACTION;

BEGIN TRANSACTION;
UPDATE Sales.SpecialOffer
SET DiscountPct = 0.25
WHERE Description = 'Holiday Discount';
UPDATE Sales.SpecialOffer
SET ModifiedDate = GETDATE()
WHERE Description = 'Holiday Discount';
COMMIT TRANSACTION;

BEGIN TRANSACTION;
UPDATE Sales.SpecialOffer
SET DiscountPct = 0.15
WHERE Description = 'Overstock Sale';
UPDATE Sales.SpecialOffer
SET ModifiedDate = GETDATE()
WHERE Description = 'Overstock Sale';
COMMIT TRANSACTION;

BEGIN TRANSACTION;
DELETE FROM Sales.SpecialOffer
WHERE EndDate < '2025-01-01';
COMMIT TRANSACTION;

BEGIN TRANSACTION;
INSERT INTO Sales.SpecialOffer (Description, DiscountPct, Type, Category, StartDate, EndDate, MinQty, MaxQty, rowguid, ModifiedDate)
VALUES ('New Year Special Offer', 0.18, 'Retail', 'Seasonal', '2025-12-26', '2026-01-15', 1, NULL, NEWID(), GETDATE());
UPDATE Sales.SpecialOffer
SET ModifiedDate = GETDATE()
WHERE Description = 'New Year Special Offer';
COMMIT TRANSACTION;

