CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
BEGIN
	set nocount on;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	From dbo.Product
	order by ProductName;
END