--create table java
--(
--	professor varchar(50)
--)

--create table net
--(
--	professor varchar(50)
--)

--insert into java values ('Fabricio'), ('Gabriel'), ('Luan')
--insert into net values ('Fabricio'), ('Ricardo'), ('Alexandre')

---- inner join
--select * from java
--inner join net on java.professor = net.professor

---- left join
--select * from java
--left join net on java.professor = net.professor

---- left join exclusivo
--select * from java
--left join net on java.professor = net.professor
--where net.professor is null

---- right join
--select * from java
--right join net on java.professor = net.professor

---- right join exclusivo
--select * from java
--right join net on java.professor = net.professor
--where java.professor is null

----outer join
--select * from java
--full outer join net on java.professor = net.professor

----outer join exclusivo
--select * from java
--full outer join net on java.professor = net.professor
--where java.professor is null or net.professor is null

-- Tabela para armazenar informações sobre as eras
CREATE TABLE Era2 (
    era_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    ano_inicio INT NOT NULL,
    ano_fim INT NOT NULL
);

-- Tabela para armazenar informações sobre os grupos de dinossauros
CREATE TABLE Grupo2 (
    grupo_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

-- Tabela para armazenar informações sobre os dinossauros
CREATE TABLE Dinossauro2 (
    dinossauro_id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    grupo_id INT,
    toneladas DECIMAL(10, 2),
    ano_descoberta INT,
    descobridor VARCHAR(255),
    era_id INT,
    pais_descobrimento VARCHAR(255),
    FOREIGN KEY (grupo_id) REFERENCES Grupo2(grupo_id),
    FOREIGN KEY (era_id) REFERENCES Era2(era_id),
);

-- Inserir dados nas eras
INSERT INTO Era2 (era_id, nome, ano_inicio, ano_fim) VALUES
(1, 'Triássico', 251, 199),
(2, 'Jurássico', 199, 145),
(3, 'Cretáceo', 145, 66);


-- Inserir dados nos grupos de dinossauros
INSERT INTO Grupo2 (grupo_id, nome) VALUES
(1, 'Terópodes'),
(2, 'Anquilossauros'),
(3, 'Ceratopsídeos'),
(4, 'Estegossauros');

-- Inserir dados nos dinossauros
INSERT INTO Dinossauro2 (dinossauro_id, nome, grupo_id, toneladas, ano_descoberta, descobridor, era_id, pais_descobrimento) VALUES
(1, 'Saichania', 2, 4, 1977, 'Maryanska', 3, 'Mongolia'),
(2, 'Triceratops', 3, 6, 1887, 'John Bell Hatcher', 3, 'Canada'),
(3, 'Kentrossauro', 4, 2, 1909, 'Cientistas Alemães', 2, 'Tanzania'),
(4, 'Pinacossauro', 2, 6, 1999, 'Museu de Historia Natural', 3, 'China'),
(5, 'Alossauro', 1, 3, 1877, 'Othniel Charles Marsh', 2, 'EUA'),
(6, 'Torossauro', 3, 8, 1891, 'John Bell Hatcher', 3, 'EUA'),
(7, 'Anquilossauro', 2, 8, 1901, 'James Brown', 3, 'EUA');

--7) CRIE UM CONSULTA PARA RELACIONAR TODOS OS DADOS DISPONIVEIS DE TODOS OS DINOSSAUROS EXISTENTES NO CATÁLOGO EM ORDEM ALFABETICA

SELECT *
FROM Dinossauro2
ORDER BY nome;

--8) CRIE UM CONSULTA PARA RELACIONAR TODOS OS DADOS DISPONIVEIS DE TODOS OS DINOSSAUROS EXISTENTES EM ORDEM ALFABETICA DO DESCOBRIDOR
SELECT *
FROM Dinossauro2
ORDER BY descobridor, nome;

--9) CRIE UM CONSULTA PARA RELACIONAR TODOS OS DADOS DISPONIVEIS DE TODOS OS DINOSSAUROS DO GRUPO ANQUILOSSAUROS ORDEM ALFABETICA DE DESCOBERTA
SELECT *
FROM Dinossauro2
WHERE grupo_id = 2  -- Filtrando pelo grupo Anquilossauros
ORDER BY ano_descoberta, nome;

--10) CRIE UM CONSULTA PARA RELACIONAR TODOS OS DADOS DISPONIVEIS DE TODOS OS DINOSSAUROS DO GRUPO CERATOPSIDEOS OU ANQUILOSSAUROS COM ANO DE DESCOBERTA ENTRE 1900 E 1999.
SELECT *
FROM Dinossauro2
WHERE (grupo_id = 3 OR grupo_id = 2)  -- Filtrando pelos grupos Ceratopsídeos (grupo_id = 3) ou Anquilossauros (grupo_id = 2)
AND ano_descoberta BETWEEN 1900 AND 1999; -- Filtrando o intervalo de anos de descoberta


-- Retornar o nome dos dinossauros que pertencem ao nome do grupo informado
SELECT Dinossauro2.nome
FROM Dinossauro2
JOIN Grupo2 ON Dinossauro2.grupo_id = Grupo2.grupo_id
WHERE Grupo2.nome = 'Anquilossauros';


CREATE PROCEDURE GetDinossaurosPorGrupo(IN nome_grupo VARCHAR(255))
BEGIN
    SELECT Dinossauro2.nome AS Nome_Dinossauro
    FROM Dinossauro2
    JOIN Grupo2 ON Dinossauro2.grupo_id = Grupo2.grupo_id
    WHERE Grupo2.nome = CALL GetDinossaurosPorGrupo('Anquilossauros');;
END;

