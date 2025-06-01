SELECT
    p.ProductName,
    c.CategoryName
FROM
    Product p
LEFT JOIN
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN
    Category c ON pc.CategoryId = c.CategoryId
ORDER BY
    p.ProductName, c.CategoryName;
