# Задание:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
# Ссылка на решение:
http://sqlfiddle.com/#!18/0014e5/12
# Код решения:
Создание тестовых данных:

CREATE TABLE Products
    (id int, ProductName varchar(max))
;
CREATE TABLE Categories
    (id int, CategoryName varchar(max))
;

CREATE TABLE ProductCategory
    (CategoryId int, ProductId int )
;

INSERT INTO Products
    (id, ProductName)
VALUES
    (1, 'Milk'),
    (2, 'Chees'),
    (3, 'Onion'),
    (4, 'Potato'),
    (5, 'Bread'),
    (6, 'Cap')
;
INSERT INTO Categories
    (id, CategoryName)
VALUES
    (1, 'MilkCategory'),
    (2, 'Grocery'),
    (3, 'Vegetables'),
    (4, 'Discounts')
;
INSERT INTO ProductCategory
    (CategoryId, ProductId)
VALUES
    (1, 1),
    (1, 2),
    (3, 3),
    (3, 4),
    (2, 5),
    (4, 1),
    (4, 5),
    (4, 2)
;

Запрос для выбора данных:

SELECT ProductName, CategoryName FROM Products
LEFT JOIN ProductCategory ON (Products.id = ProductCategory.ProductId)
LEFT JOIN Categories ON (Categories.id = ProductCategory.CategoryId)
