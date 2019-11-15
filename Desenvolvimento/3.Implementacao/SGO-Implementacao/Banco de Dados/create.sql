CREATE SCHEMA IF NOT EXISTS sgo DEFAULT CHARACTER SET utf8;
USE sgo;

CREATE TABLE IF NOT EXISTS `sgo`.`usuario` (
  `login` VARCHAR(25) NOT NULL,
	`senha` VARCHAR(25) NOT NULL,
    PRIMARY KEY(`login`)
);

INSERT INTO usuario VALUES ('GestorLPS', '123');

CREATE TABLE IF NOT EXISTS `sgo`.`endereco` (
  `codigo` INT NOT NULL AUTO_INCREMENT,
  `cep` VARCHAR(9) NOT NULL,
  `rua` VARCHAR(50) NOT NULL,
  `numero` INT NOT NULL,
  `bairro` VARCHAR(50) NOT NULL,
  `cidade` VARCHAR(50) NOT NULL,
  `uf` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`codigo`)
);

CREATE TABLE IF NOT EXISTS `sgo`.`cliente` (
  `nome` VARCHAR(50) UNIQUE NOT NULL,
  `cpf` VARCHAR(15),
  `email` VARCHAR(50),
  `telefone` VARCHAR(16),
  `endereco_codigo` INT NOT NULL,
  PRIMARY KEY (`nome`),
  FOREIGN KEY (`endereco_codigo`) REFERENCES `endereco` (`codigo`) 
  ON DELETE CASCADE
  ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS `sgo`.`obra` (
  `codigo` INT NOT NULL AUTO_INCREMENT,
  `dataInicio` DATE,
  `dataFim` DATE,
  `status` ENUM('Não Iniciada', 'Em Andamento', 'Finalizada') NOT NULL,
  `endereco_codigo` INT NOT NULL,
  `cliente_nome` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`codigo`),
  FOREIGN KEY (`cliente_nome`) REFERENCES `cliente` (`nome`),
  FOREIGN KEY (`endereco_codigo`) REFERENCES `endereco` (`codigo`)
  ON DELETE CASCADE
  ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS `sgo`.`funcionario` (
  `cpf` VARCHAR(15) UNIQUE NOT NULL,
  `nome` VARCHAR(50) NOT NULL,
  `email` VARCHAR(50),
  `telefone` VARCHAR(16),
  `salario` FLOAT,
  `funcao` ENUM('ARQUITETO', 'ELETRICISTA', 'ENCANADOR', 'ENGENHEIRO', 'PEDREIRO', 'PINTOR', 'SERVENTE') NOT NULL,
  `endereco_codigo` INT NOT NULL,
  `obra_codigo` INT NOT NULL,
  PRIMARY KEY (`cpf`),
  FOREIGN KEY (`obra_codigo`) REFERENCES `obra` (`codigo`),
  FOREIGN KEY (`endereco_codigo`) REFERENCES `endereco` (`codigo`)
  ON DELETE CASCADE
  ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS `sgo`.`etapa` (
  `codigo` INT NOT NULL AUTO_INCREMENT,
  `nome` ENUM('Serviços Iniciais', 'Fundação', 'Estrutura', 'Paredes', 'Cobertura', 'Esquadrias', 'Elétrica', 'Hidráulica', 'Forro', 'Revestimentos', 'Pisos', 'Pinturas') NOT NULL,
  `percentualConclusao` INT,
  `totalGastosPrevisto` DOUBLE NOT NULL,
  `dataInicioPrevisto` DATE NOT NULL,
  `dataFimPrevisto` DATE NOT NULL,
  `dataInicioReal` DATE,
  `dataFimReal` DATE,
  `obra_codigo` INT NOT NULL,
  PRIMARY KEY (`codigo`),
  FOREIGN KEY (`obra_codigo`) REFERENCES `obra` (`codigo`)
);

CREATE TABLE IF NOT EXISTS `sgo`.`gasto` (
  `codigo` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(50) NOT NULL,
  `tipo` ENUM('Mão de Obra', 'Material', 'Ferramenta') NOT NULL,
  `valor` DOUBLE NOT NULL,
  `dataGasto` DATE NOT NULL,
  `obra_codigo` INT NOT NULL,
  `etapa_codigo` INT NOT NULL,
  PRIMARY KEY (`codigo`),
  FOREIGN KEY (`obra_codigo`) REFERENCES `obra` (`codigo`),
  FOREIGN KEY (`etapa_codigo`) REFERENCES `etapa` (`codigo`)
 );

CREATE TABLE IF NOT EXISTS `sgo`.`imagem`(
	`descricao` VARCHAR(50) NOT NULL,
	`imagem` MEDIUMBLOB NOT NULL,
    `dataImagem` DATE NOT NULL,
    `etapa_codigo` INT NOT NULL,
    PRIMARY KEY (`descricao`),
    FOREIGN KEY (`etapa_codigo`) REFERENCES `etapa` (`codigo`)
);