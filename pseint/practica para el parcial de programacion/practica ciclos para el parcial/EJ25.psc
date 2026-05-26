// Un cliente de un banco deposita equis cantidad de pesos cada mes
// en una cuenta de ahorros. La cuenta percibe un interés fijo durante
// un año de 10% anual. Realice un algoritmo para determinar el total
// de la inversión final de cada año en los próximos N años.

algoritmo sin_titulo
	Definir platames, interes, interesaux, suma, sumainteres  Como Real
	Definir i, j, años Como Entero 
	Escribir "ingrese la cantidad de años "
	Leer años

	Para i=1 Hasta años Hacer
		Para j=1 Hasta 12 Hacer
			
			Escribir Sin Saltar "ingrese la cantidad de dinero para el: ",j,"° mes del ",i,"° año"
			Leer platames
			suma = suma + platames
			
		FinPara
		
		interesaux = 0.1 * suma 
		interes = interes + interesaux
		sumainteres = suma + interes
		
		Escribir "monto total invertido el ",i, "° año", suma
		Escribir "intereses generados el ",i, "° año", interes 
		
	FinPara
	
	Escribir "======================MONTO TOTAL DE INVERSION========================"
	Escribir "inversion total:",suma
	Escribir "monto final con interes",sumainteres 
	Escribir "monto de intereses ",interes 
	
FinAlgoritmo
