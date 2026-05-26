// Se requiere determinar cuántos ceros se encuentran en un arreglo de cuatro
// renglones y cuatro columnas, las cuales almacenan valores comprendidos
// entre 0 y 9
Algoritmo sin_titulo
	Definir cuentacero, i, j, num,preg Como Entero

	Dimensionar matriz(4,4)
	Escribir '===============CARGAR MATRIZ==============='
	Escribir ''
	Para i<-1 Hasta 4 Hacer
		Para j<-1 Hasta 4 Hacer
			preg = 0
			Mientras preg = 0 Hacer
				Escribir 'valor para [', i, ';', j, ']'Sin Saltar
				Leer num
				Si num >= 0 Y num <= 9 Entonces
					matriz[i,j] = num
					preg = 1
				SiNo
					Escribir 'ingrese un numero comprendido entre 0 y 9'
				FinSi
			FinMientras
		FinPara
	FinPara
	
	Para i=1 Hasta 4 Hacer
		Para j=1 Hasta 4 Hacer
			Si matriz[i,j] = 0 Entonces
				cuentacero <- cuentacero + 1
			FinSi
		FinPara
	FinPara
	Escribir '==============================================='
	Escribir 'en este arreglo se encuentran ', cuentacero, "numeros cero"
	Para i<-1 Hasta 4 Hacer
		Para j<-1 Hasta 4 Hacer
			Escribir Sin Saltar "     " matriz[i,j]
		FinPara
		Escribir ''
	FinPara
FinAlgoritmo
