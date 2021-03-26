--Cria��o do banco de dados
create database Atividade1
go

--Usar o banco de dados criado
use Atividade1

--Cria��o da tabela
create table Filmes (
Id int identity(1,1) not null, -- Id n�mero inteiro identity incrementa o valor de 1 e come�a em 1. Id n�o pode ser nulo.
Titulo varchar(max) not null, -- T�tulo � string de tamanho m�ximo. N�o pode ser nulo.
Data_de_Lancamento date not null, -- Data � tipo date e n�o pode ser nulo.
Estudio varchar(max) not null -- Est�dio � string de tamanho m�ximo. N�o pode ser nulo.
)