Algoritmo AreaVolumenCilindro
	//Desarrolla un algoritmo (pseudoc�digo) que permita determinar el �rea y volumen de un cilindro
	Escribir "Programa para determinar el area y el volumen de un cilindro"
	Escribir "Ingrese el radio del cilindro"
	Leer r
	Escribir "Ingrese la altura del cilindro"
	Leer h
	area = ((2 * PI * (r^2)) + (2 * PI * r * h))
	volumen = PI * (r^2) * h
	Escribir "El area es -> ", area
	Escribir "El volumen es -> ", volumen 
FinAlgoritmo
