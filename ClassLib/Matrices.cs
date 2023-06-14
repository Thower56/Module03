using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Matrices
    {
        public double[,] m_donnees {get; private set; }

        public int NombreDeLignes { get {return m_donnees.GetLength(0);} }
        public int NombreDeColonnes { get {return m_donnees.GetLength(1);} }

        public Matrices(int p_ligne, int p_colonnes)
        {
            m_donnees = new double[p_ligne, p_colonnes];
        }

        public Matrices(double[,] p_tableau)
        {
            if(p_tableau is null)
            {
                throw new MatricesCtorParameterNullException("Le parametre ne peut pas etre null");
            }
            if(p_tableau.GetLength(0) <= 0 || p_tableau.GetLength(1) <= 0)
            {
                throw new MatricesCtorParameterArgumentException("Le tableau doit etre de 2D pas de 0 et <");
            }

            m_donnees = new double[p_tableau.GetLength(0),p_tableau.GetLength(1)];
            for (int i = 0; i < p_tableau.GetLength(0); i++)
            {
                for (int j = 0; j < p_tableau.GetLength(1); j++)
                {
                    this.m_donnees[i,j] = p_tableau[i,j];
                }
            }
        }

        public static Matrices Identite(int p_ligne, int p_colonnes)
        {
            if(p_ligne <= 0 || p_colonnes <= 0)
            {
                throw new MatriceIdentiteArgumentException("Les parametres doit etre > 0");
            }

            Matrices m_identite = new Matrices(p_ligne, p_colonnes);

            for(int i = 0; i < p_ligne; i++)
            {
                for(int j = 0; j < p_colonnes; j++)
                {
                    if(i == j)
                    {
                        m_identite.m_donnees[i,j] = 1;
                    }
                    else
                    {
                        m_identite.m_donnees[i,j] = 0;
                    }
                }
            }
            return m_identite;
        }

        public static Matrices Transpose(Matrices p_matrix)
        {
            if(p_matrix is null)
            {
                throw new MatriceTransposeNullArgumentsException("Vous ne pouvez pas transposez une Matrice Null");
            }

            Matrices m_transpose = new Matrices(p_matrix.NombreDeColonnes, p_matrix.NombreDeLignes);

            for (int i = 0; i < p_matrix.NombreDeColonnes; i++)
            {
                for (int j = 0; j < p_matrix.NombreDeLignes; j++)
                {
                    m_transpose.m_donnees[i,j] = p_matrix.m_donnees[j,i];
                }
            }
            return m_transpose;
        }


        public static Matrices operator +(Matrices a, Matrices b)
        {
            if(a == null || b == null)
            {
                throw new MatriceNullException("Les matrices en parametre ne peuvent pas etre null");
            }
            if(a.NombreDeColonnes != b.NombreDeColonnes || a.NombreDeLignes != b.NombreDeLignes)
            {
                throw new MatriceDimensionIncompatibleException("Les Matrices doivent etre de meme dimension");
            }
            Matrices resultat = new Matrices(a.NombreDeLignes, a.NombreDeColonnes);

            for (int i = 0; i < a.NombreDeLignes; i++)
            {
                for (int j = 0; j < a.NombreDeColonnes; j++)
                {
                    resultat.m_donnees[i,j] = a.m_donnees[i,j] + b.m_donnees[i,j];
                }
            }

            return resultat;
        }

        public static Matrices operator -(Matrices a, Matrices b)
        {
            if(a == null || b == null)
            {
                throw new MatriceNullException("Les matrices en parametre ne peuvent pas etre null");
            }
            if(a.NombreDeColonnes != b.NombreDeColonnes || a.NombreDeLignes != b.NombreDeLignes)
            {
                throw new MatriceDimensionIncompatibleException("Les Matrices doivent etre de meme dimension");
            }
            
            Matrices resultat = new Matrices(a.NombreDeLignes, a.NombreDeColonnes);

            for (int i = 0; i < a.NombreDeLignes; i++)
            {
                for (int j = 0; j < a.NombreDeColonnes; j++)
                {
                    resultat.m_donnees[i,j] = a.m_donnees[i,j] - b.m_donnees[i,j];
                }
            }

            return resultat;
        }

        public static Matrices operator *(Matrices a, Matrices b)
        {
            if(a.NombreDeColonnes < b.NombreDeLignes)
            {
                throw new MatriceDimensionIncompatibleException("Les Matrices doivent etre de meme dimension");
            }
            if(a is null || b is null)
            {
                throw new MatriceNullException("Les matrices en parametre ne peuvent pas etre null");
            }

            Matrices resultat = new Matrices(a.NombreDeLignes, b.NombreDeColonnes);

            for (int i = 0; i < a.NombreDeLignes; i++)
            {
                for (int j = 0; j < b.NombreDeColonnes; j++)
                {
                    for (int k = 0; k < b.NombreDeLignes; k++)
                    {
                        resultat.m_donnees[i,j] += a.m_donnees[i,k] * b.m_donnees[k,i];
                    }
                    
                }
            }

            return resultat;
        }

        public static Matrices operator *(Matrices a, int b)
        {
            if(a is null)
            {
                throw new MatriceNullException("La matrice ne peut pas etre null");
            }
            
            Matrices resultat = new Matrices(a.NombreDeLignes, a.NombreDeColonnes);

            for (int i = 0; i < a.NombreDeLignes; i++)
            {
                for (int j = 0; j < a.NombreDeColonnes; j++)
                {
                    resultat.m_donnees[i,j] = a.m_donnees[i,j] * b;
                }
            }

            return resultat;
        }

        public override bool Equals(object? obj)
        {
            if((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Matrices m = (Matrices) obj;
            if(m.NombreDeLignes != this.NombreDeLignes || m.NombreDeColonnes != this.NombreDeColonnes)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.NombreDeLignes; i++)
                {
                    for (int j = 0; j < this.NombreDeColonnes; j++)
                    {
                        if(m.m_donnees[i,j] != this.m_donnees[i,j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string matrice = "";
            for(int i = 0; i < this.NombreDeLignes; i++)
            {
                matrice += $"[";
                for(int j = 0; j < this.NombreDeColonnes; j++)
                {
                    if(j == (this.NombreDeColonnes-1))
                    {
                        matrice += $"{this.m_donnees[i,j]}";
                    }
                    else
                    {
                        matrice += $"{this.m_donnees[i,j]}, ";
                    }
                    
                }
                matrice += $"]\n";
            }

            return matrice;
        }

    
    }
}