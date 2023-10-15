DROP TABLE IF EXISTS Calificaciones;
DROP TABLE IF EXISTS Evaluaciones;
DROP TABLE IF EXISTS Matricula;
DROP TABLE IF EXISTS Estudiantes;
DROP TABLE IF EXISTS Cursos;

CREATE TABLE "Estudiantes" (
	"IdEstudiante"	INTEGER NOT NULL,
	"CedulaEstudiante"	TEXT,
	"NombreEstudiante"	TEXT NOT NULL,
	"ApellidosEstudiante"	TEXT NOT NULL,
	"FechaNacimientoEstudiante"	TEXT,
	"CorreoEstudiante"	TEXT,
	"DireccionEstudiante"	TEXT,
	PRIMARY KEY("IdEstudiante")
);

CREATE TABLE "Cursos" (
	"IdCurso"	INTEGER NOT NULL UNIQUE,
	"NombreCurso"	TEXT NOT NULL,
	"Duracion"	INTEGER,
	"CantidadEstudiantes"	INTEGER,
	PRIMARY KEY("IdCurso" AUTOINCREMENT)
);

CREATE TABLE "Matricula" (
	"IdCurso"	INTEGER NOT NULL,
	"IdEstudiante"	INTEGER NOT NULL,
	FOREIGN KEY("IdCurso") REFERENCES "Cursos"("IdCurso"),
	FOREIGN KEY("IdEstudiante") REFERENCES "Estudiantes"("IdEstudiante")
);

CREATE TABLE "Evaluaciones" (
	"IdEvaluacion" INTEGER NOT NULL UNIQUE,
	"NombreEvaluacion" TEXT NOT NULL,
	"PorcentajeEvaluacion" REAL NOT NULL,
	"DescripcionEvaluacion" TEXT,
	"CalculoAutomatico" INTEGER NOT NULL,
	"IdCurso" INTEGER NOT NULL,
	FOREIGN KEY("IdCurso") REFERENCES "Cursos"("IdCurso"),
	PRIMARY KEY("IdEvaluacion" AUTOINCREMENT)
);

CREATE TABLE "Calificaciones"(
	"IdCalificacion" INTEGER NOT NULL UNIQUE,
	"Nota"	REAL NOT NULL,
	"IdEvaluacion"	INTEGER NOT NULL,
	"IdEstudiante"	INTEGER NOT NULL,
	FOREIGN KEY("IdEvaluacion") REFERENCES "Evaluaciones"("IdEvaluacion"),
	FOREIGN KEY("IdEstudiante") REFERENCES "Estudiantes"("IdEstudiante"),
	PRIMARY KEY("IdCalificacion" AUTOINCREMENT)
);

INSERT INTO Estudiantes (IdEstudiante, NombreEstudiante, ApellidosEstudiante) 
VALUES 
	(1, 'Ellian', 'Campos Ceciliano'),
	(2, 'Josue', 'Morales Vargas'),
	(3, 'Kevin', 'Navarro Romero');

INSERT INTO Cursos (IdCurso, NombreCurso) 
VALUES
	(1, 'C#'),
	(2, 'SQL'),
	(3, 'Visual Basic'),
	(4, 'Inglés'),
	(5, 'Word'),
	(6, 'Excel');

-- MATRICULAR LOS 3 ESTUDIANTES EN EL CURSO DE SQL
INSERT INTO Matricula (IdCurso, IdEstudiante) VALUES(1,1);
INSERT INTO Matricula (IdCurso, IdEstudiante) VALUES(1,2);
INSERT INTO Matricula (IdCurso, IdEstudiante) VALUES(1,3);

-- CREAR LAS EVALUACIONES DEL CURSO
INSERT INTO Evaluaciones (IdEvaluacion, NombreEvaluacion, PorcentajeEvaluacion, CalculoAutomatico, IdCurso) 
VALUES
	(1, 'Examen 1', 15, 0, 1),
	(2, 'Examen 2', 15, 0, 1),
	(3, 'Proyecto', 25, 0, 1),
	(4, 'Asistencia', 15, 1, 1),
	(5, 'Tareas', 30, 1, 1);
	
