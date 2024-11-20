using PalinkaSZK;

List<Palinka> palinkaList = [];
string[] fruit = ["szilva", "barack", "dió", "körte", "meggy","alma","narancs","cseresznye","füge"];

for (int i = 0; i < 20; i++)
{
    palinkaList.Add(new(
        alkoholFok: Random.Shared.Next(30, 88),
        gyumolcs: fruit[Random.Shared.Next(fruit.Length)],
        mennyiseg: Random.Shared.Next(1, 51),
        keszitesEv: Random.Shared.Next(2000, DateTime.Now.Year + 1),
        alkoholAr: Random.Shared.Next(50,1001)));
};

var mennyisegLiter = palinkaList.Sum(x => (double)x.Mennyiseg / 10);
Console.WriteLine($"Összesen {mennyisegLiter:00.0} liter pálinka van!\n\n");

int vegsoAr = 0;

for (int i = 0; i < 50; i++)
{
    int szamlal = i + 1;
    var randomPalinka = palinkaList[Random.Shared.Next(palinkaList.Count)];
    var mennyisegFele = randomPalinka.Mennyiseg / 2;
    var teljesAr = mennyisegFele * randomPalinka.AlkoholAr;
    
    vegsoAr += teljesAr;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"PÁLINKA COUNT: {szamlal}");
    Console.ResetColor();
    Console.WriteLine($"{randomPalinka}Ennyit iszol: {mennyisegFele} deciliter\nTeljes ár: {teljesAr} forint\n\n");
}

Console.WriteLine($"\nEz összesen: {vegsoAr} forint!");
    
