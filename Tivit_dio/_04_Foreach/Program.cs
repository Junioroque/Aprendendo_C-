int[] arrayInteiro = new int[3];
arrayInteiro[0] = 3;
arrayInteiro[1] = 4;
arrayInteiro[2] = 11;

arrayInteiro[0] = 333;

foreach(int valor in arrayInteiro){
    Console.WriteLine("Posição N° "+valor);
}