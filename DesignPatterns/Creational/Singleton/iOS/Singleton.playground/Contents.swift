import UIKit
import XCTest

protocol Writable: class {
    func writeMessage(_ text: String)
}

final class Logger: Writable {
    
    //file name constructor ı
    private var _logFileName: String = "Log.txt"
    
    var fileName: String! {
        get {
            return _logFileName
        }
         
        set {
            _logFileName = newValue
        }
    }
    
    func writeMessage(_ text: String) {
        print("Log \(_logFileName) dosyasına yazıldı.")
    }
    
    //Burası class ın static instance ını aldığımız satır. Bunu aşağıda kullanacağız. Bu satır dışında başka şekillderde de static instance alınabilir.
    static let sharedInstance: Logger = Logger()
}

// Logger class ını burada bir kere örneğini aldık. Alınan bu instance ı projede istediğimiz yerde kullabiliriz.
let logger = Logger.sharedInstance

logger.fileName = "Test.txt"

logger.writeMessage("Test mesajı")


class LoggerTests: XCTestCase {

    var logger: Logger!
    
    func testLoggerInstance() {
        logger = Logger.sharedInstance
        XCTAssertTrue(logger != nil, "Logger singleton class ı oluşturuldu.")
    }

}

LoggerTests.defaultTestSuite.run()




