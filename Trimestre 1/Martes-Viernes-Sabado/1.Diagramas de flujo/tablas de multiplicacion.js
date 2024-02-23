const prompt = require("prompt-sync")()

//tabla del 1 al 10
// for(let count1 = 1; count1 <= 10; count1++){
//     console.log('\nTabla del ' + count1)

//     for(let count2 = 1; count2 <= 10; count2++){
//         console.log(count1 + ' x ' + count2 + ' = ' + (count1 * count2))
//     }
// }


//tabla del 7 al 19
// for(let count1 = 7; count1 <= 19; count1++){
//     console.log('\nTabla del ' + count1)

//     for(let count2 = 1; count2 <= 10; count2++){
//         console.log(count1 + ' x ' + count2 + ' = ' + (count1 * count2))
//     }
// }

//dando dos valore
let lowRange = 0;
let hightRange = 0;
console.log('Programa para hacer la tabla de multiplicar por favor digite el rango')
lowRange = isValid(prompt('Digite desde donde va a empezar la tabla '));
hightRange = isValid(prompt('Digite hasta donde va a hacer la tabla '));

while (hightRange < lowRange){
    hightRange = isValid(prompt('El valor mayor no puede ser menor que el valor menor, por favor digite un nuevo valor '));
}

for(let count1 = lowRange; count1 <= hightRange; count1++){
    console.log('\nTabla del ' + count1)

    for(let count2 = 1; count2 <= 10; count2++){
        console.log(count1 + ' x ' + count2 + ' = ' + (count1 * count2))
    }
}

//Funcion para verificar la validez de un numero
function isValid(params) {
    while (isNaN(params)) {
        params = prompt('Numero no valido por favor digite uno nuevo ')
    };
    return params;
}