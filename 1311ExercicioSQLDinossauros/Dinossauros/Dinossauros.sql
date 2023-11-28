-- Tabela para armazenar informações sobre as eras
CREATE TABLE Era5 (
    era_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    ano_inicio INT NOT NULL,
    ano_fim INT NOT NULL
);

-- Tabela para armazenar informações sobre os grupos de dinossauros
CREATE TABLE Grupo5 (
    grupo_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

-- Tabela para armazenar informações sobre os dinossauros
CREATE TABLE Dinossauro5 (
    dinossauro_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    grupo_id INT,
    toneladas DECIMAL(10, 2),
    ano_descoberta INT,
    descobridor VARCHAR(255),
    era_id INT,
    pais_descobrimento VARCHAR(255),
    FOREIGN KEY (grupo_id) REFERENCES Grupo5(grupo_id),
    FOREIGN KEY (era_id) REFERENCES Era5(era_id)
);

-- Inserir dados nas eras
INSERT INTO Era5 (era_id, nome, ano_inicio, ano_fim) VALUES
(1, 'Triássico', 251, 199),
(2, 'Jurássico', 199, 145),
(3, 'Cretáceo', 145, 66);


-- Inserir dados nos grupos de dinossauros
INSERT INTO Grupo5 (grupo_id, nome) VALUES
(1, 'Terópodes'),
(2, 'Anquilossauros'),
(3, 'Ceratopsídeos'),
(4, 'Estegossauros');

-- Inserir dados nos dinossauros
INSERT INTO Dinossauro5 (dinossauro_id, nome, grupo_id, toneladas, ano_descoberta, descobridor, era_id, pais_descobrimento) VALUES
(1, 'Saichania', 2, 4, 1977, 'Maryanska', 3, 'Mongolia'),
(2, 'Triceratops', 3, 6, 1887, 'John Bell Hatcher', 3, 'Canada'),
(3, 'Kentrossauro', 4, 2, 1909, 'Cientistas Alemães', 2, 'Tanzania'),
(4, 'Pinacossauro', 2, 6, 1999, 'Museu de Historia Natural', 3, 'China'),
(5, 'Alossauro', 1, 3, 1877, 'Othniel Charles Marsh', 2, 'EUA'),
(6, 'Torossauro', 3, 8, 1891, 'John Bell Hatcher', 3, 'EUA'),
(7, 'Anquilossauro', 2, 8, 1901, 'James Brown', 3, 'EUA');


-- Consultar os dados na tabela Era
SELECT * FROM Era5;

-- Consultar os dados na tabela Grupo
SELECT * FROM Grupo5;

-- Consultar os dados na tabela Dinossauro
SELECT * FROM Dinossauro5;


--5. Faça uma trigger que valide os anos iniciais e finais da existência do dinossauro inserido ou atualizado. Caso os anos não estejam corretos, cancele a operação e mostre uma mensagem ao usuário.
CREATE TRIGGER valida_anos_existencia 
ON Dinossauro5
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        INNER JOIN Era5 e ON i.era_id = e.era_id
        WHERE i.ano_descoberta < e.ano_inicio OR i.ano_descoberta > e.ano_fim
    )
    BEGIN
        ROLLBACK TRANSACTION; -- Desfaz a transação em caso de erro
        PRINT 'Erro: Anos de existência inválidos para a era do dinossauro';
    END
END;

ALTER TRIGGER valida_anos_existencia 
ON Dinossauro5
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        INNER JOIN Era5 e ON i.era_id = e.era_id
        WHERE i.ano_descoberta < e.ano_inicio OR i.ano_descoberta > e.ano_fim
    )
    BEGIN
        DECLARE @mensagem NVARCHAR(100) = 'Erro: Anos de existência inválidos para a era do dinossauro';
        RAISERROR(@mensagem, 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- Consultar os dados na tabela Era
SELECT * FROM Era5;

-- Consultar os dados na tabela Grupo
SELECT * FROM Grupo5;

-- Consultar os dados na tabela Dinossauro
SELECT * FROM Dinossauro5;
















