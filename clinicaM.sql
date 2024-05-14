use master
create database clinicaM
go
use clinicaM
go

--------------------------Creacion de esquemas de la base---------------------------
create schema personal
go
create schema administracion
go
create schema medico
go

--------------------------Creacion de tablas de la base---------------------------
create table administracion.pacientes
(
	codPaciente char(7) not null,
	primerNombre varchar(20) not null,
	segundoNombre varchar(20) null,
	primerApellido varchar(20) not null,
	segundoApellido varchar(20) null,
	direccion varchar(200),
	telefono char(9),
	sexo char(1) not null,
	fechaNacimiento date not null,
	dui char(10) unique,
	nit char(17)unique
)

create table personal.medicos
(
	codMedico char(7) not null,
	primerNombre varchar(20) not null,
	primerApellido varchar(20) not null,
	telefono char(9) not null,
	especialidad varchar(50) not null,
	clave char(7)
)

create table administracion.citasMedicas
(
	codCita char(7) not null,
	codPaciente char(7) not null,
	codMedico char(7) not null,
	especialidad varchar(50) not null,
	fechaHora datetime
)

create table medico.reportes
(
	codReporte char(7) not null,
	codCita char(7) not null,
	motivo varchar(500) not null,
	diagnostico varchar(1000) not null
)

create table medico.signosVitales
(
	codReporte char(7) not null,
	peso numeric(5,2),
	talla numeric (5,2),
	temperatura numeric(3,1),
	presionArterial varchar(8)
)
go
-------------------------------------Fin de la creación de tablas-------------------------------------


-------------------------------------Primary keys-------------------------------------

--Tabla paciente
alter table administracion.pacientes
add constraint pk_codPaciente
primary key (codPaciente)

--Tabla Medico
alter table personal.medicos
add constraint pk_codMedico
primary key (codMedico)

--tabla citaMedica
alter table administracion.citasMedicas
add constraint pk_codCita
primary key (codCita)

--Tabla reporte
alter table medico.reportes
add constraint pk_codReporte
primary key (codReporte)
go
-------------------------------------Fin de las primary keys-------------------------------------


-------------------------------------Foreign keys-------------------------------------

--Tabla cita
alter table administracion.citasMedicas
add constraint fk_codPacienteC
foreign key (codPaciente)
references  administracion.pacientes(codPaciente)
on delete cascade
on update cascade

--Tabla
alter table administracion.citasMedicas
add constraint fk_codMedicoC
foreign key (codMedico)
references  personal.medicos(codMedico)

--Tabla reporte
alter table medico.reportes
add constraint fk_codCitaR
foreign key (codCita)
references  administracion.citasMedicas(codCita)
on delete cascade
on update cascade

--Tabla signosVitales
alter table medico.signosVitales
add constraint fk_codReporteSV
foreign key (codReporte)
references  medico.reportes(codReporte)
on delete cascade
on update cascade
go
-------------------------------------Fin de las foreign keys-------------------------------------


-------------------------------------Restricciones-------------------------------------

alter table administracion.citasMedicas
add constraint ch_fechaHora
check (fechaHora >= getdate())

alter table medico.signosVitales
add constraint ch_peso
check (peso >=0 and peso<=999)

alter table medico.signosVitales
add constraint ch_talla
check (talla >=0 and talla <=3)

alter table medico.signosVitales
add constraint ch_temperatura
check (talla >=0 and talla <= 45)
go
-------------------------------------Fin de las resticciones-------------------------------------


-------------------------------------Extras necesarios-------------------------------------


--Edad calculada tabla paciente
ALTER TABLE administracion.pacientes
ADD edad
    AS (CONVERT(INT,CONVERT(CHAR(8),GETDATE(),112))-CONVERT(CHAR(8),fechaNacimiento,112))/10000;

--Hora calculada tabla cita medica

ALTER TABLE administracion.citasMedicas
ADD hora
    AS RIGHT( CONVERT(DATETIME, fechahora, 108),8) 

go
-------------------------------------Fin de los extras-------------------------------------


-------------------------------------Procedimientos almacenados-------------------------------------



---------Procedimiento almacenado pacientes---------

create procedure administracion.InscribirPaciente(
--Datos que van a entrar
@pnom varchar(20),
@snom varchar(20), 
@pape varchar(20), 
@sape varchar(20), 
@dir varchar(200),
@tel char(9),
@sex char(1),
@fecha date,
@dui char(10),
@nit char(17))
as
--Armando el codigo
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @n1 = (select count(codPaciente) from administracion.pacientes) +1

if (@n1 < 10)

begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @l1 = SUBSTRING(@pape,1,1)
set @l2 = SUBSTRING(@pnom,1,1)

set @cod = 'P'+@l1+@l2+@l3

insert into administracion.pacientes (codPaciente,primerNombre,segundoNombre,primerApellido,segundoApellido,direccion,telefono,sexo,fechaNacimiento,dui,nit)
values (UPPER(@cod),@pnom,@snom,@pape,@sape,@dir,@tel,@sex,@fecha,@dui,@nit)

