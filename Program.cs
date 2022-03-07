using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Hataya sebebiyet verme ihtimali olan kod 
            {
                Console.WriteLine("Bir sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception ex) //Hata ile karşılaşıldığında ne yapılacağı buraya yazılır 
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally //Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız
            {
                Console.Write("İşlem tamamlandı.");
            }



            try
            {
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}