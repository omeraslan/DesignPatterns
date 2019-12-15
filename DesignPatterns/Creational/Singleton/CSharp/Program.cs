using System;
using CSharp;

namespace Singleton {
    class Program {
        static void Main (string[] args) {

            //Bu nesneyi programın neresinden çağırırsak çağıralım sadece bir tane oluştuğuna emin olduk.
            var logger = Logger.GetLogger();

            logger.WriteMessage ("Singleton tasarım deseni log örneği");

            Console.WriteLine("Log başarıyla yazıldı");
        }
    }
}