//Se desea saber el total de una caja registradora de un almacén, se
//conoce el número de billetes y monedas, así como su valor. Realice
//un algoritmo para determinar el total.

Algoritmo sin_titulo

	Definir suma Como Real
	Definir bill, cantbill, mon, cantmon, i Como Entero
	
	Escribir "ingrese la cantidad de billetes"
	Leer cantbill
	Escribir "ingrese la cantidad de monedas"
	Leer cantmon
	
	Para i=1 hasta cantbill Hacer
		Escribir Sin Saltar "valor del ",i,"° billete"
		Leer bill
		
		suma = suma + bill
		
	FinPara
	Para  i=1 Hasta  cantmon Hacer
		Escribir Sin Saltar "valor del ",i,"° moneda"
		Leer mon
		
		suma = suma + mon
	FinPara
	
	Escribir "el numero dedinero es de: ",suma
	
	
	
	
	
FinAlgoritmo
