using ClassLib;
using System;
using System.IO;
internal class Program
{
    public static void Main(string[] args)
    {
        // string Test = "C:/Test.txt";
        // ManipulationFichier TestFichier = new ManipulationFichier();

        // try
        // {
        //     TestFichier.LectureFichier(Test);
        // }
        // catch (FichierNonTrouverException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // Matrices TestMatrice = new Matrices(3,3);

        // for (int i = 0; i < TestMatrice.NombreDeLignes; i++)
        // {
        //     for (int y = 0; y < TestMatrice.NombreDeColonnes; y++)
        //     {
        //         TestMatrice.m_donnees[i,y] = new Random().NextInt64(1,10);
        //     }
        // }
        // System.Console.WriteLine(TestMatrice.ToString());
        // System.Console.WriteLine("\n");

        // double[,] array2d = {{1,1,1},{2,2,2},{1,1,1}};
        // double[,] array2d2 = {{2,2,2},{1,1,1},{2,2,2}};

        // Matrices TestMatrice2 = new Matrices(array2d);
        // Matrices TestMatrice3 = new Matrices(array2d2);

        // System.Console.WriteLine(TestMatrice2.ToString());
        // System.Console.WriteLine(TestMatrice3.ToString());

        // Matrices TestMatrice4 = TestMatrice2 * TestMatrice3;

        // System.Console.WriteLine(TestMatrice4);

        double[,] tableauTranpose = {{1,2,1},{2,1,2}};
        Matrices matriceATranposer = new Matrices(tableauTranpose);
        double[,] tableauAttendu = {{1,2},{2,1},{1,2}};

        Matrices matriceRecepteur = Matrices.Transpose(matriceATranposer);
        Matrices matriceAttendu = new Matrices(tableauAttendu);

        System.Console.WriteLine(matriceATranposer.ToString());
        System.Console.WriteLine(matriceAttendu.ToString());
        System.Console.WriteLine(matriceRecepteur.ToString());
       
    }

    
}