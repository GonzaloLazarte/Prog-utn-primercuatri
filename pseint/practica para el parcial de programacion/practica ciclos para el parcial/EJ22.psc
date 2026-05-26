//Una compañía fabrica focos de colores (verdes, blancos y rojos). Se
//desea contabilizar, de un lote de N focos, el número de focos de cada
//color que hay en existencia.

Algoritmo sin_titulo
	Definir Nfocos, i, rojo, blanco, verde Como Entero
	Definir tipo Como Caracter
	
	
	Escribir "INGRESE EL N° DE FOCOS DEL LOTE"
	Leer Nfocos
	Escribir ""
	Escribir "los parametros para ingresar los focos son "
	Escribir "R - para rojos"
	Escribir "B - para blancos"
	Escribir "V - para verdes"
	
	rojo = 0
	blanco = 0
	verde = 0
	i = 0
	
	Mientras i < Nfocos Hacer
		
		Escribir "ingrese el tipo de foco"
		leer tipo
		
		Segun tipo Hacer
			"r"o "R":
				rojo = rojo + 1
				i = i + 1
			"b"o "B":	
				blanco = blanco + 1
				i = i + 1
			"v"o "V":	
				verde = verde + 1
				i = i + 1
			De Otro Modo:
				Escribir "ingrese un valor valido"
		FinSegun
	FinMientras
	
	Escribir "hay ",verde, "focos verdes"
	Escribir "hay ",rojo, "focos rojos"
	Escribir "hay ",blanco, "focos blancos"
	
FinAlgoritmo
