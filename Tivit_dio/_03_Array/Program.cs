int[] arrayInteiro = new int[4];

arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 50;
arrayInteiro[3] = 1;

for(int contador = 0; contador < arrayInteiro.Length; contador++) {
    Console.WriteLine($"Posição N° {contador} - {arrayInteiro[contador]}");
}