Algoritmo determinarRegalo
	Escribir "Programa para determinar el regalo"
	Escribir "Por favor digite su presupuesto"
	
	leer presupuesto
	
	Si presupuesto <= 10 Entonces
		regalo = "una tarjeta"
	SiNo 
		Si presupuesto <= 100 Entonces
			regalo = "unos chocolates"
		SiNo
			Si presupuesto <= 250 Entonces
				regalo = "unas flores"
			SiNo
				regalo = "un anillo"
			FinSi
		FinSi
	FinSi
	
	Escribir "Tu regalo es ", regalo
	
FinAlgoritmo
