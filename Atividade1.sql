--Criação do banco de dados
create database Atividade1
go

--Usar o banco de dados criado
use Atividade1

--Criação da tabela
create table Filmes (
Id int identity(1,1) not null, -- Id número inteiro identity incrementa o valor de 1 e começa em 1. Id não pode ser nulo.
Titulo varchar(max) not null, -- Título é string de tamanho máximo. Não pode ser nulo.
Data_de_Lancamento date not null, -- Data é tipo date e não pode ser nulo.
Estudio varchar(max) not null -- Estúdio é string de tamanho máximo. Não pode ser nulo.
)