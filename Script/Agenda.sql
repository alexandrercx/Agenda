create database DbAgenda

--drop table Contato
create table Contato(
Id int identity(1,1) primary key not null,
Nome varchar(40) not null,
Empresa varchar(40) null,
Endereco varchar(80) null
)

--drop table TipoContato
create table Classificacao(
Id int identity(1,1) primary key not null,
Descricao varchar(20) not null
)

--drop table Telefone
create table Telefone
(
Id int identity(1,1) primary key not null,
IdContato int foreign key references Contato(Id) ON DELETE CASCADE  not null,
IdClassificacao int foreign key references Classificacao(Id) not null,
Numero varchar(15) not null,
)

--drop table Email
create table Email
(
Id int identity(1,1) primary key not null,
IdContato int foreign key references Contato(Id)ON DELETE CASCADE not null,
IdClassificacao int foreign key references Classificacao(Id) not null,
EnderecoEmail varchar(80) not null,
)

--==============================
insert into Classificacao values('CASA')
insert into Classificacao values('TRABALHO')
insert into Classificacao values('OUTROS')

