//Cierta empresa requiere controlar la existencia de diez productos, los cuales
//se almacenan en un vector A, mientras que los pedidos de los clientes
//de estos productos se almacenan en un vector B. Se requiere generar un
//tercer vector C con base en los anteriores que represente lo que se requiere
//comprar para mantener el stock de inventario, para esto se considera lo
//siguiente: si los valores correspondientes de los vectores A y B son iguales
//se almacena este mismo valor, si el valor de B es mayor que el de A se almacena
//el doble de la diferencia entre B y A, si se da el caso de que A es mayor
//que B, se almacena B, que indica lo que se requiere comprar para mantener
//el stock de inventario.
Algoritmo sin_titulo
	
	Definir nombre Como Caracter
	Definir falta, necesito Como Entero
	
	Dimensionar A[10]
	Dimensionar B[10]
	Dimensionar C[10]
	
	Escribir "ingrese la existencia de los prodcutos de A:"
	Para  i=1 hasta 10 Hacer
		Escribir Sin Saltar "ingrese la existencia del: ",i, "° valor del vector A"
		leer A[i]
	FinPara
	Para  i=1 hasta 10 Hacer
		Escribir Sin Saltar "ingrese la existencia del: ",i, "° valor del vector B"
		leer B[i]
	FinPara
	Para i=1 Hasta 10 Hacer
		si A[i] = B[i] Entonces
			C[i] = A[i] + B[i]
		SiNo
			si B[i] > A[i] Entonces
				C[i] = (B[i] - A[i]) * 2
			SiNo
				si A[i] > B[i]
					C[i] = B[i]
				FinSi
			FinSi
		FinSi
	FinPara
	para i=1 Hasta 10 Hacer
		Escribir Sin Saltar ", ", A[i]
	FinPara
	Escribir ""
	para i=1 Hasta 10 Hacer
		Escribir Sin Saltar ", ", B[i]
	FinPara
	Escribir ""
	para i=1 Hasta 10 Hacer
		Escribir Sin Saltar ", ", C[i]
	FinPara
	
	
	
	
FinAlgoritmo
