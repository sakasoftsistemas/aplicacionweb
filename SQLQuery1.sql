create database bd_pizzeria
go

use bd_pizzeria
go


create table tipoUsuario(
idTipoUsuario int not null primary key identity,
descripcion varchar(80) not null,
estado bit
)
go



insert into tipoUsuario values('Administrador',1),('Operador',1)



create table usuario(
idUsuario int identity primary key not null,
dni char(8) not null,
nombres varchar(40) not null,
apePaterno varchar(40) not null,
apeMaterno varchar(40) not null,
direccion varchar(80) not null,
fechaRegistro datetime,
telefono varchar(9),
correo varchar(25),
usu varchar(15) not null,
contrasenia varchar(10) not null,
idTipoUsuario int not null
)
go


alter table usuario add foreign key (idTipoUsuario) references tipoUsuario(idTipoUsuario)



create table tipoProducto(
idTipoProducto int identity not null primary key,
descripcion varchar(80) not null,
estado bit
)
go


insert into tipoProducto values('Pizzas',1),('Bebidas',1)



create table presentacion(
idPresenteacion int identity not null primary key,
descripcion varchar(50) not null,
estado bit,
idTipoProducto int not null
)
go

alter table presentacion add foreign key (idTipoProducto) references tipoProducto(idTipoProducto)

insert into presentacion values('Pequeña',1,1),('Mediana',1,1),('Grande',1,1),('Familiar',1,1)
insert into presentacion values('Personal',1,2),('1/2 L',1,2),('1L',1,2),('1L 1/2',1,2),('2L',1,2),('2L 1/2',1,2),('3L',1,2)

select * from presentacion


create table producto(
idProducto int identity not null primary key,
descripcion varchar(80) not null,
precio decimal(12,2) not null,
stockInicial int not null,
stockActual int not null,
fechaRegistro datetime not null,
imagen varchar(70),
idPresenteacion int not null
)
go



alter table producto add foreign key (idPresenteacion) references presentacion(idPresenteacion)




insert into producto values('Pizza Hawaiana',15.50,500,500,getdate(),'',1)
insert into producto values('Pizza Amricana',15.50,500,500,getdate(),'',1)
insert into producto values('Pizza Vegetariana',15.50,500,500,getdate(),'',1)
insert into producto values('Pizza Pepperoni',15.50,500,500,getdate(),'',1)

insert into producto values('Pizza Hawaiana',20.50,500,500,getdate(),'',2)
insert into producto values('Pizza Amricana',20.50,500,500,getdate(),'',2)
insert into producto values('Pizza Vegetariana',20.50,500,500,getdate(),'',2)
insert into producto values('Pizza Pepperoni',20.50,500,500,getdate(),'',2)

insert into producto values('Pizza Hawaiana',35.50,500,500,getdate(),'',3)
insert into producto values('Pizza Amricana',35.50,500,500,getdate(),'',3)
insert into producto values('Pizza Vegetariana',35.50,500,500,getdate(),'',3)
insert into producto values('Pizza Pepperoni',35.50,500,500,getdate(),'',3)

insert into producto values('Pizza Hawaiana',55.50,500,500,getdate(),'',4)
insert into producto values('Pizza Amricana',55.50,500,500,getdate(),'',4)
insert into producto values('Pizza Vegetariana',55.50,500,500,getdate(),'',4)
insert into producto values('Pizza Pepperoni',55.50,500,500,getdate(),'',4)


select * from producto

--set language english
create procedure usp_registrarUsuario
@idTipoUsuario int,
@dni char(8),
@nombres varchar(40),
@apePaterno varchar(40),
@apeMaterno varchar(40),
@direccion varchar(80),
@telefono varchar(9),
@correo varchar(25),
@usu varchar(15),
@contrasenia varchar(10)
as
begin
insert into usuario (dni,nombres,apePaterno,apeMaterno,direccion,fechaRegistro,telefono,correo,usu,contrasenia,idTipoUsuario)
values(@dni,@nombres,@apePaterno,@apeMaterno,@direccion,getdate(),@telefono,@correo,@usu,@contrasenia,@idTipoUsuario)
end
go




create procedure usp_login 
@usu varchar(15),
@contrasenia varchar(10)
as
begin
select idUsuario, nombres,apePaterno,apeMaterno from usuario where usu = @usu and contrasenia = @contrasenia
end
go





create procedure usp_actualizarClave
@dni  varchar(8),
@clave char(6)
as
begin
update usuario set contrasenia = @clave where dni = @dni
end
go




create procedure usp_validarCorreo 
@dni  varchar(8),
@correo varchar(25)
as
begin
select count(correo) cantidad  from usuario where dni = @dni and correo = @correo
end
go



create procedure usp_tipoUsuario
as
begin
select 0 idTipoUsuario,'--seleccione--' descripcion
union
select idTipoUsuario, descripcion from tipoUsuario where estado = 1
end
go
--select count(correo) cantidad  from usuario where  dni='72293695'and correo= 'recatore_18@hotmail.com'



create procedure usp_presentacion_sel 
@idTipoProducto int
as
begin
select idPresenteacion,descripcion from presentacion where idTipoProducto = @idTipoProducto and estado =1
end
go



create procedure usp_productos_sel 1
@idPresenteacion int
as
begin
select idProducto,descripcion,precio,stockActual,imagen from producto where idPresenteacion = @idPresenteacion
end
go

select * from producto
update producto set imagen = 'pizzaHawaiana.jpg' where idProducto=13
update producto set imagen = 'pizzaAmericana.jpg' where idProducto in(2,6,10,14)
update producto set imagen = 'pizzaVegetariana.jpg' where idProducto=15
update producto set imagen = 'pizzaPepperoni.jpg' where idProducto=16