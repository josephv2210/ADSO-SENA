Algoritmo CalcularPrecioArticulo
	//Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para
	//determinar cuánto pagará finalmente una persona por un artículo equis,
	//considerando que tiene un descuento de 20%, y debe pagar 15% de IVA (debe
	//mostrar el precio con descuento y el precio final).
	
	Escribir "Programa para determinar el cobro final de un producto que tiene un 20% y debe pagar 15% de IVA"
	Escribir "Por favor digite el costo del producto"
	Leer  valorProducto
	Escribir "..................... ", valorProducto
	descuento = -1*valorProducto*0.2
	Escribir "20% de descuento	..... ", descuento
	iva = -descuento*0.15
	Escribir "15% de IVA........... ", iva
	Escribir "..................... ----------------------"
	Escribir "..................... ", valorProducto+descuento+iva
FinAlgoritmo
