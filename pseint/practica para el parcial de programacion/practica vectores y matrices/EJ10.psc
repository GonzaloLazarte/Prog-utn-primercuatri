//Realice el algoritmo para obtener el producto de dos matrices de orden M x N y P x Q.
Algoritmo sin_titulo
	Definir m, n, p, q, l Como Entero
	Escribir "============CARGAR DIMENSIONES DE LA MATRIZ============"
	l=0
	Mientras l=0 Hacer
		Borrar Pantalla
		Escribir "DATOS DE LA PRIMERA MATRIZ"
		Escribir Sin Saltar "filas"
		Leer m
		Escribir Sin Saltar "columnas"
		Leer n
		Escribir "DATOS DE LA SEGUNDA MATRIZ"
		Escribir Sin Saltar "filas"
		Leer p
		Escribir Sin Saltar "columnas"
		Leer q
		
		Dimensionar ma[m,n]
		Dimensionar mb[p,q]
		si n = p Entonces
			Dimensionar mc[m,q]
			Escribir "cargar elementos de la primera matriz"
			para i=1 Hasta m Hacer
				Para j=1 Hasta n Hacer
					Escribir "valor de: [",i,";",j,"]"
					Leer ma[i,j]
				FinPara
			FinPara
			Escribir "cargar elementos de la segunda matriz"
			para i=1 Hasta p Hacer
				Para j=1 Hasta q Hacer
					Escribir "valor de: [",i,";",j,"]"
					Leer mb[i,j]
				FinPara
			FinPara
			
			para i=1 Hasta m Hacer
				Para j=1 Hasta q Hacer
					mc[i,j] = 0
					Para k=1 Hasta n Hacer
						mc[i,j] = mc[i,j] + ( ma[i,k] * mb[k,j] )
					FinPara
				FinPara
			FinPara
		l=1
		SiNo
			Escribir "error"
			Escribir "el numero de comunas de la primera matriz debe ser igual al numero de filas de las segunda"
			Escribir "presione una tecla para reintentar"
			Esperar Tecla
		FinSi
	FinMientras
	
	
	Para i=1 Hasta m Hacer
		Para j=1 Hasta q Hacer
			Escribir Sin Saltar "   ", mc[i,j]
		FinPara
		Escribir ""
	FinPara
	
	
	
	
FinAlgoritmo
