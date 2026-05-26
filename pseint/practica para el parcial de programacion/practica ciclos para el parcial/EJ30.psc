//Realice un algoritmo que determine el sueldo semanal de N trabajadores
//considerando que se les descuenta 5% de su sueldo si ganan
//entre 0 y 150 pesos. Se les descuenta 7% si ganan más de 150 pero
//menos de 300, y 9% si ganan más de 300 pero menos de 450. Los
//datos son horas trabajadas, sueldo por hora y nombre de cada trabajador.
//Validad cada dato

Algoritmo sin_titulo
	Definir n, i, hora, sueldohora Como Entero
	Definir sueldo,sueldofin, descuento Como Real
	Definir nombre Como Caracter
	
	Escribir "ingrese el numero de trabajadores: "
	Leer n
	Escribir  Sin Saltar"ingrese pago de por hora: "
	Leer sueldohora
	
	i=1
	Mientras i <= n Hacer
		
		Escribir "=====ingrese datos del trabajador ",i,"======"
		leer nombre
		si nombre = "" Entonces
			Escribir "el nombre no puede estar vacio"
		SiNo
			
			Escribir Sin Saltar "ingrese las horas trabajadas: "
			Leer hora
			sueldo = sueldohora * hora
			
			si sueldo >= 0 y sueldo <= 150 Entonces
				descuento = sueldo * 0.05
			SiNo
				si sueldo > 150 y sueldo < 300 Entonces
					descuento = sueldo * 0.07
				SiNo
					si sueldo> 300 y sueldo <450 Entonces
						descuento = sueldo * 0.09
					sino
						descuento = sueldo * 0.1
					FinSi
				FinSi
			FinSi
			sueldofin = sueldo - descuento
			
			Escribir "el trabajador: ", nombre
			Escribir "trabajo: ",hora, "horas"
			Escribir "su sueldo sera de: $", sueldo
			Escribir "se le aplicara un descuento de: $",descuento
			Escribir "sus ueldo final sera de: $", sueldofin
			i=i+1
		FinSi
	FinMientras
FinAlgoritmo
