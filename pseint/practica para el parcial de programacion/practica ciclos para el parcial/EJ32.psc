//Realice un algoritmo para obtener la tabla de multiplicar de un entero
//K comenzando desde el 1

Algoritmo sin_titulo
	Definir K, i, n, max,  multi Como Entero
	
	Escribir "ingrese hasta que numero debe llegar la tabla:"
	Leer max
	Escribir "ingrese el numero entero sobre el cual se hara la tabla: "
	Leer n
	Escribir "=================TABLA DEL ", n, "================="
	Para i=1 Hasta max Hacer
		multi = n * i
		Escribir i," X ",n, " = ",multi
	FinPara
	
FinAlgoritmo
