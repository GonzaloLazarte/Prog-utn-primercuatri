//Los directivos de equis escuela requieren determinar cuál es la edad
//promedio de cada uno de los M salones y cuál es la edad promedio
//de toda la escuela. Realice un algoritmo para determinar estos promedios
Algoritmo sin_titulo
	Definir sumsalon, promedioSalon,promediosaltotal, promesc,promesctotal Como Real
	Definir i,j,edad, alum, salon Como Entero
	
	Escribir "ingrese la cantidad de salones de la escuela"
	Leer salon
	Para i = 1 Hasta salon Hacer
		
		Escribir "ingrese la cantidad de alumnos del", i, "salon"
		Leer alum
		Para j=1 Hasta alum Hacer
			Escribir Sin Saltar"edad del " j, "° alumno" 
			Leer edad
			
			sumsalon = sumsalon + edad
			
		FinPara
		promedioSalon = sumsalon / alum
		Escribir "Edad promedio del", i, "salon es: ", promedioSalon
		promediosaltotal = promediosaltotal + promedioSalon
	FinPara
	promesctotal = promediosaltotal / salon
	
	Escribir "la edad promedio de toda la escuela es de ", promesctotal
	
	
	
FinAlgoritmo
