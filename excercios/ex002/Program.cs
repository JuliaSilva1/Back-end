Console.WriteLine("Digite o valor da placa:");
string placa = Console.ReadLine();

placa = placa.Substring(placa.Length-1, 1);

if(placa == "1" || placa == "2"){
     Console.WriteLine($"Essa placa com final {placa} só pode andar na Segunda");
}
else if(placa == "3" || placa == "4") {
    Console.WriteLine($"Essa placa com o final {placa} só pode andar na terça");
}
else if(placa == "5" || placa == "6") {
    Console.WriteLine($"Essa placa com o final {placa} só pode andar na quarta");
}
else if(placa == "7" || placa == "8") {
    Console.WriteLine($"Essa placa com o final {placa} só pode andar na quinta");
}
else if(placa == "9" || placa == "0") {
    Console.WriteLine($"Essa placa com final {placa} só pode andar na sexta");
}