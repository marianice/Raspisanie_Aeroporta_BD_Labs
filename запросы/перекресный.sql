CREATE TABLE ����� 
(
[����] nvarchar(10),
 [View] nvarchar(15),
 price int
 );
 
INSERT INTO �����
VALUES
('���� 1', '���� 1 �����', 2000),
('���� 1', '���� 2 �����', 3000),
('���� 1', '���� 3 �����', 4000),
('���� 2', '���� 1 �����', 5000),
('���� 2', '���� 2 �����', 6000),
('���� 2', '���� 3 �����', 7000);
 
--DECLARE @s varchar(max);
 
--SELECT @s = stuff((
-- select distinct ', ' + quotename([View]) 
--FROM ����� order by ', ' + quotename([View]) 
--for xml path(''), type).value('.', 'varchar(max)'), 1, 2, '');
 
--SELECT @s = 'select *from �����
-- pivot(max(price) for [View] in (' + @s + ')) as pvt'
-- ;
--SELECT @s;
--EXEC(@s);
--GO

SELECT * FROM �����
pivot(max(price) 
for [View] in ([���� 1 �����],[���� 2 �����],[���� 3 �����])) as pvt

DROP TABLE �����;
GO