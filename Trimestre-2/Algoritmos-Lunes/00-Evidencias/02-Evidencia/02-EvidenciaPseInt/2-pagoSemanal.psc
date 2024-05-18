Algoritmo pagoSemanal
	//Realice un algoritmo para determinar el sueldo semanal de un trabajador con base en las
	//horas trabajadas y el pago por hora, considerando que después de las 40 horas cada hora se
	//considera como excedente y se paga el doble. Construya el diagrama de flujo, el
	//pseudocódigo y el diagrama N/S
	
	Escribir "Programa para determinar el sueldo semanal"
	Escribir "Digite cuanto gana por hora"
	Leer costoHora
	Escribir "Digite cuantas horas laboro esta semana"
	Leer hora
	
	definir resultado, resultadoExtra Como Real
	resultado = 0;
	resultadoExtra = 0;
	
	//(Hora*40) + ((Hora * 2)* extras)
	
	Escribir "Costo hora......................", costoHora
	
	si (hora > 40) Entonces
		Escribir "Cantidad de horas normales......x", 40
		Escribir "................................---------------------"
		resultado = costoHora * 40
		Escribir "Total horas normales............", resultado
		
		Escribir ""
		Escribir "--------------Horas Extra--------------------"
		Escribir ""
		Escribir "Costo hora......................", costoHora*2
		Escribir "Cantidad de horas extra.........x" hora - 40
		Escribir "................................---------------------"
		resultadoExtra = ((costoHora*2)*(hora-40))
		Escribir "Total horas extra...............", resultadoExtra
		
		Escribir""
		Escribir "--------------Total--------------------"
		Escribir ""
		Escribir "Total horas normales............", resultado
		Escribir "Total horas extra...............", resultadoExtra
		Escribir "................................---------------------"
		Escribir "Total horas laboradas...........", resultado + resultadoExtra
	SiNo
		Escribir "Cantidad de horas ..............x", hora
		Escribir "................................---------------------"
		resultado = costoHora * hora
		Escribir "Total horas normales............", resultado
	FinSi
	
	
FinAlgoritmo
