Algoritmo ageCalculator
	//Una empresa que contrata personal requiere determinar la edad de las personas que solicitan trabajo, pero cuando se les realiza la entrevista s�lo se les pregunta el a�o en que nacieron. 
	//Realice el diagrama de flujo y pseudoc�digo que representen el algoritmo para solucionar este problema.
	today = FechaActual()
	Escribir "Programa para calcular la edad de las personas segun el a�o"
	Escribir "Digite el a�o de nacimiento"
	Leer anio
	
	anioToday = trunc(today/10000)
	
	
	Escribir "La edad es -> ", (anioToday - anio)
	
FinAlgoritmo
