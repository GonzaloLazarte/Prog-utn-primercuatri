//Crear un menú de un cajero automático simple, en el que
// se deposita dinero. Con un saldo inicial igual a 1000

Algoritmo sin_titulo
	Definir dinero, poner, sacar Como Real
	Definir  op, i Como Entero
	
	dinero= 1000
	
	Mientras  i <> 3 Hacer
		Borrar Pantalla
		Escribir "=============BANCO============="
		Escribir "saldo disponible en cuenta: ", dinero
		Escribir ""
		Escribir ""
		Escribir "==============MENU=============="
		Escribir "elegir la opcion a realizar "
		Escribir ""
		Escribir "1) ingresar dinero"
		Escribir "2) retirar dinero"
		Escribir "3)salir del programa"
		Escribir ""
		leer op
		Borrar Pantalla
		Segun op Hacer
			1:
				Escribir "cuanto dinero desea ingresar?"
				Leer poner
				dinero = dinero + poner
			2:
				Escribir "saldo disponible: ",dinero
				Escribir "cuanto dinero desea extraer?"
				Leer sacar
				si sacar > dinero Entonces
					Escribir "excede limite de extraccion"
					Escribir "presione una tecla para volver al menu"
					Esperar Tecla
				SiNo
					dinero = dinero - sacar
				FinSi
				
			De Otro Modo:
				si op = 3 Entonces
					i = 3
				SiNo
					Escribir "debe seleccionar una opcion valida"
				FinSi
		FinSegun
	FinMientras
	
	
FinAlgoritmo
