Algoritmo ageCalculator
	//Una empresa que contrata personal requiere determinar la edad de las personas que solicitan trabajo, pero cuando se les realiza la entrevista sólo se les pregunta el año en que nacieron. 
	//Realice el diagrama de flujo y pseudocódigo que representen el algoritmo para solucionar este problema.
	today = FechaActual()
	Escribir "Programa para calcular la edad de las personas segun el año"
	Escribir "Digite el año de nacimiento"
	Leer anio
	
	anioToday = trunc(today/10000)
	
	
	Escribir "La edad es -> ", (anioToday - anio)
	
FinAlgoritmo
