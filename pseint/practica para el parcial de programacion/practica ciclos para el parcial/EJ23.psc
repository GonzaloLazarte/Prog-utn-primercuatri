//Se requiere un algoritmo para determinar cuánto ahorrará en pesos
//una persona diariamente, y en un semana, si ahorra 2 pesos el lunes, 4 pesos el martes, 8 pesos el miércoles 
//y así sucesivamente todo la semana

Algoritmo sin_titulo
	Definir semana, i Como Entero
	Definir suma, diario,lunes Como Real
	
	diario = 2
	suma = 0
	Para i=1 hasta 7 Hacer
		suma = suma + diario
		Escribir "el ahorro para el dia :",i," es: ",diario
		diario = diario * 2
	FinPara
	
	Escribir "el total ahorrado es de :", suma
	
	
	
FinAlgoritmo
