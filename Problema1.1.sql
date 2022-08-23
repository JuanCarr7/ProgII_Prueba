create database Carreras

use Carreras

create table asignaturas
(id_asignatura int identity(1,1),
nombre varchar (30),
constraint pk_asignatura primary key (id_asignatura)
)

create table DetalleCarrera
(id_detalle int identity (1,1),
anio_cursado int,
cuatrimestre varchar (30),
id_asignatura int,
constraint pk_Detalles primary key (id_detalle),
constraint fk_detalles foreign key (id_asignatura) references asignaturas (id_asignatura)
)

create table Carrera
(id_carrera int identity(1,1),
id_detalle int,
titulo varchar (30),
constraint pk_carrera primary key (id_carrera),
constraint fk_carrera foreign key (id_detalle) references DetalleCarrera (id_detalle)
)


create proc pa_insertar_detalle
@

create proc sp_consultar_asignaturas
as
Select * from asignatura
exec pa_consultar_asignaturas

alter procedure pa_consultar_asignaturas
as
select *
from asignatura

alter proc pa_consultar_Detalle
as
select id_detalle, anio_cursado "Año de Cursado", cuatrimestre, nombre "Nombre de la materia" from DetalleCarrera DC join asignatura A on A.id_asignatura = DC.id_asignatura

exec pa_consultar_Detalle

insert into DetalleCarrera
values (


insert 
into Asignatura 
values ('Programación')
insert 
into Asignatura 
values ('Álgebra y Geometría analítica')
insert 
into Asignatura 
values ('Laboratorio de Computacion')
insert 
into Asignatura 
values ('Física')
insert 
into Asignatura 
values ('Inglés')




