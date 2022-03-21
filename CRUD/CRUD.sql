/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductID]
      ,[ItemName]
      ,[Color]
      ,[InserDate]
  FROM [BD_CRUD].[dbo].[Table_ProductInfo]