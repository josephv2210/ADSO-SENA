Algoritmo CalculoVivido
	//Realice un diagrama de flujo y pseudoc�digo que representen el algoritmo para
	//determinar aproximadamente cu�ntos meses, semanas, d�as y horas ha vivido una
	//persona.
	today = FechaActual()
	Escribir "Programa para determinar aproximadamente cuantos meses, semanas, d�as y horas ha vivido una persona"
	Escribir "Digite el a�o de nacimiento de la persona"
	Leer anio
	
	anioToday = trunc(today/10000)
	
	Mientras (anioToday - anio < 0) Hacer
		Escribir "El a�o dado no puede ser mayor al a�o actual"
		Escribir "Por favor digite el a�o de nacimiento nuevamente"
		Leer anio
		
	FinMientras
	
	aniosVividos =  (anioToday - anio)
	mesesVividos = aniosVividos * 12
	semanasVividos = mesesVividos * 4
	diasVividos = semanasVividos * 7
	horasVividos = diasVividos * 24
	
	Escribir "A�os vividos........... ", aniosVividos
	Escribir "Meses vividos.......... ", mesesVividos
	Escribir "Semanas vividas.......... ", semanasVividos
	Escribir "D�as vividos........... ", diasVividos
	Escribir "Horas vividas.......... ", horasVividos
	
FinAlgoritmo
