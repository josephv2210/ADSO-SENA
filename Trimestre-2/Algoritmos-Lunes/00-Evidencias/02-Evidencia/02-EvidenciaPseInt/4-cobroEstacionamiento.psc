Algoritmo cobroEstacionamiento
	Escribir "Programa para determinar cuanto debe cobrar por el uso del estacionamiento"
	Escribir "Digite la cantidad de horas que estuvo en el parqueadero"
	Leer horas
	
	Escribir "Cantidad de horas totales.......", horas
	si (horas <= 2) Entonces
		total = horas * 5
		Escribir ""
		Escribir "Primera franja (", (horas) ," hora/s).......", horas
		Escribir "Costo Hora.....................x", 5
		Escribir "................................---------------------"
		Escribir "Total horas primera franja......", horas*5
	SiNo
		total = 2 * 5
		
		Escribir ""
		Escribir "Primera franja (2 horas)........", 2
		Escribir "Costo Hora.....................x", 5
		Escribir "................................---------------------"
		Escribir "Total horas primera franja......", 2*5
		
		Si (horas <= 5) Entonces
			total = total + ((horas - 2) * 4)
			
			Escribir ""
			Escribir "Primera franja (", (horas-2) ," hora/s).......", horas-2
			Escribir "Costo Hora.....................x", 4
			Escribir "................................---------------------"
			Escribir "Total horas primera franja......", (horas-2)*4
		SiNo
			total = total + (3*4)
			Escribir ""
			Escribir "Segunda franja (3 horas)........", 3
			Escribir "Costo Hora.....................x", 4
			Escribir "................................---------------------"
			Escribir "Total horas primera franja......", 3*4
			
			Si (horas <= 10) Entonces
				total = total + ((horas-5)*3)
				
				Escribir ""
				Escribir "Primera franja (", (horas-5) ," hora/s).......", horas-5
				Escribir "Costo Hora.....................x", 3
				Escribir "................................---------------------"
				Escribir "Total horas primera franja......", (horas-5)*3
			SiNo
				total = total + (5*3) + ((horas-10)*2)
				Escribir ""
				Escribir "Tercera franja (5 horas)........", 5
				Escribir "Costo Hora.....................x", 3
				Escribir "................................---------------------"
				Escribir "Total horas primera franja......", 5*3
				
				Escribir ""
				Escribir "Cuarta franja (", (horas-10) ," hora/s)........", (horas-10)
				Escribir "Costo Hora.....................x", 2
				Escribir "................................---------------------"
				Escribir "Total horas primera franja......", (horas-10) * 2
			FinSi
		FinSi
	FinSi
	Escribir ""
	Escribir "El valor a pagar es ", total
FinAlgoritmo
