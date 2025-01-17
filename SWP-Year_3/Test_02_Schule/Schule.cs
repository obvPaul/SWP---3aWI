using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02_Schule
{
    public class Schule 
    {
        public List<Schueler> SchuelerListe = new List<Schueler>();
        public List<Klassenraum> KlassenraumListe = new List<Klassenraum>();
        public void SchuelerHinzufuegen(Schueler Schueler)
        {
            SchuelerListe.Add(Schueler);
        }
        public void KlassenraumHinzufuegen(Klassenraum raum)
        {
            KlassenraumListe.Add(raum);
        }
        //Methoden nach 3)
        public int AnzahlDerSchueler()
        {
            return SchuelerListe.Count;
        }
        public int AnzahlSchuelerNachGeschlecht(string geschlecht)
        {
            int count = 0;
            foreach (var Schueler in SchuelerListe)
            {
                if (Schueler.Geschlecht.Equals(geschlecht, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }
        public double Durchschnittsalter()
        {
            double SummeAlter = 0;
            int AnzahlSchueler = SchuelerListe.Count;
            foreach (var Schueler in SchuelerListe)
            {
                SummeAlter += (DateTime.Today - Schueler.Geburtsdatum).Days / 365.25;
            }
            return SummeAlter / AnzahlSchueler;
        }
        public List<Klassenraum> RaeumeMitCynap()
        {
            List<Klassenraum> RaeumeMitCynap = new List<Klassenraum>();
            foreach (var Raum in KlassenraumListe)
            {
                if (Raum.Cynap)
                {
                    RaeumeMitCynap.Add(Raum);
                }
            }
            return RaeumeMitCynap;
        }
        //Methoden nach 4)
        public int AnzahlDerKlassen()
        {
            return SchuelerListe.Select(s => s.Schulklasse).Distinct().Count();
        }
        public Dictionary<string, int> KlassenMitAnzahlDerSchueler()
        {
            return SchuelerListe.GroupBy(s => s.Schulklasse)
                               .ToDictionary(g => g.Key, g => g.Count());
        }
        public double FrauenanteilInKlasse(string klasse)
        {
            var schuelerInKlasse = SchuelerListe.Where(s => s.Schulklasse == klasse).ToList();
            if (schuelerInKlasse.Count == 0) return 0;

            int anzahlFrauen = schuelerInKlasse.Count(s => s.Geschlecht.Equals("Weiblich", StringComparison.OrdinalIgnoreCase));
            return (anzahlFrauen / (double)schuelerInKlasse.Count) * 100;
        }
        public bool KannUnterrichtetWerden(string Klasse, Klassenraum Raum)
        {
            int AnzahlSchuelerInKlasse = 0;
            foreach (var Schueler in SchuelerListe)
            {
                if (Schueler.Schulklasse.Equals(Schueler.Schulklasse, StringComparison.OrdinalIgnoreCase))
                {
                    AnzahlSchuelerInKlasse++;
                }
            }
            return AnzahlSchuelerInKlasse <= Raum.AnzahlPlaetze;
        }
        public double AnteilFrauen()
        {
            if (SchuelerListe.Count == 0) return 0;

            return (SchuelerListe.Where(s => s.Geschlecht == "Weiblich").Count() / 
                (double)SchuelerListe.Count()) * 100;
        }

    }
}
