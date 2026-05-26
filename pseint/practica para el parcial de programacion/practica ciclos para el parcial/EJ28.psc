//Un vendedor ha realizado N ventas y desea saber cuántas fueron
//por 10,000 o menos, cuántas fueron por más de 10,000 pero por
//menos de 20,000, y cuánto fue el monto de las ventas de cada una y
//el monto global. Realice un algoritmo para determinar los totales.
//Además evitar que al ingresar la cantidad ventas esta sea negativa

Algoritmo sin_titulo
	Definir n,masdiez,diezveinte,i Como Entero
	Definir monto, suma, total Como Real
	
	Escribir "ingrese el numero de ventas realizadas"
	Leer n
	
	Mientras i < n Hacer
		Escribir "ingrese el valor de la ",i, "° venta"
		Leer monto
		si monto>0 Entonces
			si monto <= 10000 Entonces
				masdiez = masdiez + 1
			SiNo
				si monto < 20000 Entonces
					diezveinte = diezveinte + 1
				FinSi
			FinSi
			suma = suma + monto
			i=i+1
		SiNo
			Escribir "ingrese un valor mayor a cero"
		FinSi
		
		
	FinMientras

	Escribir "========================================="
	Escribir "el monto total es: ",suma
	Escribir "se realizaron ",masdiez,"ventas maenores a $10.000"
	Escribir "se realizaron ",diezveinte,"ventas mayores a $10.000 y menores a $20.000"
	
FinAlgoritmo
