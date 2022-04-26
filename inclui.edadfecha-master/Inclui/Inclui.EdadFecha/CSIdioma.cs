using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclui.edadfecha
{
    class CSIdiomas
    {
        public static string[] ReadDataFromFile(string fileName)
        {
            string[] fileLines = new string[0];
            
            try
            {
                StreamReader inputFile = new StreamReader(fileName);           //Cambio
                while (!inputFile.EndOfStream)
                {
                    Array.Resize(ref fileLines, fileLines.Length + 1);
                    fileLines[fileLines.Length - 1] = inputFile.ReadLine();
                }
                inputFile.Close();
                if (fileLines.Length == 0)
                {
                    Console.WriteLine("Fichero vacío. Debe tener información para poder usarlo.");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Array.Resize(ref fileLines, 0);
            }
            return (fileLines);
        }
    }
}
