public class Program
{
    int Deger = 5;
    public static void main()
    {
        Program[] dizi = new Program[10];
        for(int i=0;i<dizi.Length;i++)
        {
            dizi[i] = new Program();
            dizi[i].Deger = i;
        }
        
        for(int i=1;i<dizi.Length;i = i+2)
        {
            dizi[i] = new Program();
            dizi[i].Deger = i * 2;
        }
        for(int i=2;i<dizi.Length;i = i+3)
        {
            dizi[i] = new Program();
            dizi[i].Deger = i * 3;
        }
        
        dizi[3] = dizi[7];
        dizi[6] = dizi[1];
        dizi[9] = dizi[3];
        dizi[2] = dizi[6];
        dizi[4] = dizi[9];
        
        for(int i=0;i<dizi.Length;i++)
        {
            Program a = dizi[i];
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
