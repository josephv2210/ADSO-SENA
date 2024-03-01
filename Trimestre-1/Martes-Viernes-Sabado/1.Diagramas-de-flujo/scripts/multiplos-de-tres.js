//programa que dado un numero da los multiplos hasta ese numero
const prompt = require("prompt-sync")();

console.log('Por favor digite el numero al cual se le va a determinar los multiplos');

let numero = parseInt(prompt("Ingrese un numero -> "));
let text = 0;

for (let i = 3; i <= numero; i = i +3) {
    text = text + ', ' + i ;
}
console.log(text)
