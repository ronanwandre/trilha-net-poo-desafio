using DesafioPOO.Models;

Console.WriteLine("===== TESTE COM NOKIA =====");
Smartphone nokia = new Nokia(
    numero: "(81) 98765-4321",
    modelo: "Nokia 3310",
    imei: "123456789012345",
    memoria: 16
);

Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memoria}GB");
Console.WriteLine();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n===== TESTE COM IPHONE =====");
Smartphone iphone = new Iphone(
    numero: "(81) 91234-5678",
    modelo: "iPhone 15 Pro",
    imei: "987654321098765",
    memoria: 256
);

Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");
Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("TikTok");

Console.WriteLine("\n===== DEMONSTRAÇÃO DE POLIMORFISMO =====");
List<Smartphone> smartphones = new List<Smartphone>
{
    new Nokia("(81) 99999-0000", "Nokia Lumia", "111111111111111", 32),
    new Iphone("(81) 88888-0000", "iPhone 14", "222222222222222", 128)
};

foreach (var smartphone in smartphones)
{
    Console.WriteLine($"\nTestando {smartphone.Modelo}:");
    smartphone.InstalarAplicativo("YouTube");
}