//Realice un algoritmo que lea un arreglo de M filas y N columnas y que calcule la
//suma de los elementos de la diagonal principal.
Algoritmo sin_titulo
	Definir i, j, fil, col Como Entero
	Definir suma Como Real
	
	Escribir "ingrese la dimension de la matriz"
	Escribir Sin Saltar "fila"
	Leer fil
	Escribir Sin Saltar "columna:"
	Leer col 
	Dimensionar matriz[fil,col]
	
	
	Para i = 1 Hasta fil Hacer
		Para j = 1 Hasta col Hacer
			Escribir "valor de: [",i,";",j,"]"
			Leer matriz[i,j]
			si i = j Entonces
				suma = suma + matriz[i,j]
			FinSi
		FinPara
	FinPara
	Escribir "visaulizaciond de la matriz"
	Para i = 1 Hasta fil Hacer
		Para j = 1 Hasta col Hacer
			Escribir Sin Saltar "   ", matriz[i,j]
		FinPara
		Escribir ""
	FinPara
	Escribir "la suma de los elementos de la diagonal principal es:",suma
	
FinAlgoritmo
