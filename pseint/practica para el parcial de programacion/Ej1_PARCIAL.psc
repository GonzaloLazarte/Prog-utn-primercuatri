//realice un algoritmo que lea dos vectores  de 5 elementos y que calcule la suma de estos guardando su resultado en otro vector,
// el cual se debe presentar en forma impresa 

Algoritmo Ej1_PARCIAL
	Definir i Como Entero
	
	Dimensionar va[5]
	Dimensionar vb[5]
	Dimensionar vc[5]
	
	Escribir "=============CARGA DE VECTORES================"
	para i=1 Hasta 5 Hacer
		Escribir Sin Saltar " ingrese el ",i,"° valor del vector A "
		Leer va[i]
	FinPara
	Escribir "=============CARGA DE VECTORES================"
	para i=1 Hasta 5 Hacer
		Escribir Sin Saltar " ingrese el ",i,"° valor del vector B "
		Leer vb[i]
	FinPara
	Escribir "=============SUMA DE VECTORES================"
	Escribir "Vector resultante: "
	para i=1 Hasta 5 Hacer
		vc[i] = va[i] + vb[i]
		Escribir Sin Saltar " [", vc[i],"]"
	FinPara
	
FinAlgoritmo
