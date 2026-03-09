int[] arrayInteiro = new int[3];
arrayInteiro[0] = 3;
arrayInteiro[1] = 4;
arrayInteiro[2] = 11;
//Se forçar a posição do array, vai dar error
//arrayInteiro[0] = 333;

foreach(int valor in arrayInteiro){
    Console.WriteLine("Posição N° "+valor);
}

Console.WriteLine("===============================");
//aumentar o array ele é ilimitado.
Array.Resize(ref arrayInteiro, 4);
arrayInteiro[3] = 22;

foreach(int valor in arrayInteiro){
    Console.WriteLine("Posição N° "+valor);
}

Console.WriteLine("===============================");

//Criar um array e copiar o valores e aumentar as posições
int[] arrayInteirosDobrados = new int[arrayInteiro.Length * 2];
Array.Copy(arrayInteiro, arrayInteirosDobrados, arrayInteiro.Length);

foreach(int valor in arrayInteirosDobrados){
    Console.WriteLine("Posição N° "+valor);
}

