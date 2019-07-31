create procedure InsertarCliente 
 @doc int, 
 @nom varchar(30) ,
 @ape varchar(30), 
 @fecafi date,
 @cup float,
 @cor varchar (150),
 @cel varchar(12)
 As
 BEGIN
 
 INSERT INTO TbClientes values (@doc, @nom, @ape, @fecafi,@cup,@cor,@cel);

End

execute InsertarCliente '12234', 'Freddy', 'Simanca', '20-02-2018' , 15000000, 'Simanca@yahoo.com' , '999' 

execute InsertarCliente '1236666','20-07-2045','1222','sfdsdfa','weqrqwer','rere','ree'

select*from TbClientes