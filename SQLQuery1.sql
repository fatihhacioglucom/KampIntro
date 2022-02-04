--select
--Allias TabloAdi GemlesiniİstediğimAd
--ANSII Standartı
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
select * from Products where CategoryID = 1 or CategoryID = 3 --veya "or"

select * from Products where CategoryID = 1 and UnitPrice >= 10 --ve "and"

select * from Products where CategoryID = 1 order by UnitPrice desc --sırala "order by" --ascending (artan) "asc" --descending (azalan) "desc"

Select count(*) Adet from Products where CategoryID = 2 --"count" adet demek tüm satırları say

select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice > 10 --inner join sadece iki tabloda eşleşenleri bir araya getirir eşleşmeyen tablo varsa getirmez

--DTO Data Transformation object

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null --"left join" solda olup sağda olmayanları da getir