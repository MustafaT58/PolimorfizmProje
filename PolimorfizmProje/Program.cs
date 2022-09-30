// See https://aka.ms/new-console-template for more information
using PolimorfizmProje;

Console.WriteLine();



DikdortgenProfil dikdortgen=new DikdortgenProfil();
dikdortgen.Yukseklik = 3;
dikdortgen.KisaKenar = 4;
dikdortgen.UzunKenar = 5;
 
Console.WriteLine(
$"{DikdortgenProfil.SekilAd} nin Hacmi=  {dikdortgen.Hacim()} \n" +
$"{DikdortgenProfil.SekilAd} nin Firesi= {dikdortgen.Fire()}\n");

SlindirProfil SlindirProfil = new SlindirProfil();
SlindirProfil.Yukseklik = 3;
SlindirProfil.YariCap = 2;
Console.WriteLine(
$"{SlindirProfil.SekilAd} in Hacmi=  {SlindirProfil.Hacim()} \n" +
$"{SlindirProfil.SekilAd} in Firesi= {SlindirProfil.Fire()}\n");


KupProfil kupProfil = new KupProfil();
//KupProfil.SekilAd = "nsdfjksdjk";  Şekil adı constructer ile tanımalandı bu komut çalışırsa değiştirebiliriz.
kupProfil.KisaKenar = 4;
Console.WriteLine(
$"{KupProfil.SekilAd} ün Hacmi=  {kupProfil.Hacim()} \n" +
$"{KupProfil.SekilAd} ün Firesi= {kupProfil.Fire()} \n");

Console.ReadLine();
