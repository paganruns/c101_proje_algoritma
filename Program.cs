class Program
{
    static void Main(string[] args)
    {
       a1: Console.WriteLine("Bir string ifade bir de sayı (aralarında virgül ile) girişi yapınız: ");

        try
        {
            string giris = Console.ReadLine();
            string[] Kelime = giris.Split(',');

            string text = Kelime[0];
            int sayi = int.Parse(Kelime[1]);

            for (int i = 0; i < text.Length; i++)
            {
                if (i == sayi)
                {
                    continue;
                }
                Console.Write(text[i]);

            }
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine("Hata oluştu!");
            goto a1;
        }
    }
}
