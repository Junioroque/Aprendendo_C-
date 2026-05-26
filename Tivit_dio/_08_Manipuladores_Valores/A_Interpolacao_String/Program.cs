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
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(data.ToShortDateString());


string dataString = "2022-03-17 18:00";
Console.WriteLine(dataString);
//Especificando o formato da Data

//verificar se e uma data valida
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InstalledUICulture, DateTimeStyles.None, out DateTime dataFormato);

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {dataFormato}");
} 
else
{
    Console.WriteLine($"{dataFormato} não é uma data válida!");
}





Console.WriteLine("======================");
 //concatenação--
string numero1 = "10";
string numero2 = "15";
int numero3 = 20;

string resultado;

resultado = numero1 + numero2;

Console.WriteLine(resultado);

resultado = numero1 + numero3;

Console.WriteLine(resultado);

Console.WriteLine("======================");