-- Revision Examen 1
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (100, 1, 1);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (85, 1, 2);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (70, 1, 3);

-- Revision Examen 2
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (100, 1, 1);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (90, 1, 2);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (70, 1, 3);

-- Revision Proyecto final
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (100, 3, 1);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (95, 3, 2);
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) VALUES (65, 3, 3);

-- Tareas
INSERT INTO Calificaciones (Nota, IdEvaluacion, IdEstudiante) 
VALUES
	(100, 5, 1),
	(95, 5, 2),
	(90, 5, 3),
	(100, 5, 1),
	(95, 5, 2),
	(90, 5, 3);


SELECT * FROM Cursos;
SELECT * FROM Estudiantes;
SELECT * FROM Evaluaciones;
SELECT * FROM Matricula;
SELECT * FROM Calificaciones;





-- Obtener la sumaria de las Evaluaciones de un curso
SELECT SUM(PorcentajeEvaluacion) FROM Evaluaciones WHERE IdCurso = 1;



 

 
 
SELECT c.Nota*(e.PorcentajeEvaluacion/100)
FROM Calificaciones c, Evaluaciones e 
WHERE 
	--IdEstudiante = 1 AND
	c.IdEvaluacion = e.IdEvaluacion;
 
 
SELECT sum(c.Nota*(e.PorcentajeEvaluacion/100))
FROM Calificaciones c, Evaluaciones e 
WHERE 
	IdEstudiante = 3 AND
	c.IdEvaluacion = e.IdEvaluacion;
 
SELECT 
	(SELECT sum(c.Nota*(e.PorcentajeEvaluacion/100)) 
	FROM Calificaciones c, Evaluaciones e 
	WHERE c.IdEvaluacion = e.IdEvaluacion) 
FROM Calificaciones;
 
 
SELECT sum(IF(e.CalculoAutomatico = 1, 
			c.Nota*(e.PorcentajeEvaluacion/100),
			c.Nota*300/sum(3))))
FROM Calificaciones c, Evaluaciones e 
WHERE 
	IdEstudiante = 3 AND
	c.IdEvaluacion = e.IdEvaluacion;
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 -- CREATE TABLE "Rubros" (
-- 	"IdRubro" INTEGER NOT NULL UNIQUE,
-- 	"NombreRubro" TEXT NOT NULL,
-- 	"PorcentajeRubro" TEXT NOT NULL,
-- 	"CalculoAutomatico" INTEGER NOT NULL,
-- 	"IdCurso" INT NOT NULL,
-- 	FOREIGN KEY("IdCurso") REFERENCES "Cursos"("IdCurso"), 
-- 	PRIMARY KEY("IdRubro" AUTOINCREMENT)
-- );

-- CREATE TABLE "Notas" (
-- 	"IdNota"	INTEGER NOT NULL UNIQUE,
-- 	"Nota"	REAL NOT NULL,
-- 	"IdEvaluacion"	INTEGER NOT NULL,
-- 	"IdEstudiante"	INTEGER NOT NULL,
-- 	FOREIGN KEY("IdEvaluacion") REFERENCES "Evaluaciones"("IdEvaluacion"),
-- 	FOREIGN KEY("IdEstudiante") REFERENCES "Estudiantes"("IdEstudiante"),
-- 	PRIMARY KEY("IdNota" AUTOINCREMENT)
-- );

-- CREATE TABLE "Evaluaciones" (
-- 	"IdEvaluacion" INTEGER NOT NULL UNIQUE,
-- 	"NombreEvaluacion" TEXT NOT NULL,
-- 	"NotaEvaluacion" REAL NOT NULL,
-- 	"DescripcionEvaluacion" TEXT,
-- 	"IdRubro" INTEGER,
-- 	FOREIGN KEY("IdRubro") REFERENCES "Rubros"("IdRubro"),
-- 	PRIMARY KEY("IdEvaluacion" AUTOINCREMENT)
-- );
