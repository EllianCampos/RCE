DROP TABLE IF EXISTS Calificaciones;
DROP TABLE IF EXISTS EvaluacionesLineas;
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
	"PuntosEvaluacion" INTEGER,
	"PorcentajeEvaluacion" REAL NOT NULL,
	"DescripcionEvaluacion" TEXT,
	"CalculoAutomatico" INTEGER NOT NULL,
	"IdCurso" INTEGER NOT NULL,
	FOREIGN KEY("IdCurso") REFERENCES "Cursos"("IdCurso"),
	PRIMARY KEY("IdEvaluacion" AUTOINCREMENT)
);

CREATE TABLE EvaluacionesLineas (
	IdEvaluacionLinea INTEGER NOT NULL UNIQUE,
	FechaEvaluacionLinea TEXT,
	DescripcionEvaluacionLinea TEXT,
	IdEvaluacion INTEGER NOT NULL,
	FOREIGN KEY (IdEvaluacion) REFERENCES Evaluaciones (IdEvaluacion),
	PRIMARY KEY ("IdEvaluacionLinea" AUTOINCREMENT)
);

CREATE TABLE "Calificaciones"(
	"IdCalificacion" INTEGER NOT NULL UNIQUE,
	"PuntosCalificacion" INTEGER NOT NULL,
	"IdEvaluacion"	INTEGER,
	"IdEvaluacionLinea" INTEGER,
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
INSERT INTO Evaluaciones (IdEvaluacion, NombreEvaluacion, PuntosEvaluacion, PorcentajeEvaluacion, CalculoAutomatico, IdCurso) 
VALUES
	(1, 'Examen 1', 100, 15, 0, 1),
	(2, 'Examen 2', 100, 15, 0, 1),
	(3, 'Proyecto', 100, 25, 0, 1),
	(4, 'Asistencia', 100, 15, 1, 1),
	(5, 'Tareas', 100, 30, 1, 1);
	
-- CREAR LAS EVALUACIONES DE CalculoAutomatico
INSERT INTO EvaluacionesLineas (IdEvaluacionLinea, FechaEvaluacionLinea, DescripcionEvaluacionLinea, IdEvaluacion)
VALUES	
	(1, '01/10/2023', '', 4),
	(2, '02/10/2023', '', 4),
	(3, '03/10/2023', '', 4),
	(4, '04/10/2023', '', 4),
	(5, '05/10/2023', '', 4),
	(6, '06/10/2023', '', 4),
	(7, '07/10/2023', '', 4),
	(8, '08/10/2023', '', 4),
	(9, '09/10/2023', '', 4),
	(10, '10/10/2023', '', 4),
	--
	(11, '', 'Tarea 1', 5),
	(12, '', 'Tarea 2', 5);
	
-- Revision Examen 1
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (100, 1, 1);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (85, 1, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (70, 1, 3);

-- Revision Examen 2
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (100, 2, 1);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (90, 2, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (70, 2, 3);

-- Revision Proyecto final
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (100, 3, 1);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (95, 3, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacion, IdEstudiante) VALUES (65, 3, 3);

-- Asistencia
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 1, 1); -- 1
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 1, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 1, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 2, 1); -- 2
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 2, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 2, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 3, 1); -- 3
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 3, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 3, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 4, 1); -- 4
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 4, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 4, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 5, 1); -- 5
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 5, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 5, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 6, 1); -- 6
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 6, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 6, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 7, 1); -- 7
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 7, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (0, 7, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 8, 1); -- 8
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 8, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 8, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 9, 1); -- 9
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 9, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 9, 3);

-- Tareas
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 11, 1);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (95, 11, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (90, 11, 3);

INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (100, 11, 1);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (95, 11, 2);
INSERT INTO Calificaciones (PuntosCalificacion, IdEvaluacionLinea, IdEstudiante) VALUES (90, 11, 3);


SELECT * FROM Cursos;
SELECT * FROM Estudiantes;
SELECT * FROM Evaluaciones;
SELECT * FROM Matricula;
SELECT * FROM Calificaciones;


-- Evaluaciones con valor fijor 
SELECT * 
FROM Calificaciones c, Evaluaciones e, Estudiantes es 
WHERE 
	c.IdEvaluacion = e.IdEvaluacion AND 
	c.IdEstudiante = es.IdEstudiante AND
	e.IdCurso = 1;

-- Evaluaciones con valor de auto calculo
SELECT * 
FROM Calificaciones c, EvaluacionesLineas el, Estudiantes es 
WHERE c.IdEvaluacionLinea = el.IdEvaluacionLinea AND c.IdEstudiante = es.IdEstudiante; 


 
 
 

