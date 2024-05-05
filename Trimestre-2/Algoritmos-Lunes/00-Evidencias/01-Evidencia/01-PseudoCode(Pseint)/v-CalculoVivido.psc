Algoritmo CalculoVivido
	//Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para
	//determinar aproximadamente cuántos meses, semanas, días y horas ha vivido una
	//persona.
	today = FechaActual()
	Escribir "Programa para determinar aproximadamente cuantos meses, semanas, días y horas ha vivido una persona"
	Escribir "Digite el año de nacimiento de la persona"
	Leer anio
	
	anioToday = trunc(today/10000)
	
	Mientras (anioToday - anio < 0) Hacer
		Escribir "El año dado no puede ser mayor al año actual"
		Escribir "Por favor digite el año de nacimiento nuevamente"
		Leer anio
		
	FinMientras
	
	aniosVividos =  (anioToday - anio)
	mesesVividos = aniosVividos * 12
	semanasVividos = mesesVividos * 4
	diasVividos = semanasVividos * 7
	horasVividos = diasVividos * 24
	
	Escribir "Años vividos........... ", aniosVividos
	Escribir "Meses vividos.......... ", mesesVividos
	Escribir "Semanas vividas.......... ", semanasVividos
	Escribir "Días vividos........... ", diasVividos
	Escribir "Horas vividas.......... ", horasVividos
	
FinAlgoritmo
