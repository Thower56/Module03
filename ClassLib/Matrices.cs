using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Matrices : IMatrices
    {
        public double[,] m_matrice {get; private set; }

        public int NombreDeLignes { get {return m_matrice.GetLength(0);} }
        public int NombreDeColonnes { get {return m_matrice.GetLength(1);} }

        public Matrices(int p_ligne, int p_colonnes)
        {
            m_matrice = new double[p_ligne, p_colonnes];
        }

        public Matrices Identite(int p_ligne, int p_colonnes)
        {
            throw new NotImplementedException();
        }

        public Matrices Transpose(Matrices p_matrix)
        {

            for (int i = 0; i < p_matrix.NombreDeColonnes; i++)
            {
                for (int j = 0; j < p_matrix.NombreDeColonnes; j++)
                {
                    p_matrix[][]
                }
            }
            return
        }

    
    }
}