namespace test;
using Moq;
using ClassLib;
public class UnitTest1
{
    [Fact]
    public void TestCtor_VoitureParametreNull_VoitureNullException()
    {
        Voiture voiture;

        Assert.Throws<VoitureNullException>(()=>voiture = new Voiture("",""));
    }

    [Fact]

    public void TestDemerrer_VoitureDejaDemarrerEtOnDemarre_VoitureDemarreException()
    {
        Voiture voiture = new Voiture("Test","Test");

        voiture.Demarrer();

        Assert.Throws<VoitureDemarreException>(()=>voiture.Demarrer());
    }

    [Fact]
    public void TestArreter_VoitureEstArreterEtOnArrete_VoitureArreteeException()
    {
        Voiture voiture = new Voiture("Test","Test");

        Assert.Throws<VoitureArreteeException>(()=>voiture.Arreter());
    }

    [Fact]

    public void TestArreter_VoitureRouleEstOnLArrete_VoitureArreteeException()
    {
        Voiture voiture = new Voiture("Test","Test");
        voiture.Accelerer(10);

        Assert.Throws<VoitureArreteeException>(()=>voiture.Arreter());
    }

    [Fact]

    public void TestAccelerer_VoitureNonDemarrerEtOnAccelere_VoitureAccelererException()
    {
        Voiture voiture = new Voiture("Test","Test");

        Assert.Throws<VoitureArreteeException>(()=>voiture.Accelerer(50));
    }

    [Fact]

    public void TestAccelerer_VoitureDejaVitesseMaximum_VoitureAccelererException()
    {
        Voiture voiture = new Voiture("Test","Test");
        voiture.Accelerer(230);

        Assert.Throws<VoitureAccelererException>(()=>voiture.Accelerer(1));
    }

    [Fact]

    public void TestAccelerer_VoitureTropAccelererEtDepasserLaVitesseMax_VoitureAccelererException()
    {
        Voiture voiture = new Voiture("Test","Test");
        voiture.Accelerer(220);

        Assert.Throws<VoitureAccelererException>(()=>voiture.Accelerer(50));
    }

    [Fact]

    public void TestFreiner_VoitureNestPasDemarrer_VoitureFreinerException()
    {
        Voiture voiture = new Voiture("Test","Test");

        
    }
}