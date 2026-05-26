//Se tienen los nombres de los N alumnos de una escuela, además de su
//promedio general. Realice un algoritmo para capturar esta información, la
//cual se debe almacenar en arreglos, un vector para el nombre y otro para
//el promedio, después de capturar la información se debe ordenar con base
//en su promedio, de mayor a menor, los nombres deben corresponder con
//los promedios.

Algoritmo sin_titulo
	Definir nombre Como Caracter
	Definir promedio, aux Como Real
	Definir i, j, dim Como Entero
	
	Escribir "ingrese la cantidad de alumnos"
	Leer dim
	
	Dimensionar nom[dim]
	Dimensionar prom[dim]
	Dimensionar nomOrd[dim]
	Dimensionar promOrd[dim]
	
	Para i = 1 Hasta dim Hacer
		Escribir "ingrese datos del ", i, "° alumno"
		Escribir Sin Saltar "nombre"
		Leer nombre 
		nom[i] = nombre
		Escribir Sin Saltar"promedio"
		Leer promedio
		prom[i] = promedio
		promOrd[i] = prom[i]
	FinPara
	
	Para i = 1 Hasta dim - 1 Hacer
		Para j = 1 Hasta dim - i Hacer
			si promOrd[j] < promOrd[j+1] Entonces
				aux = promOrd[j]
				promOrd[j] = promOrd[j+1]
				promOrd[j+1] = aux
			FinSi
		FinPara
	FinPara
	
	Para i=1 Hasta dim Hacer
		Para j=1 Hasta dim Hacer
			si promOrd[i] = prom[j] Entonces
				nomOrd[i] = nom[j]
			FinSi
		FinPara
	FinPara
	
	Escribir "============nombres============="
	Para i=1 Hasta dim Hacer
		Escribir "Nombre: ",nom[i],"    Promedio ",prom[i]
	FinPara
	
	Escribir ""
	Escribir "=========nombre y promedio ordenado==========="
	Para i=1 Hasta dim Hacer
		Escribir "Nombre: ",nomOrd[i],"    Promedio: ",promOrd[i]
	FinPara
	
	
	
	
	
	
FinAlgoritmo
