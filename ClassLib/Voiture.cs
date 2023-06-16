using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{

    public class Voiture
    {
        public string Marque { get; private set; }
        public string Modele { get; private set; }
        public double Vitesse { get; private set; }
        public bool estDemarree { get; private set; }


        public Voiture(string p_marque, string p_modele)
        {
            if (p_marque == string.Empty || p_modele == string.Empty)
            {
                throw new VoitureNullException("La marque et le modele ne peuvent pas etre null/vide");
            }
            this.Marque = p_marque;
            this.Modele = p_modele;
        }

        public void Demarrer()
        {
            if (estDemarree == true)
            {
                throw new VoitureDemarreException("La voiture est deja demarree");
            }
            estDemarree = true;
        }

        public void Arreter()
        {
            if (estDemarree == false)
            {
                throw new VoitureArreteeException("La voiture est deja arreter");
            }
            if (Vitesse > 5)
            {
                throw new VoitureArreteeException("La voiture roulee trop vite pour pouvoir arreter");
            }
            estDemarree = false;
            Vitesse = 0;
        }

        public void Accelerer(double vitesseGagnee)
        {
            if (!estDemarree)
            {
                throw new VoitureAccelererException("La voiture ne peut pas accelerer si elle n'est pas demarrer");
            }
            if (Vitesse == 230)
            {
                throw new VoitureAccelererException("Vitesse maximum atteind");
            }
            if (Vitesse + vitesseGagnee > 230)
            {
                throw new VoitureAccelererException("Vous ne pouvez pas depasser 230");
            }
            Vitesse += vitesseGagnee;
        }

        public void Freiner(double vitessePerdu)
        {
            if (!estDemarree)
            {
                throw new VoitureFreinerException("La voiture n'est pas demarrer, donc freiner n'est pas utile");
            }
            if (Vitesse == 0)
            {
                throw new VoitureFreinerException("La voiture est deja a 0");
            }
            if (Vitesse - vitessePerdu < 0)
            {
                throw new VoitureFreinerException("Vous ne pouvez pas mettre la vitesse < 0");
            }
            Vitesse -= vitessePerdu;
        }

        public override string ToString()
        {
            string etat = "";

            if (estDemarree == true)
            {
                etat = "est demarree";
            }
            else { etat = "n'est pas demarree"; }

            return @$"
            Marque: {Marque}
            Modele: {Modele}
            Vitesse: {Vitesse}
            Etat: {etat}";
        }

    }
}