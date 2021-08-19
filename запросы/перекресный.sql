CREATE TABLE Новая 
(
[Рейс] nvarchar(10),
 [View] nvarchar(15),
 price int
 );
 
INSERT INTO Новая
VALUES
('Рейс 1', 'Цена 1 класс', 2000),
('Рейс 1', 'Цена 2 класс', 3000),
('Рейс 1', 'Цена 3 класс', 4000),
('Рейс 2', 'Цена 1 класс', 5000),
('Рейс 2', 'Цена 2 класс', 6000),
('Рейс 2', 'Цена 3 класс', 7000);
 
--DECLARE @s varchar(max);
 
--SELECT @s = stuff((
-- select distinct ', ' + quotename([View]) 
--FROM Новая order by ', ' + quotename([View]) 
--for xml path(''), type).value('.', 'varchar(max)'), 1, 2, '');
 
--SELECT @s = 'select *from Новая
-- pivot(max(price) for [View] in (' + @s + ')) as pvt'
-- ;
--SELECT @s;
--EXEC(@s);
--GO

SELECT * FROM Новая
pivot(max(price) 
for [View] in ([Цена 1 класс],[Цена 2 класс],[Цена 3 класс])) as pvt

DROP TABLE Новая;
GO