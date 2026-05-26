//Realice un algoritmo para leer las calificaciones de N alumnos y determine
//el número de aprobados y reprobados.
Algoritmo sin_titulo
	
	Definir alumnos, ap, rep, i Como Entero
	Definir nota Como Real
	
	Escribir "ingrese el numero de alumnos:"
	Leer alumnos
	
	Escribir "un alumno esta aprobado con 6 o mas"
	
	para i=1 Hasta alumnos Hacer
		Escribir Sin Saltar "ingrese la calificacion para el ",i,"° alumno"
		leer nota
		
		si nota > 6 Entonces
			ap = ap + 1
		SiNo
			rep = rep +1
		FinSi
	FinPara
	
	Escribir "hay: ",ap," alumnos aprobados"
	Escribir "hay: ",rep," alumnos desaprobados"
	
	
FinAlgoritmo
