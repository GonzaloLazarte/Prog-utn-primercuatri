//Realice un algoritmo donde, dado un grupo de números naturales
//positivos, calcule e imprima el cubo de estos números.
Algoritmo sin_titulo
	Definir n,i  Como Entero
	Definir cubo, num Como Real
	
	Escribir Sin Saltar "ingrese la cantidad de numeros a los que se le calculara el cubo:"
	Leer n
	
	para i=1 Hasta n Hacer
		
		Escribir "ingrese el valor del ",i, "° numero"
		Leer num
		
		si num <= 0 Entonces
			Escribir "ingrese un numero natural"
			Escribir "los negativos no pertenecen a N"
		SiNo
			cubo = num * num * num
		FinSi
		Escribir"el cubo de ",num," es: ",cubo
		
	FinPara
	
FinAlgoritmo
