DROP TABLE IF EXISTS personaje;
DROP TABLE IF EXISTS habilidades ;
DROP TABLE IF EXISTS equipo;
DROP TABLE IF EXISTS equipado;


CREATE TABLE personaje (
id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre CHAR(30) NOT NULL,
jugador CHAR(30) NOT NULL,
edad INT NOT NULL,
puntosvida INT NOT NULL,
puntosmaguia INT NOT NULL,
cordura INT NOT NULL,
suerte INT NOT NULL,
estFuerza INT NOT NULL,
estDestreza INT NOT NULL,
estPoder INT NOT NULL,
estConstitucion INT NOT NULL,
estApariencia INT NOT NULL,
estEducaccion INT NOT NULL,
estTamaño INT NOT NULL,
estInteligencia  INT NOT NULL,
estMovimiento  INT NOT NULL);

CREATE TABLE habilidades  (
idjugador INT NOT NULL PRIMARY KEY,
Antropologuia INT NOT NULL DEFAULT 1,
armacorta INT NOT NULL DEFAULT 20,
fusilYescopeta INT NOT NULL DEFAULT 25,
arqueologuia INT NOT NULL DEFAULT 1,
arteYartesania INT NOT NULL DEFAULT 5,
buscarlibros INT NOT NULL DEFAULT 20,
cerrajeria INT NOT NULL DEFAULT 1,
charlataneria INT NOT NULL DEFAULT 5,
ciencia INT NOT NULL DEFAULT 1,
cienciasocultas INT NOT NULL DEFAULT 5,
pelea INT NOT NULL DEFAULT 25,
conducirautomovil INT NOT NULL DEFAULT 20,
conducirmaquinaria INT NOT NULL DEFAULT 1,
contavilidad INT NOT NULL DEFAULT 05,
credito INT NOT NULL DEFAULT 00,
derecho INT NOT NULL DEFAULT 5,
descubrir INT NOT NULL DEFAULT 25,
disfrazarse INT NOT NULL DEFAULT 5,
electricidad INT NOT NULL DEFAULT 10,
encanto INT NOT NULL DEFAULT 15,
equitacion INT NOT NULL DEFAULT 5,
escuchar INT NOT NULL DEFAULT 20,
esquivar INT NOT NULL,
historia INT NOT NULL DEFAULT 5,
intimidar INT NOT NULL DEFAULT 15,
juegomanos INT NOT NULL DEFAULT 10,
lanzar INT NOT NULL DEFAULT 20,
mecanica INT NOT NULL DEFAULT 10,
medicina INT NOT NULL DEFAULT 1,
mitoscthulhu INT NOT NULL DEFAULT 0,
nadar INT NOT NULL DEFAULT 20,
naturaleza INT NOT NULL DEFAULT 10,
orientarse INT NOT NULL DEFAULT 10,
persuasion INT NOT NULL DEFAULT 10,
pilotar INT NOT NULL DEFAULT 10,
primerosauxilios INT NOT NULL DEFAULT 30,
psicoanalisis INT NOT NULL DEFAULT 1,
psicologuia INT NOT NULL DEFAULT 10,
saltar INT NOT NULL DEFAULT 20,
seguirrasto INT NOT NULL DEFAULT 10,
sigilo INT NOT NULL DEFAULT 20,
supervivencia INT NOT NULL DEFAULT 10,
tasacion INT NOT NULL DEFAULT 5,
trepar INT NOT NULL DEFAULT 20
FOREIGN KEY (idjugador) REFERENCES personaje(id)
);

CREATE TABLE equipo (
id_arma INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre CHAR NOT NULL,
daño CHAR NOT NULL,
alcance CHAR NOT NULL,
num_ataques CHAR NOT NULL,
municion INT NOT NULL,
averia INT NOT NULL);

CREATE TABLE equipado (
id_personaje INT NOT NULL,
id_arma INT NOT NULL,
dificultad_normal INT NOT NULL,
dificultad_dificil INT NOT NULL,
dificultad_extrema INT NOT NULL,
PRIMARY KEY (id_personaje,id_arma));

ALTER TABLE equipado ADD CONSTRAINT equipado_id_personaje_personaje_id FOREIGN KEY (id_personaje) REFERENCES personaje(id);
ALTER TABLE equipado ADD CONSTRAINT equipado_Id_equipo_equipo_id_arma FOREIGN KEY (id_arma) REFERENCES equipo(id_arma);
