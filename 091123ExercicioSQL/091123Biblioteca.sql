
-- Tabela para armazenar informações sobre os autores
CREATE TABLE Autores (
    autor_id INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    nacionalidade VARCHAR(50) NOT NULL
);

-- Tabela para armazenar informações sobre as categorias
CREATE TABLE Categorias (
    categoria_id INT PRIMARY KEY,
    descricao VARCHAR(100) NOT NULL
);

-- Tabela para armazenar informações sobre os livros
CREATE TABLE Livros (
    ISBN VARCHAR(13) PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
    ano_publicacao INT NOT NULL,
    editora VARCHAR(100) NOT NULL,
    autor_id INT,
    categoria_id INT,
    FOREIGN KEY (autor_id) REFERENCES Autores(autor_id),
    FOREIGN KEY (categoria_id) REFERENCES Categorias(categoria_id)
);

-- Tabela para associar autores aos livros
CREATE TABLE Livro_Autor (
    livroautor_id INT PRIMARY KEY,
    autor_id INT,
    ISBN VARCHAR(13),
    FOREIGN KEY (autor_id) REFERENCES Autores(autor_id),
    FOREIGN KEY (ISBN) REFERENCES Livros(ISBN)
);
