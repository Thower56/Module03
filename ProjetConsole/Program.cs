using ClassLib;
using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string Test = "C:/Test.txt";
        ManipulationFichier TestFichier = new ManipulationFichier();

        try
        {
            TestFichier.LectureFichier(Test);
        }
        catch (FichierNonTrouverException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

    
}