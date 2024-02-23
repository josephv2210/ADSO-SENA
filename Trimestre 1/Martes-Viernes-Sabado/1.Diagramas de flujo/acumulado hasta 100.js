const prompt = require("prompt-sync")()

let sum = 0;
let text = '';

let count = prompt('Digite el número hasta el cual desea sumar ');

console.log(count);

for (let i = 0; i <= 100; i++){
    
    text = text+ ' + '+ i;
    sum = sum + i;
}

console.log('la sumatoria de '+ text +' es igual a:');
console.log(sum);

//hacer y desarrollar la tabla del 7
//hacer un diagrama de flujo para las tablas entre el 2 y el 9