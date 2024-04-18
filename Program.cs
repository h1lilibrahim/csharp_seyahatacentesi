Console.WriteLine("seyahat acentasına hoş geldiniz.");

Console.WriteLine("kaç kişi seyahat edeceksiniz?");
int kişi = Convert.ToInt32(Console.ReadLine());

if (kişi == 0 || kişi < 0)
{
    Console.WriteLine("hatalı kişi girdiniz 1'e çevrildi");
    kişi = 1;
}

Console.WriteLine("hangi şehire seyahat etmek istersiniz?\n chicago(200) için 1'e\n Los Angeles(360) için 2'ye\n Miami(320) için 3'e\n Orlando(310) için 4'e\n Seattle(330) için 5'e tıklayın");
int rezervasyon = Convert.ToInt32(Console.ReadLine());
double tutar= 0;
int seyahattutarı = 0; 
int uçak = 0;
int total = 0;
if (rezervasyon==1)
{
    tutar += 200;
    seyahattutarı+=200;
    uçak =seyahattutarı*kişi;
    total=seyahattutarı*  uçak;   
}
else if (rezervasyon==2)
{
    tutar += 360;
    seyahattutarı += 360;
    uçak =seyahattutarı*kişi;
    total=seyahattutarı*uçak;
}
else if (rezervasyon==3)
{   
    tutar += 320;
    seyahattutarı += 320;
    uçak =seyahattutarı*kişi;
    total = seyahattutarı*uçak;
}
else if (rezervasyon==4)
{
    tutar += 310;
    seyahattutarı+= 310;
    uçak =seyahattutarı*kişi;
    total = seyahattutarı*uçak;
}
else if (rezervasyon==5)
{
    tutar += 330;
    seyahattutarı+= 330;
    uçak =seyahattutarı*kişi;
    total = seyahattutarı*uçak;
}
else 
{
    Console.WriteLine("hatalı rezervasyon girdiniz");
}
double oteltutarı= 0;
Console.WriteLine("Paketinize oteli dahil etmek ister misiniz (E/H)?");
string tercih = Console.ReadLine();
if (tercih=="h" || tercih=="H")
{
    return;
}
else if (tercih=="e" || tercih=="E")
{
    Console.WriteLine("hangi otelde kalmak isterdsiniz?\n motel(49.99) için 1'e\n standart hotel için 2'ye(98.50)\n luxury hotel(199.75) için 3'e");
    int otel = Convert.ToInt32(Console.ReadLine());
    if (otel==1)
    {
        tutar += 49.99;
        oteltutarı += 49.99;
        
    }
    else if (otel==2)
    {
        tutar += 98.50;
        oteltutarı += 98.50;
    }
    else if (otel==3)
    {
        tutar += 199.75;
        oteltutarı += 199.75;
    }
    Console.WriteLine("kalmak istediğiniz oda numarasını girin:");
    int oda = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("kaç gece kalmayı düşünüyorsunuz");
    int gece = Convert.ToInt32(Console.ReadLine());
    
    
    
    if (oda==0 || oda < 0)
    {
        Console.WriteLine("hatalı oda numarası girdiniz oda numaranız 1");
        oda = 1;   
    }
        double odatutarı= 0;
        if (otel ==1)
        {
            odatutarı= oda * oteltutarı;
            tutar +=odatutarı;
        
        } 
        else if (otel==2)
        {
            odatutarı= oda * oteltutarı;
            tutar +=odatutarı;
        }
        else if (otel==3)
        {
             odatutarı= oda * oteltutarı;
            tutar += odatutarı;
        }
    

    if (gece == 0 || gece < 0)
    {
        Console.WriteLine("hatalı gece numarası girdiniz 1' çevrildi");
        gece = 1;
    }
    double toplamotel = odatutarı*gece;
System.Console.WriteLine("uçuş rezervasyonu fiyatı:"+total);
System.Console.WriteLine("otel rezervasyonu fiyat:"+toplamotel);
}
double toplam = tutar +uçak;
System.Console.WriteLine("toplam tutar:"+toplam);