// Se requiere un algoritmo para determinar, de N cantidades, cuántas
// son cero, cuántas son menores a cero, y cuántas son mayores a cero.
Algoritmo ej21
	Definir N, i, grande, chico, mismo Como Entero
	Definir val Como Real
	Escribir 'INGRESE UNA CANTIDAD DE ELEMENTOS'
	Leer N
	Escribir 'ingrese los valores de los elementos'
	Para i<-0 Hasta N-1 Hacer
		Leer val
		Si val<0 Entonces
			chico <- chico+1
		SiNo
			Si val=0 Entonces
				mismo <- mismo+1
			SiNo
				grande <- grande+1
			FinSi
		FinSi
	FinPara
	Escribir 'hay: ', grande, ' numeros mayores que cero'
	Escribir 'hay: ', mismo, ' numeros iguales que cero'
	Escribir 'hay: ', chico, ' numeros menores que cero'
	
	
	
FinAlgoritmo
