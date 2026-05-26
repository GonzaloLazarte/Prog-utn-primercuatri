//Se requiere obtener la suma de las cantidades contenidas en un arreglo de
//10 elementos.

Algoritmo sin_titulo
	Definir suma Como Real
	Definir i Como Entero
	
	Dimensionar  vector[10]
	
	
	para i=1 Hasta 10 Hacer
		Escribir Sin Saltar"ingrese el valor para: ",i, ""
		Leer vector[i]
		
		
		suma = suma + vector[i]
	FinPara
	Escribir "la suma total es:",suma 
	
	
	
FinAlgoritmo
