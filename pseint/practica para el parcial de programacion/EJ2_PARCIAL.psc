// CREAR UN MENU DE NOTAS DE ESTUDIANTE 
//en el menu se debera registrar la nota, ver el promedio actual, reiniciar las notas, 
//y ademas una opcion para salir del menu, encontrar el promedio de las notas 
//
//
Algoritmo EJ2_PARCIAL
	Definir i, x Como Entero
	Definir prom,num Como Real
	
	x = 0
	prom = 0
	Mientras x = 0 Hacer
		Borrar Pantalla
		Escribir "======================= MENU DE NOTAS ======================="
		Escribir "cantidad de notas cargadas: ",i
		Escribir "promedio actual ",prom
		Escribir "==========================================================="
		Escribir ""
		Escribir "SELECCIONE UNA OPCION A REALIZAR"
		Escribir ""
		Escribir "  1 - cargar nota"
		Escribir "  2 - reiniciar notas"
		Escribir "  3 - salir del programa"
		Escribir ""
		Leer op 
		Segun op Hacer
			1:
				Borrar Pantalla
				Escribir "=======================INGRESE UNA NUEVA NOTA======================="
				Leer num
				si num < 0 o num>10 Entonces
					Borrar Pantalla
					Escribir "#################### ERROR INGRESE UNA NOTA VALIDA ####################"
					Escribir "presione cualquier tecla para continuar"
					Esperar Tecla
				SiNo
					i = i + 1
					suma = suma + num
					prom = suma / i
				FinSi
			2:
				suma = 0
				prom = 0
				i = 0
			3:
				Borrar Pantalla
				Escribir "=======================GRACIAS POR USAR NUESTRO PROGRAMA======================="
				x = 1
			De Otro Modo:
				Borrar Pantalla
				Escribir "############## ERROR INGRESE UNA OPCION VALIDA ##############"
				Escribir "presione cualquier tecla para continuar"
				Esperar Tecla
		Fin Segun
		
	FinMientras
	
	
	
FinAlgoritmo
