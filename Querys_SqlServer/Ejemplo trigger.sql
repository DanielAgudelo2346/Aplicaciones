
create trigger ActualizarStock on
tbEntradas after insert as 
begin
 set NOCOUNT on;
 UPDATE tbProductos set Stock= (Select Cantidad from Inserted)
 where Codigo= (Select Codigo from inserted)

end

Select * from tbEntradas
Select*from tbProductos


