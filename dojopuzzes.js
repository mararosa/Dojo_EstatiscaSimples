// Calculando estatísticas simples

/*
Sua tarefa é processar uma seqüência de números inteiros para determinar as seguintes estatísticas:

Valor mínimo
Valor máximo
Número de elementos na seqüência
Valor médio
Por exemplo para uma seqüência de números "6, 9, 15, -2, 92, 11", temos como saída:

Valor mínimo: -2
Valor máximo: 92
Número de elementos na seqüência: 6
Valor médio: 18.1666666
*/


function calcularEstatisticas(numeros) {
    let acumulador = 0;
    let max = numeros[0];
    let min = numeros[0];
    let qtdade = numeros.length;
    for (let i = 0; i < numeros.length; i++) {
        acumulador += numeros[i];
        if (numeros[i] > max) {
            max = numeros[i];
        }
        if (numeros[i] < min) {
            min = numeros[i];
        }
    }
    let media = acumulador / qtdade;

    console.log("Maximo: " + max)
    console.log("Mínimo: " + min)
    console.log("Quantidade digitada: " + qtdade);
    console.log("Média: " + media);
}

let numerosInteiros = [6, 9, 15, 2, 7, 11, 8, 100, 8];
calcularEstatisticas(numerosInteiros);

