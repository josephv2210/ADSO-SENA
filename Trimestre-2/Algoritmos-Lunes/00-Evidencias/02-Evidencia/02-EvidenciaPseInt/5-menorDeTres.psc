Algoritmo menorDeTres
	Escribir "Programa para determinar el menor de tres personas"
	Escribir ""
	Escribir "Digite el nombre de la primera persona"
	Leer nombre1
	Escribir "Digite la edad de la primera persona"
	Leer edad1
	
	Escribir ""
	Escribir "Digite el nombre de la segunda persona"
	Leer nombre2
	Escribir "Digite la edad de la segunda persona"
	Leer edad2
	
	Escribir ""
	Escribir "Digite el nombre de la tercera persona"
	Leer nombre3
	Escribir "Digite la edad de la tercera persona"
	Leer edad3
	
	Escribir ""
	menorNombre = nombre1
	menorEdad = edad1
	
	si menorEdad > edad2 Entonces
		menorNombre = nombre2
		menorEdad = edad2
	FinSi
	
	si menorEdad > edad3 Entonces
		menorNombre = nombre3
		menorEdad = edad3
	FinSi
	
	Escribir "El menor es ", menorNombre ," con ", menorEdad
	
FinAlgoritmo
