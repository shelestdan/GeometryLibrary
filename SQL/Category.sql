SELECT P.ProductName, COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID
