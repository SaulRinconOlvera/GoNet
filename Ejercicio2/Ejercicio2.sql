--	Crate table
Create TABLE Depositos (Titular nvarchar(30), monto int)
Go;

--	Insert data
Insert into Depositos 
Values('Ana', 50), ('Paco', 10), ('Ana', 20), ('Jorge', 55), ('Laura', 75), ('Laura', 3), ('Laura', 50)
Go;

--	Select data
Select  Titular, 
        Min(monto) as Minimo,
        Max(monto) as Maximo,
        Count(Titular) as Depositos,
        Sum(monto) / Count(monto) as Promedio
FROM    Depositos 
GROUP   by titular
HAVING  Count(Titular) > 1
And     (Sum(monto) / Count(monto)) > 50