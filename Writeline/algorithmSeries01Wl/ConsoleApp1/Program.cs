using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {


        public void MyCustomWrite(string text)
        {
            Console.Write(text); // Write ön tanımlı metodunu kullanarak oluşturduğumuz string değeri ekrana yazdırıyoruz
            Console.Write('\n'); // Write ön tanımlı metodunu kullanarak alt satıra geçmek için \n değerini giriyoruz

        }
        static void Main(string[] args)
        {
            string text = "Bu bir örnek";

            Program program = new Program(); // Program sınıfının bir örneğini oluşturun
            program.MyCustomWrite(text); // Örneği kullanarak metodu çağırın
            program.MyCustomWrite(text);
        }


    }
}