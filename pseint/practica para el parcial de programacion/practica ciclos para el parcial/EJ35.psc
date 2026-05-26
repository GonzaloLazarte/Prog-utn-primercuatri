//Crear un menú de notas de estudiantes. Encontrar el promedio
// de las notas
Algoritmo sin_titulo
	Definir nota, i, n, op  Como Entero
	Definir promedio, suma Como Real
	
	promedio = 0
	n = 0
	i=1
	Mientras i<>0 Hacer
		Borrar Pantalla
		Escribir "=============MENU DE NOTAS============="
		Escribir "promedio total actual: ", promedio
		Escribir "======================================="
		Escribir ""
		Escribir "1) ingresar nota"
		Escribir "2) reiniciar promedio de notas notas"
		Escribir "3) salir del programa"
		Leer op
		Borrar Pantalla
		Segun op Hacer
			1:
				Escribir Sin Saltar "ingresar nota: "
				Leer nota
				
				si nota < 0 Entonces
					Escribir "***********INGRESE UNA NOTA VALIDA*********"
					Escribir "presione una tecla para continuar"
					Esperar Tecla
				SiNo
					n = n + 1
					suma = suma + nota
					promedio = suma / n
				FinSi
			2:
				n = 0
				promedio = 0
				
			De Otro Modo:
				Borrar Pantalla
				si op=3 Entonces
					i=0
				SiNo
					Escribir "INGRESE UNA OPCION VALIDA ASNO"
					Escribir "presione un tecla para continuar"
					Esperar Tecla
				FinSi
		FinSegun
		
		
	FinMientras
	
FinAlgoritmo
