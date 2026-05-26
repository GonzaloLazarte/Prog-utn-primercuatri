//Realice el algoritmo para obtener la matriz transpuesta de cualquier matriz de orden M x N.

Algoritmo sin_titulo
	Definir i, j, fil, col Como Entero
	Escribir "=============INGRESAR DIMENSIONES DE LA MATRIZ============="
	Escribir Sin Saltar "filas"
	Leer fil
	Escribir Sin Saltar "columnas"
	Leer col
	
	Dimensionar matriz[fil,col]
	Dimensionar transpuesta[col,fil]
	
	Para i=1 Hasta fil Hacer
		Para j=1 hasta col Hacer
			Escribir "valor de: [",i,";",j,"]" 
			Leer matriz[i,j]
			transpuesta[j,i] = matriz[i,j]
		FinPara
	FinPara
	Escribir "====================MATRIZ ORIGINAL======================"
	Para i=1 Hasta fil Hacer
		Para j=1 Hasta col Hacer
			Escribir Sin Saltar "   ", matriz[i,j]
		FinPara
		Escribir ""
	FinPara
	Escribir "====================MATRIZ TRANSVERSA======================"
	Para i=1 Hasta col Hacer
		Para j=1 Hasta fil Hacer
			Escribir Sin Saltar "   ",transpuesta[i,j]
		FinPara
		Escribir ""
	FinPara
	
	
	
FinAlgoritmo
