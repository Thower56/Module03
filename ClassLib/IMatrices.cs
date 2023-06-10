using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IMatrices
    {
        Matrices Identite(int p_ligne, int p_colonnes);
        Matrices Transpose(Matrices p_matrix);
    }
}