//En un arreglo se tienen registradas las ventas de cinco empleados durante
//cinco días de la semana. Se requiere determinar cuál fue la venta mayor
//realizada.
Algoritmo sin_titulo
	Definir may Como real
	
	Dimensionar matriz[5,5]
	
	para i=1 hasta 5 Hacer
		Escribir "====MONTOS DE VENTAS DEL: ",i, "° EMPLEADO===="
		Para j=1 Hasta 5 Hacer
			Escribir Sin Saltar "ingrese la: ",j,"° venta"
			Leer matriz[i,j]
		FinPara
	FinPara
	
	Para i=1 Hasta 5 Hacer
		Para j=1 Hasta 5 Hacer
			si may < matriz[i,j] Entonces
				may = matriz [i,j]
			FinSi
		FinPara
	FinPara
	
	Escribir "======================================"
	Escribir "LA VENTA DE MAYOR MONTO FUE DE: $",may
	
FinAlgoritmo
