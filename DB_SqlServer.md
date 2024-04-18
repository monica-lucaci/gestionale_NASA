```SqlServer
DROP TABLE IF EXISTS OggettoCeleste;
DROP TABLE IF EXISTS Sistema;
DROP TABLE IF EXISTS OggettoSistema;

CREATE TABLE OggettoCeleste(
	oggettoCelesteID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	codice VARCHAR(250) NOT NULL UNIQUE,
	dataScoperta DATETIME,
	scopritore VARCHAR(250),
	tipologia VARCHAR(250) NOT NULL,
	distanzaTerra DECIMAL(10,2) NOT NULL,
	distanzaCoordinate DECIMAL(10,2) NOT NULL,
	angoloCoordinate DECIMAL(10,2) NOT NULL,
);

CREATE TABLE Sistema(
	sistemaID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	codice VARCHAR(250) NOT NULL UNIQUE,
	tipo VARCHAR(250) NOT NULL
);


CREATE TABLE OggettoSistema(
	oggettoRif INT NOT NULL,
	sistemaRif INT NOT NULL,
	FOREIGN KEY (oggettoRif) References OggettoCeleste(oggettoCelesteID) ON DELETE CASCADE,
	FOREIGN KEY (sistemaRif) References Sistema(sistemaID) ON DELETE CASCADE,
	PRIMARY KEY (oggettoRif, sistemaRif)
);

INSERT INTO OggettoCeleste (nome, codice, dataScoperta, scopritore, tipologia, distanzaTerra, distanzaCoordinate, angoloCoordinate)
VALUES
('Luna', 'LUNA001', '1969-07-10 00:00:00', 'Neil Armstrong', 'Satellite', 384400, 0, 0),
('Marte', 'MAR001', '1969-07-10 00:00:00', 'Christiaan Huygens', 'Pianeta', 225000, 0, 0),
('Orione', 'ORN001', '1800-07-10 00:00:00', 'Johannes Kepler', 'Nebulosa', 1344, 100, 60),
('Andromeda', 'AND001', '1964-10-10 00:00:00', 'Simon Marius', 'Galassia', 2540000, 200, 45),
('Saturno', 'SAT001', '1810-07-05 00:00:00', 'Galileo Galilei', 'Pianeta', 1270000, 0, 0),
('Plutone', 'PLU001', '1930-02-08 00:00:00', 'Clyde Tombaugh', 'Pianeta Nano', 450000, 0, 0),
('Sirio', 'SIR001', '1844-01-01 00:00:00', 'Friedrich Bessel', 'Stella', 8.6, 300, 90),
('Cratere Tycho', 'TYC001', '1801-01-01 00:00:00', 'Tycho Brahe', 'Cratere', 0, 0, 11.1),
('Nebulosa di Orione', 'ORN002', '1810-11-06 00:00:00', 'Nicolas-Claude Fabri de Peiresc', 'Nebulosa', 1270, 150, 30),
('Mercurio', 'MER001', '1803-05-04 00:00:00', 'Giovanni Domenico Cassini', 'Pianeta', 77000000, 0, 0);


INSERT INTO Sistema (nome, codice, tipo)
VALUES
('Sistema Solare', 'SOL001', 'Sistema Planetario'),
('Sistema di Alpha Centauri', 'ALP001', 'Sistema Stellare'),
('Via Lattea', 'MIL001', 'Galassia'),
('Andromeda', 'AND002', 'Galassia'),
('Sistema di Trappist-1', 'TRA001', 'Sistema Planetario'),
('Sistema di Kepler-186', 'KEP001', 'Sistema Planetario'),
('Sistema di Sirius', 'SIR002', 'Sistema Stellare'),
('Sistema di Aldebaran', 'ALD001', 'Sistema Stellare'),
('Nube di Magellano', 'MAG001', 'Galassia'),
('Galassia di Andromeda', 'AND003', 'Galassia');



INSERT INTO OggettoSistema (oggettoRif, sistemaRif)
VALUES
(1, 1),  -- Luna, Sistema Solare
(2, 1),  -- Marte, Sistema Solare
(3, 3),  -- Orione, Via Lattea
(4, 4),  -- Andromeda, Andromeda
(5, 1),  -- Saturno, Sistema Solare
(6, 1),  -- Plutone, Sistema Solare
(7, 2),  -- Sirio, Sistema di Alpha Centauri
(8, 3),  -- Cratere Tycho, Via Lattea
(9, 3),  -- Nebulosa di Orione, Via Lattea
(10, 1); -- Mercurio, Sistema Solare


```