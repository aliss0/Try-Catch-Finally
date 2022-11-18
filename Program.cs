using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            // www.patika.dev
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı =" + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Hata :" + ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("İŞlem tamamlandı");
            }

            try {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");



            }

            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değill...");
                Console.WriteLine(ex);
            }
            catch (OverflowException  ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bi değer girdiniz..");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı...");
            }




            Console.ReadLine();

        }
    }
}
