--USE [����������������� � ���������� ������1SQL]
--GO

--create table ��������� ([���] nvarchar(10), [����� �����] int, [���� �� �����] int) ;
 
--insert into ���������
--values
--('�������� �.�.', 1, 3000),
--('�������� �.�.', 2, 1900),
--('�������� �.�.', 3, 7000),
--('�������� �.�.', 1, 1900),
--('�������� �.�.', 2, 17000),
--('�������� �.�.', 3, 7000);
 
--declare @s varchar(max);
 
--select @s = stuff((
-- select distinct ', ' + quotename([���]) from ��������� order by ', ' + quotename([����� �����]) for xml path(''), type
--).value('.', 'varchar(max)'), 1, 2, '');
 
--select @s = '
--select * from  ���������
-- pivot(max([���� �� �����]) for [����� �����] in (' + @s + ')) as pvt'
 
--select @s;
--exec(@s);
--go
 
--drop table ���������;
--go




create table #t ([Type] varchar(10), [View] varchar(10), Procent numeric(3,1));
 
insert into #t
values
('type_a', 'view_a', 0.2),
('type_a', 'view_b', 0.3),
('type_a', 'view_c', 0.4),
('type_b', 'view_a', 0.5),
('type_b', 'view_b', 0.6),
('type_b', 'view_c', 0.7);
 
declare @s varchar(max);
 
select @s = stuff((
 select distinct ', ' + quotename([View]) from #t order by ', ' + quotename([View]) for xml path(''), type
).value('.', 'varchar(max)'), 1, 2, '');
 
select @s = 'select *from #t
 pivot(max(Procent) for [View] in (' + @s + ')) as pvt'
 
select @s;
exec(@s);
go
 
drop table #t;
go