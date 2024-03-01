let multiplicador;
let resultado;

// multiplicando = 0;
multiplicador = 7;
// resultado = 0;

console.log(`La tabla del 7 es`);
for(let multiplicando = 1; multiplicando <= 10; multiplicando++){
    resultado = multiplicador *  multiplicando;
    // resultado % 2 ? console.log('es par') : console.log('es impar')
    if (resultado%2){
        console.log('es par');
    } else {
        console.log('es impar');
    }
    console.log(`${multiplicando} x ${multiplicador} = ${resultado}`);
}