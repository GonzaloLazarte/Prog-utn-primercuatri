// Un cliente de un banco deposita equis cantidad de pesos cada mes
// en una cuenta de ahorros. La cuenta percibe un interés fijo durante
// un año de 10  MOD  anual. Realice un algoritmo para determinar el total
// de la inversión final de cada año en los próximos N años.
Algoritmo sin_titulo
	Definir plata, interes, x, platano, inversion Como Real
	Definir i, ii, anos Como Entero
	Escribir '============BANCO==========='
	Escribir 'ingrese el numeros de años en los que va a ahorrar'
	Leer anos
	Escribir 'ingrese la cantidad fija que ingresara cada mes: 'Sin Saltar
	Leer x
	i = 0
	j = 1
	Mientras i<anos Hacer
		j=1
		Mientras j<=12 Hacer
			plata = plata+x
			j = j+1
		FinMientras
		inversion = inversion+plata
		interes = plata + plata*0.1
		Escribir 'plata en ', i+1, ' año', plata
		platano = platano+interes
		i = i+1
	FinMientras
	Escribir 'dinero invertido: ', inversion
	Escribir 'plata con intereses en ', i, ' años:', platano
FinAlgoritmo
