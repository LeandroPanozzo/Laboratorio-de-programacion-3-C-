Use CineYadoNEtConectado;
create table peliculas(
PeliculaID int primary key identity (1,1),
 Titulo varchar (255) not null,
 Director varchar (255),
 A�oEstrenoDEPelicula Date,
 Genero varchar(255),
 FechaYHoraParaver date,
 SalaEnLaQueEstaDisponible varchar,
 precio decimal,
 asientosComprados int
)
ALTER TABLE peliculas
DROP COLUMN A�o;
alter table peliculas add asientosComprados int; 
select *from peliculas;