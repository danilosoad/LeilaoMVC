create table Pessoas (
	
	ID int primary key not null,
	NOME varchar(50),
	IDADE varchar(3)
)

GO

create table Produtos (
	ID int primary key not null,
	NOME VARCHAR(50),
	VALOR FLOAT NOT NULL,
	ULTIMOLANCE FLOAT NOT NULL,
	ULTIMAPESSOAID INT ,
	ULTIMAPESSOANOME VARCHAR(50),
	CONSTRAINT FK_PESSOA FOREIGN KEY  (ULTIMAPESSOAID) REFERENCES PESSOAS (ID)
)


SELECT NOME AS NOME_PRODUTO, ULTIMOLANCE AS ULTIMO_LANCE FROM Produtos 