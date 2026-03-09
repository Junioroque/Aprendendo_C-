//Lista String

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador++) {
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}
 
Console.WriteLine("=============Foreach=============");
foreach(string item in listaString) {
    Console.WriteLine($"Numero posição: {item}");
}

listaString.Remove("MG");

Console.WriteLine($"Item na minha lista {listaString.Count} - Capacidade: {listaString.Capacity}");

