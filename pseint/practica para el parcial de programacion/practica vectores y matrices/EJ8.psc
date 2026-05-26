//Realice un algoritmo para obtener una matriz como el resultado de la
//suma de dos matrices de orden M x N.

Algoritmo sin_titulo
	Definir i, j, nfilas, ncolumnas Como Entero
	
	Escribir "para sumar dos matries ambas deben tener el mismo numero de filas y de columnas"
	Escribir Sin Saltar "porfavor ingrese el numero de filas:"
	Leer nfilas
	Escribir Sin Saltar "porfavor ingrese el numero de columnas:"
	Leer ncolumnas 
	
	Dimensionar ma[nfilas,ncolumnas]
	Dimensionar mb[nfilas,ncolumnas]
	Dimensionar mc[nfilas,ncolumnas]
	Escribir "==================CARGA DE LA MATRIZ A==================="
	Para i=1 Hasta nfilas Hacer
		Para j=1 Hasta ncolumnas Hacer
			Escribir "valor de: [",i,";",j,"]"
			Leer ma[i,j]
		FinPara
	FinPara
	Escribir "==================CARGA DE LA MATRIZ B==================="
	Para i=1 Hasta nfilas Hacer
		Para j=1 Hasta ncolumnas Hacer
			Escribir "valor de: [",i,";",j,"]"
			Leer mb[i,j]
		FinPara
	FinPara
	Escribir "===================MATRIZ RESULTANTE====================="
	Para i=1 Hasta nfilas Hacer
		Para j=1 Hasta ncolumnas Hacer
			mc[i,j] = ma[i,j] + mb[i,j]
			Escribir Sin Saltar "    " mc[i,j]
		FinPara
		Escribir ""
	FinPara
	
FinAlgoritmo
