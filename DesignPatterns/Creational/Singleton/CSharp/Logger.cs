using System.IO;

namespace CSharp {
    public class Logger {
        //Static değişkenimiz 
        private static Logger _logger;

        //Log'u yazacağımız dosya ismi
        private static string _logFileName = "Logs.txt";

        //Kilitleme (Lock) objemiz
        private static readonly object _lock = new object ();

        private Logger () {

        }

        public static Logger GetLogger () { // İki aşamalı güvenlik ilkinde objemiz null mı diye kontrol ediyoruz
            if (_logger == null) {
                lock (_lock) // Bu aşamada kitliyoruz ve başka iş parçacığının (thread) gelmesini engelliyoruz
                {
                    if (_logger == null) {
                        _logger = new Logger ();
                    }
                }
            }

            return _logger;
        }

        public void WriteMessage (string message) {
            using (StreamWriter writer = System.IO.File.AppendText (_logFileName)) {
                writer.WriteLine (message);
            }
        }
    }
}