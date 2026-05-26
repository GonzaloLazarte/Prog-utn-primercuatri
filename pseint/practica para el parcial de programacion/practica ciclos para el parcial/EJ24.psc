//Realice el algoritmo para determinar cuánto pagará una persona que
//adquiere N artículos, los cuales están de promoción. Considere que
//si su precio es mayor o igual a $200 se le aplica un descuento de 15%,
//y si su precio es mayor a $100 pero menor a $200, el descuento es de
//12%; de lo contrario, sólo se le aplica 10%. Se debe saber cuál es el
//costo y el descuento que tendrá cada uno de los artículos y finalmente
//cuánto se pagará por todos los artículos obtenidos.Validar los precios
//para evitar que se ingrese cero precios

Algoritmo sin_titulo
	Definir N, i Como Entero
	Definir art, total,totaldesc, descuento, preciodescuento Como Real
	
	Escribir "===============TIENDA==============="
	Escribir "ingrese el numero de articulos"
	Leer N
	
	i=1
	
	Mientras i <= N Hacer
		Escribir "ingrese el precio del ",i, "° articulo"
		Leer art
		si art = 0 Entonces
			Escribir "//////////////*EL PRECIO NO PUEDE SER CERO ASNO*\\\\\\\\\\\\\\\"
		SiNo
			si art >= 200 Entonces
				descuento = art * 0.15
				preciodescuento = art - descuento
				Escribir "el costo es de : ", art, " se le aplicara un descuento de: 15% - $", descuento
				Escribir "preciofinal:", preciodescuento
				total = total + art
				totaldesc = totaldesc + preciodescuento
			SiNo
				si art > 100 y art < 200 Entonces
					
					descuento = art * 0.12
					preciodescuento = art - descuento
					Escribir "el costo es de : ", art, " se le aplicara un descuento de: 12% - $", descuento
					Escribir "preciofinal:", preciodescuento
					total = total + art
					totaldesc = totaldesc + preciodescuento
				SiNo
					descuento = art *0.1
					preciodescuento = art - descuento
					Escribir "el costo es de : ", art, " se le aplicara un descuento de: 10% - $", descuento
					Escribir "preciofinal:", preciodescuento
					total = total + art
					totaldesc = totaldesc + preciodescuento
					
				FinSi
			FinSi
			i=i+1
		FinSi
	FinMientras
	Escribir "el precio total por los articulos es", total
	Escribir "el precio total de los articulos con descuentos aplicados es de: ",totaldesc
	
	
FinAlgoritmo
