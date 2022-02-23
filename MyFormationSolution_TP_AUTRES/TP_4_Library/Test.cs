namespace TP_4_Library {

    using System;
    using System.IO;
    
    public class Test {
        private void Dummy() {
            using (StreamReader streamReader = new StreamReader(@"C:\myFile.txt")) {
                string currentLine;
                while ((currentLine = streamReader.ReadLine()) != null) {
                    Console.WriteLine(currentLine);
                }
            }
        }
    }
}
