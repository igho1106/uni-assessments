CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerID
	@CustomerID int
	
AS
	SELECT * from tblCustomer where CustomerID = @CustomerID

RETURN 0
