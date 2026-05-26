Algoritmo sin_titulo
		Definir arreglo, i, j, aux Como Entero
		Dimension arreglo[5]
		// Cargar valores
		arreglo[1] = 5
		arreglo[2] = 2
		arreglo[3] = 8
		arreglo[4] = 1
		arreglo[5] = 4
		Escribir "ARREGLO INICIAL:"
		
		Para i = 1 Hasta 5 Hacer
			Escribir Sin Saltar arreglo[i], " "
		FinPara
		
		Escribir ""
		Escribir "------------------------"
		// Metodo burbuja
		Para i = 1 Hasta 4 Hacer
			
			Escribir ""
			Escribir "PASADA ", i
			Escribir "----------------"
			
			Para j = 1 Hasta 5 - i Hacer
				
				Escribir ""
				Escribir "Comparando ", arreglo[j], " y ", arreglo[j + 1]
				
				Si arreglo[j] > arreglo[j + 1] Entonces
					Escribir "Se intercambian"
					aux = arreglo[j]
					arreglo[j] = arreglo[j + 1]
					arreglo[j + 1] <- aux
				SiNo
					Escribir "No se intercambian"
				FinSi
				// Mostrar arreglo actual
				
				Escribir "Estado actual del arreglo:"
				
				Para aux = 1 Hasta 5 Hacer
					Escribir Sin Saltar arreglo[aux], " "
				FinPara
				
				Escribir ""
				
			FinPara
		FinPara
		
		Escribir ""
		Escribir "======================="
		Escribir "ARREGLO ORDENADO:"
		
		Para i = 1 Hasta 5 Hacer
			Escribir Sin Saltar arreglo[i], " "
		FinPara
		
FinAlgoritmo
