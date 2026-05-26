//Se requiere un algoritmo para obtener un vector (C) de N elementos que
//contenga la suma de los elementos correspondientes de otros dos vectores
//(A y B).

Algoritmo sin_titulo
	Definir suma Como Real
	Definir dim, i Como Entero
	
	Escribir "ingrese la dimension de los vectores a sumar"
	Leer dim
	
	Dimensionar A[dim]
	Dimensionar B[dim]
	Dimensionar C[dim]
	
	Escribir "cargar valores de A"
	Para i=1 Hasta dim Hacer
		Escribir Sin Saltar "ingrese el ",i,"° valor"
		Leer A[i]
	FinPara
	Escribir "cargar valores de B"
	Para i=1 Hasta dim Hacer
		Escribir Sin Saltar "ingrese el ",i,"° valor"
		Leer B[i]
	FinPara
	Escribir "MOSTRAR VECTOR C"
	Para i=1 Hasta dim Hacer
		C[i] = A[i] + B[i]
		Escribir Sin Saltar ", ", C[i]
	FinPara
	
	
FinAlgoritmo
