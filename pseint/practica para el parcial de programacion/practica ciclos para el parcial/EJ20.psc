// "El náufrago satisfecho" ofrece hamburguesas sencillas (S), dobles
// (D) y triples (T), las cuales tienen un costo de $20, $25 y $28 respectivamente.
// La empresa acepta tarjetas de crédito con un cargo
// de 5  MOD  sobre la compra. Suponiendo que los clientes adquieren N
// hamburguesas, las cuales pueden ser de diferente tipo, realice un
// algoritmo para determinar cuánto deben pagar.
Algoritmo sin_titulo
	Definir cantidad, i Como Entero
	Definir recargo, total Como Real
	Definir tipo Como Cadena
	Escribir '===============NAUFRAGO SATISFECHO==============='
	Escribir 'ingrese el numero de hamburguesas del pedido: 'Sin Saltar
	Leer cantidad
	Escribir 'TIPOS DE HAMBURGUESA '
	Escribir 'S -  para hamburguesa simple'
	Escribir 'D - para hamburguesa doble'
	Escribir 'T -  para hamburguesa triple'
	i <- 0
	Mientras i<cantidad Hacer
		Escribir 'ingrese que tipo de hamburguesa'
		Leer tipo
		Según tipo Hacer
			'S', 's':
				total <- total+20
				i <- i+1
			'D', 'd':
				total <- total+25
				i <- i+1
			'T', 't':
				total <- total+28
				i <- i+1
			De Otro Modo:
				Escribir 'debe ingresar un parametro valido para la hamburguesa'
		FinSegún
	FinMientras
	tipo <- ''
	Escribir 'pagara con tarjeta de credito? '
	Escribir 'presione y/n '
	Leer tipo
	i <- 0
	Mientras i=0 Hacer
		Según tipo Hacer
			'y', 'Y':
				recargo <- total*0.05
				total <- total+recargo
				Escribir 'su pago total seria de : $', total
				i <- 1
			'n', 'N':
				Escribir 'su pago total seria de : $', total
				i <- 1
			De Otro Modo:
				Escribir 'ingrese un parametro valido'
				i <- 0
		FinSegún
	FinMientras
FinAlgoritmo
