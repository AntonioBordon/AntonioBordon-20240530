CREATE TABLE Usuario (
    IdUsuario INT PRIMARY KEY,
    Nome varchar(100),
    Senha varchar(100),
    Ativo boolean 
);

CREATE TABLE Unidade (
    IdUnidade INT PRIMARY KEY,
    CodigoUnidade varchar(100),
    Nome varchar(100),
    Ativo boolean
);

CREATE TABLE Colaborador (
    IdColaborador INT PRIMARY KEY,
    Nome varchar(100),
    IdUsuario INT,
    IdUnidade INT,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdUnidade) REFERENCES Unidade(IdUnidade)
);
