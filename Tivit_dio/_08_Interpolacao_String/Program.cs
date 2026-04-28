using System.Globalization;

decimal valorMonetario = 22.40M;
//Já esta configurado conforme o local que você está pois estou no Brasil.
Console.WriteLine($"{valorMonetario:C}");

//Nesse formato transforma todo valor em estrangeiro.
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorEstrangeiro = 45.44M;

//$ esse simbolo e para interpolar String
//Console.WriteLine($"{valorEstrangeiro:C}");
//Console.WriteLine($"{valorMonetario:C}");

//Outra forma de ver valor estrangeiro

Console.WriteLine(valorEstrangeiro.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));

//porcentagem

double porcentagem = .3211;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

//Outra tipo de formatação
Console.WriteLine(numero.ToString("##_##_##"));

Console.WriteLine("======================");
//Formatação de DateTime
DateTime data = DateTime.Now;

Console.WriteLine(data);
