// See https://aka.ms/new-console-template for more information

double[] fiyat = new double[5];
double[] kdv = new double[5];
double toplamfiyat = 0;
double toplamkdv = 0;
double uygkdv = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write((i+1)+". ürünün fiyatı : ");
    fiyat[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Uygulanacak KDV : ");
    uygkdv = Convert.ToDouble(Console.ReadLine());

    kdv[i] = (fiyat[i] * uygkdv) / 100;

    Console.WriteLine((i+1)+". ürünün fiyatı " + fiyat[i] + " TL. KDV'si " + kdv[i]+" TL'dir.\n");

    toplamfiyat += fiyat[i];
    toplamkdv += kdv[i];

}

Console.WriteLine("\nToplam fiyat : "+(toplamfiyat + toplamkdv) + "\nToplam KDV:" + toplamkdv);

Console.ReadKey();


