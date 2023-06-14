namespace Test;
using ClassLib;

public class UnitTest1
{
    [Fact]
    public void TestMatriceTableauNullException()
    {
        double[,] tableauNull = null;

        Matrices matrices;

        Assert.Throws<MatricesCtorParameterNullException>(() => matrices = new Matrices(tableauNull));
    }

    [Fact]
    public void TestMatriceTableauDeZero()
    {
        double[,] tableauNull = new double[0,0];

        Matrices matrices;

        Assert.Throws<MatricesCtorParameterArgumentException>(() => matrices = new Matrices(tableauNull));
    }

    [Fact]

    public void TestMatriceIdentiteLigneZero()
    {
        int p_ligne = 0;
        int p_colonnes = 2;
        Matrices matrice;
        Assert.Throws<MatriceIdentiteArgumentException>(()=> matrice = Matrices.Identite(p_ligne, p_colonnes));
    }

    [Fact]

    public void TestMatriceIdentiteColonneZero()
    {
        int p_ligne = 2;
        int p_colonnes = 0;
        Matrices matrice;
        Assert.Throws<MatriceIdentiteArgumentException>(()=> matrice = Matrices.Identite(p_ligne, p_colonnes));
    }

    [Fact]

    public void TestMatriceTransposeMatriceVide()
    {
        Matrices matricesNull = null;
        Matrices matriceTranposer;

        Assert.Throws<MatriceTransposeNullArgumentsException>(()=> matriceTranposer = Matrices.Transpose(matricesNull));
    }

    [Fact]
    public void TestMatricePlusMatriceColonneNonEgal()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = new Matrices(2,3);

        Assert.Throws<MatriceDimensionIncompatibleException>(()=> matrice + matrice2);
    }

    [Fact]
    public void TestMatricePlusMatriceLigneNonEgal()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = new Matrices(3,2);

        Assert.Throws<MatriceDimensionIncompatibleException>(()=> matrice + matrice2);
    }

    [Fact]
    public void TestMatriceMoinMatriceColonneNonEgal()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = new Matrices(2,3);

        Assert.Throws<MatriceDimensionIncompatibleException>(()=> matrice - matrice2);
    }

    [Fact]
    public void TestMatriceMoinMatriceLigneNonEgal()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = new Matrices(3,2);

        Assert.Throws<MatriceDimensionIncompatibleException>(()=> matrice - matrice2);
    }

    [Fact]
    public void TestMatriceMoinMatriceNull()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = null;

        Assert.Throws<MatriceNullException>(()=> matrice - matrice2);
    }

    [Fact]
    public void TestMatricePlusMatriceNull()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = null;

        Assert.Throws<MatriceNullException>(()=> matrice + matrice2);
    }

    [Fact]
    public void TestMatriceFoisMatriceColonneEtLigneNonEgal()
    {
        Matrices matrice = new Matrices(2,2);
        Matrices matrice2 = new Matrices(3,3);

        Assert.Throws<MatriceDimensionIncompatibleException>(()=> matrice * matrice2);
    }

    [Fact]

    public void TestMatriceIdentite()
    {
        Matrices matriceRecepteur;
        double[,] tableauIdentite = {{1,0},{0,1}};

        matriceRecepteur = Matrices.Identite(2,2);
        Matrices matriceAttendu = new Matrices(tableauIdentite);

        Assert.True(matriceAttendu.Equals(matriceRecepteur));
    }

    [Fact]

    public void TestMatriceTranpose()
    {
        double[,] tableauTranpose = {{1,2,1},{2,1,2}};
        Matrices matriceATranposer = new Matrices(tableauTranpose);
        double[,] tableauAttendu = {{1,2},{2,1},{1,2}};

        Matrices matriceRecepteur = Matrices.Transpose(matriceATranposer);
        Matrices matriceAttendu = new Matrices(tableauAttendu);

        Assert.True(matriceAttendu.Equals(matriceRecepteur));
    }

    [Fact]

    public void TestMatricePlusMatrice()
    {
        double[,] tableau1 = {{1,2,1},{2,1,2}};
        double[,] tableau2 = {{2,1,2},{1,2,1}};
        double[,] tableauAttendu = {{3,3,3},{3,3,3}};
        Matrices matrice1 = new Matrices(tableau1);
        Matrices matrice2 = new Matrices(tableau2);

        Matrices matriceAttendu = new Matrices(tableauAttendu);

        Assert.Equal(matriceAttendu , matrice1+matrice2);
    }

    [Fact]

    public void TestMatriceMoinMatrice()
    {
        double[,] tableau1 = {{2,2,2},{2,2,2}};
        double[,] tableau2 = {{2,2,2},{2,2,2}};
        double[,] tableauAttendu = {{0,0,0},{0,0,0}};
        Matrices matrice1 = new Matrices(tableau1);
        Matrices matrice2 = new Matrices(tableau2);

        Matrices matriceAttendu = new Matrices(tableauAttendu);

        Assert.Equal(matriceAttendu , matrice1-matrice2);
    }

    [Fact]

    public void TestMatriceFoisMatrice()
    {
        double[,] tableau1 = {{1,1},{1,1},{1,1}};
        double[,] tableau2 = {{2,2,2},{2,2,2}};
        double[,] tableauAttendu = {{4,4,4},{4,4,4},{4,4,4}};
        Matrices matrice1 = new Matrices(tableau1);
        Matrices matrice2 = new Matrices(tableau2);

        Matrices matriceAttendu = new Matrices(tableauAttendu);

        Assert.Equal(matriceAttendu , matrice1*matrice2);
    }

    [Fact]

    public void TestMatriceFoisEntier()
    {
        double[,] tableau1 = {{2,2,2},{2,2,2}};
        double[,] tableauAttendu = {{4,4,4},{4,4,4}};
        Matrices matrice1 = new Matrices(tableau1);

        Matrices matriceAttendu = new Matrices(tableauAttendu);

        Assert.Equal(matriceAttendu , matrice1*2);
    }

}