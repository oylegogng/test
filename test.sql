SELECT Product."Name", Category."Name" FROM Products
JOIN Categories  ON Products.ID = Categories.ProductID
JOIN Categories  ON Categories.CategoryID = Categories.ProductID;
