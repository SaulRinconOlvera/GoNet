Select  Titular, 
        Min(monto) as Minimo,
        Max(monto) as Maximo,
        Count(Titular) as Depositos,
        Sum(monto) / Count(monto) as Promedio
FROM    Depositos 
GROUP   by titular
HAVING  Count(Titular) > 1
And     (Sum(monto) / Count(monto)) > 50