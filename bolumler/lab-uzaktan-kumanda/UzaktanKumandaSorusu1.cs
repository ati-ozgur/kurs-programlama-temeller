public class Program
{
    int Deger = 5;
    public static void main()
    {
        Program[] dizi = new Program[5];
        int x = 0;
        while(x < 3)
        {
            dizi[x] = new Program();
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
        
        for(int i=0;i<dizi.length;i++)
        {
            Program a = dizi[i];
            if (a == null)
            {
                System.out.println("NULL");
            }
            else
            {
                System.out.println(a.Deger);
            }
        }
        
    }
}
