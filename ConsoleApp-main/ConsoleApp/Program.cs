namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            reader.ImportAndPrintData("data.csv");
        }
    }
}

//1.nazwa pliku błędna
//2. pole Name w klasie ImportedObject występuje też w klasie nadrzędnej - niejednoznaczne
//3. różnie pisane własciwości klas get, set
//4. streamReader jest nie zwonlniony z użytkowania (można użyć using albo dispose na końcu
//5. można dodać obsługę wyjątków
//6.zabezpieczenie przed błędnymi danymi w pliku, na szybko zastosowana opcja z ?
//7. Z metody ImportAndPrintData trzeba wydzielić inne funkcje, bo zawiera 4 funkcje. Przy wydzieleniu funkcji byłby czytelniejszy kod.