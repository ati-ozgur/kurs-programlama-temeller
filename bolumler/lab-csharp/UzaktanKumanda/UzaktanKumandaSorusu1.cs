namespace lab.csharp.UzaktanKumanda;

public class UzaktanKumandaSorusu1
{
    int Deger = 5;
    public static void Main1()
    {
        UzaktanKumandaSorusu1[] dizi = new UzaktanKumandaSorusu1[5];
        int x = 0;
        while(x < 3)
        {
            dizi[x] = new UzaktanKumandaSorusu1();
            dizi[x].Deger = x;
            x = x + 1;
        }
        
        dizi[3] = dizi[1];
        dizi[4] = dizi[1];
        dizi[3] = null;
        dizi[4] = dizi[0];
        dizi[0] = dizi[3];
        dizi[3] = dizi[2];
        dizi[2] = dizi[0];
        
        for(int i=0;i<dizi.Length;i++)
        {
            UzaktanKumandaSorusu1 a = dizi[i];
            if (a == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(a.Deger);
            }
        }
        
    }
}
