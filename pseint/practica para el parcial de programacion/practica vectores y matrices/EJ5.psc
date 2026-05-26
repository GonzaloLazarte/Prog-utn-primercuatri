//Realice un algoritmo que lea un vector de seis elementos e intercambie las
//posiciones de sus elementos, de tal forma que el primer elemento pase a
//ser el último y el último el primero, el segundo el penúltimo y así sucesivamente,
//e imprima ese vector.

Algoritmo sin_titulo
	Definir num Como Real
	Definir i Como Entero
	
	Dimensionar VectorA[7]
	Dimensionar VectorB[7]
	para i=1 hasta 6 Hacer
		Escribir "ingrese el ",i, "° elemento"
		Leer VectorA[i]
	FinPara
	i = 6
	j = 1
	Para i = 1 Hasta 6 Hacer
		Para j = 1 Hasta 6 - i Hacer
			VectorB[j] = VectorA[i+1]
		FinPara
	FinPara
	
	Para i=1 Hasta 6 Hacer
		Escribir Sin Saltar ", " VectorA[i]
	FinPara
	Escribir ""
	Para i=1 Hasta 6 Hacer
		Escribir Sin Saltar ", " VectorB[i]
	FinPara
	
FinAlgoritmo
