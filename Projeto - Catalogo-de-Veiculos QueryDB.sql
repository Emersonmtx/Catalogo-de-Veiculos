/*ATENÇÃO! NÃO EXECUTE TODO O CÓDIGO DE MANEIRA DIRETA, FIQUE ATENTO AOS COMENTÁRIOS */

/* Para facilitar a manipulação dos dados*/

DROP TABLE tblmarca								SELECT * FROM tblmarca
DROP TABLE tblTipoVeiculo						SELECT * FROM tblTipoVeiculo
DROP TABLE tblveiculo							SELECT * FROM tblveiculo

/* Execute primeiro este bloco*/
CREATE TABLE tblmarca (
	codMarca INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Marca VARCHAR(20)

)
GO

CREATE TABLE  tblTipoVeiculo (
	codTipo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	tipo VARCHAR(30),
	
)
GO

CREATE TABLE tblveiculo (
	codVeiculo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	anoVeiculo INT,
	modeloVeiculo VARCHAR(20),
	codMarca INT,
	codTipo INT
)
GO

/*logo após execute ALTER TABLE um de cada vez*/

ALTER TABLE tblVeiculo
ADD CONSTRAINT FK__tblVeiculo_tblmarca
FOREIGN KEY (codMarca) REFERENCES tblmarca(codMarca)
GO

ALTER TABLE tblVeiculo
ADD CONSTRAINT FK__tblVeiculo_tblTipoVeiculo
FOREIGN KEY (codTipo) REFERENCES tblTipoVeiculo(codTipo)

/* Executa-los de forma direta algumas vezes acabou gerando conflitos...*/


/* Caso haja necessidade de adicionar dados manuais em sua tabela */

INSERT INTO tblmarca(Marca) VALUES
	('Hyundai'),
	('Honda'),
	('Fiat'),
	('Volksvagem'),
	('Volvo')

INSERT INTO tblTipoVeiculo(tipo) VALUES
	('Carro'),
	('Moto'),
	('Serviço'),
	('Caminhão'),
	('Outros')

INSERT INTO tblveiculo(anoVeiculo, modeloVeiculo) VALUES
	(2017,'HB20s'),
	(2021,'MT-03'),
	(2006,'Uno'),
	(2011,'Meteor'),
	(2020,'VM(guincho)')

/*Última alteração: Quinta-Feira, 23 de maio de 2024, 22:00:23 */
