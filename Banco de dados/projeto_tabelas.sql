create database Padaria
go

Use Padaria
go

Create schema Padaria authorization dbo
go

create table padaria.Cliente 
(
cli_cd int identity(1,1)primary key,
cli_sexo nvarchar(10)not null,
Cli_rg nvarchar(15),
cli_cep nvarchar(20) not null,
cli_bairro nvarchar(20) not null,
cli_nm nvarchar(50) not null,
Cli_cidade nvarchar(20)not null,
cli_end nvarchar(50)not null,
cli_email nvarchar(50),
cli_tel nvarchar(20) not null
)
go


create table padaria.encomenda
(
Enc_cd int identity(1,1)primary key,
Cli_cd nvarchar(50) not null,
Enc_desc_prod nvarchar(150),
Encom_quant varchar (20),
Preco_tot nvarchar(10) not null,
Verif_dados nvarchar(50),
enc_status nvarchar(20) not null,
)
go

create table padaria.produto
(
prod_cd int identity(1,1)primary key,
prod_nm nvarchar(15),
prod_descri nvarchar(150),
prod_quanti nvarchar(20),
prod_fornecedor nvarchar(20)
)
go



create table padaria.fornecedor
(
forn_cd int identity(1,1)primary key,
forn_nome nvarchar(100) not null,
forn_email  nvarchar (100),
forn_cnpj nvarchar (30) not null,
forn_end nvarchar (100) not null,
forn_cep nvarchar(20) not null,
forn_tel nvarchar(20) not null,
forn_cidade nvarchar(70) not null,
)

go

create table padaria.funcionarios
(
func_cd int identity(1,1)primary key,
func_nome nvarchar (200) not null,
func_sexo nvarchar(10)not null,
func_cpf nvarchar (20) not null,
func_rg nvarchar (30) not null,
func_end nvarchar (30) not null,
func_bairro nvarchar (20) not null,
func_cep nvarchar (50),
func_cid nvarchar (50) not null,
func_tel nvarchar (20) not null,
func_email nvarchar (150),
func_login nvarchar(20)not null,
func_senha nvarchar(20)not null,
func_cargo nvarchar(50)not null,
func_Obs nvarchar(50),
)
go

create table padaria.caixa
(
Caixa_cd int identity(1,1) primary key,
Func_cd nvarchar (100),
cli_nm nvarchar(100),
Descr_prod nvarchar (200),
Quant_cd nvarchar(50) not null,
preço_tot nvarchar(50) not null
)
go

create table Padaria.Preco
(
preco_cd int identity(1,1) primary key,
preco_nmprod nvarchar (30),
preco_quant nvarchar (50),
preco_comp nvarchar(50),
Preco_vend nvarchar(50),
preco_totLucro nvarchar(50),
preco_lucro nvarchar(50)

)
go



create table padaria.estoque
(
estoq_cd int identity(1,1) primary key,
estoq_produ nvarchar(50) not null,
estoq_descri nvarchar(150) not null,
estoq_quanti nvarchar(50) not null,
)
go

create table Padaria_relatorios
(
relat_cd int identity (1,1) primary key,
Func_nome nvarchar(50)not null,
descricao nvarchar(500) not null,
data nvarchar(100) not null,
) 
go

