Algoritmo CalcularValorCheque
	//Una empresa desea determinar el monto de un cheque que debe proporcionar a
	//uno de sus empleados que tendrá que ir por equis número de días a la ciudad de
	//Monterrey; los gastos que cubre la empresa son: hotel, comida y 100.00 pesos
	//diarios para otros gastos. El monto debe estar desglosado para cada concepto.
	//Realice un diagrama de flujo y pseudocódigo que representen el algoritmo que
	//determine el monto del cheque
	
	Escribir "Programa para determinar el valor del cheque que se le tiene que dar al empleado"
	Escribir "Por favor digite el costo del hotel"
	Leer  valorHotel
	Escribir "Por favor digite el costo de la comida"
	Leer  valorComida
	Escribir "Por favor digite la cantidad de dias del viaje"
	Leer  cantidadDias
	gastosDiarios = 100
	
	Escribir "Costo hotel........... ", valorHotel
	Escribir "Costo comida	.......... ", valorComida
	Escribir "Otros gastos.......... ", gastosDiarios
	Escribir "...................... ----------------------"
	total = valorHotel+valorComida+gastosDiarios
	Escribir "...................... ", total
	Escribir "El valor del cheque es -> ", total*cantidadDias
	
	
FinAlgoritmo
