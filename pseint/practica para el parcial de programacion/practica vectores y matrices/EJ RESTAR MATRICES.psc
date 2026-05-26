Algoritmo sin_titulo
	Definir f, c, i, numfil, numcol Como Entero
	
	Escribir "ingrese la cantidad de filas de los vectores"
	Leer numfil
	Escribir "ingrese la cantidad de columnas de los vectores"
	Leer numcol
	Dimensionar ma[numfil,numcol]
	Dimensionar mb[numfil,numcol]
	Dimensionar mc[numfil,numcol]
	Escribir "ingrese los valores para la matriz A"
	Para f = 1 Hasta numfil Hacer
		Para c = 1 Hasta numcol Hacer
			Escribir Sin Saltar "ingrese el valor de la poscion ",f,", ",c
			Leer ma[f,c]
		FinPara
	FinPara
	Escribir "ingese los valores para la matriz B"
	Para f = 1 Hasta numfil Hacer
		Para c = 1 Hasta numcol Hacer
			Escribir sinsaltar "ingrese el valor de la poscion ",f,", ",c
			Leer mb[f,c]
		FinPara
	FinPara
	
	Para f = 1 Hasta numfil Hacer
		Para c = 1 Hasta numcol Hacer
			mc[f,c] = ma[f,c] - mb[f,c]
		FinPara
	FinPara
	
	Para f = 1 Hasta numfil Hacer
		Para c = 1 Hasta numcol Hacer
			Escribir Sin Saltar  "   ", mc[f,c]
		FinPara
		Escribir ""
	FinPara
	
	
FinAlgoritmo
