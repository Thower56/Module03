using System.IO;

namespace ClassLib;
public class ManipulationFichier
{
    public void LectureFichier(string p_stream)
        {
            try
            {
                using (StreamReader sr = new StreamReader(p_stream))
                {
                    while (!sr.EndOfStream)
                    {
                        string lingeActuelleDuFichier = sr.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new FichierNonTrouverException("Fichier Non Trouve");
            }
            
        }

    
}
