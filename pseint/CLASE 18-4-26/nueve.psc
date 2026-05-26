Algoritmo nueve
	Definir  sueldoBase, comision, ventasRealizadas, totalVenta, sueldoFinal Como Real
	
	Escribir "ingrese sueldo base: "
	Leer sueldoBase
	
	Escribir "ingrese numero de ventas realizadas"
	Leer ventasRealizadas
	
	comision = sueldoBase * 0.1
	totalVenta = ventasRealizadas * comision
	
	sueldoFinal = sueldoBase + totalVenta
	
	Escribir "recibira un total de: $", sueldoFinal
	
FinAlgoritmo