go
---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado médico---------

create procedure personal.InscribirMedico
(
@pnom varchar(20),
@pape varchar(20),
@tel char(9),
@esp varchar(50)
)
as
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @n1 = (select count(codMedico) from personal.medicos) +1

if (@n1 < 10)

begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @l1 = SUBSTRING(@pape,1,1)
set @l2 = SUBSTRING(@pnom,1,1)

set @cod = 'M'+@l1+@l2+@l3

insert into personal.medicos(codMedico,primerNombre,primerApellido,telefono,especialidad,clave) values
(upper(@cod),@pnom,@pape,@tel,@esp,reverse(@cod))

go
---------fin del Procedimiento Almacenado---------

---------Procedimiento almacenado cita médica---------
create procedure administracion.IngresarCita
(
@codP char(7),
@codM char(7),
@fechaH datetime,
@esp varchar(50)
)
as
declare @l1 char(1)
declare @l2 char(1)
declare @n1 int
declare @l3 char(4)
declare @cod char(7)

set @l1 = substring((select primerApellido from administracion.pacientes  where codPaciente like @codP),1,1)
set @l2 = substring((select primerNombre from administracion.pacientes  where codPaciente like @codP),1,1)

set @n1 = (select count(codCita) from administracion.citasMedicas where codPaciente like @codP) +1

if (@n1 < 10)
begin
set @l3 = '000'+trim(str(@n1))
end

else if (@n1 >=10 and @n1 < 100)
begin
set @l3 = '00'+trim(str(@n1))
end

else if (@n1 >=100 and @n1 <1000)
begin
set @l3 = '0'+trim(str(@n1))
end

else if (@n1 >=1000)
begin
set @l3 = trim(str(@n1))
end

set @cod = 'C'+@l1+@l2+@l3

insert into administracion.citasMedicas(codCita,codPaciente,codMedico,especialidad,fechaHora) values
(upper(@cod),@codP,@codM,@esp,@fechaH)

go
---------fin del Procedimiento Almacenado---------

---------Procedimiento almacenado reporte---------

create procedure medico.CrearReporte
(
	@codcita char(7),
	@mot varchar(500),
	@diag varchar(1000),
	@peso numeric(5,2),
	@tal numeric (5,2),
	@temp numeric(3,1),
	@presi varchar(8)
)
as

declare @cod char(7)
set @cod = 'R'+SUBSTRING(@codcita,2,6)

insert into medico.reportes(codReporte,codCita,motivo,diagnostico) values
(upper(@cod),@codcita,@mot,@diag)

insert into medico.signosVitales(codReporte,peso,talla,temperatura,presionArterial) values
(upper(@cod),@peso,@tal,@temp,@presi)

go
---------fin del Procedimiento Almacenado---------


---------Procedimiento almacenado medicamento---------
create procedure medico.AgregarMedicamento
(
	@codR char(7),
	@nom varchar(20),
	@indi varchar(200)
)
as

insert into medico.medicamentos(codReceta,nombreMedicamento,indicaciones) values
(@codR,@nom,@indi)

go
---------fin del Procedimiento Almacenado---------

-------------------------------------Triggers-------------------------------------

--A nivel general de la Base de datos
create trigger tr_SeguridadBD
on database for drop_table
as
begin
raiserror('---No está permitido borrar tablas---',16,1)
rollback transaction
end

go

--TABLA PACIENTE
--Trigger que evita que se mofifique el código del paciente


create trigger tr_UPacientes
on administracion.pacientes
instead of update
as
if update(codpaciente)
begin
raiserror('El código del paciente no se puede modificar',10,1)
rollback transaction
end;

go
--Trigger que muestra un mensaje cada que se ingresa un paciente nuevo
create trigger tr_registroPaciente
on administracion.pacientes
for insert
as
print'---Registro de paciente existóso--'

go

--secuencia para crear diferentes código de reportes
CREATE SEQUENCE medico.ReporteSequence
    START WITH 1
    INCREMENT BY 1;
go
--Crear reporte versión 2, con secuencia
create procedure medico.CrearReporte2p
(
    @codcita char(7),
    @mot varchar(500),
    @diag varchar(1000),
    @peso numeric(5,2),
    @tal numeric (5,2),
    @temp numeric(3,1),
    @presi varchar(8)
)
as
begin
    declare @cod char(7)
    declare @seq int

    -- Obtener el siguiente valor de la secuencia
    select @seq = NEXT VALUE FOR medico.ReporteSequence

    set @cod = 'R' + RIGHT('0000' + CAST(@seq AS VARCHAR(5)), 4)

    insert into medico.reportes(codReporte, codCita, motivo, diagnostico)
    values (upper(@cod), @codcita, @mot, @diag)

    insert into medico.signosVitales(codReporte, peso, talla, temperatura, presionArterial)
    values (upper(@cod), @peso, @tal, @temp, @presi)
end



