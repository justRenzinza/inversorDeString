using System;

class Program{

    static void Main(){

        // curiosidade, a frase "socorram-me subi no ônibus em marrocos" é a mesma ao contrario :)
    
        Console.Write("Digite uma string para inverter: ");
        string stringDigitada = Console.ReadLine();

        string stringInvertida = inverteString(stringDigitada);

        Console.WriteLine($"A string digitada era: {stringDigitada}");
        Console.WriteLine($"A string invertida agora é: {stringInvertida}");
    }

    static string inverteString(string input){
        // função ToCharArray utilizada para converter uma string em um array de caracteres
        char[] caracteres = input.ToCharArray();

        // nesse caso poderia utilizar uma lista mas é melhor uma tupla
        for (int inicioDaString = 0, fimDaString = caracteres.Length - 1; inicioDaString < fimDaString; inicioDaString++, fimDaString--){

            (caracteres[inicioDaString], caracteres[fimDaString]) = (caracteres[fimDaString], caracteres[inicioDaString]);

        }

        return new string(caracteres);
    }
}
