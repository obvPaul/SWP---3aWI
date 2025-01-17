using System;
using NUnit.Framework;
using Test_02_Schule;

namespace Test_02_Schule.Tests
{
    [TestFixture]
    public class SchuleTests
    {
        [Test]
        public void SchuelerHinzufuegen()
        {
            var schule = new Schule();
            var schueler = new Schueler { Name = "Onur", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 10, 15), Schulklasse = "3aWI" };

            schule.SchuelerHinzufuegen(schueler);

            Assert.AreEqual(1, schule.AnzahlDerSchueler());
        }

        [Test]
        public void SchuelerNachGeschlecht()
        {
            var schule = new Schule();
            var schueler1 = new Schueler { Name = "Onur", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 10, 15), Schulklasse = "3aWI" };
            var schueler2 = new Schueler { Name = "Maurice", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 12, 22), Schulklasse = "3aWI" };
            var schueler3 = new Schueler { Name = "Maylin", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 1, 3), Schulklasse = "1aMD" };
            var schueler4 = new Schueler { Name = "Sally", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 5, 18), Schulklasse = "1aMD" };
            schule.SchuelerHinzufuegen(schueler1);
            schule.SchuelerHinzufuegen(schueler2);
            schule.SchuelerHinzufuegen(schueler3);
            schule.SchuelerHinzufuegen(schueler4);

            var maennlicheSchueler = schule.AnzahlSchuelerNachGeschlecht("Männlich");
            var weiblicheSchueler = schule.AnzahlSchuelerNachGeschlecht("Weiblich");

            Assert.AreEqual(2, maennlicheSchueler);
            Assert.AreEqual(2, weiblicheSchueler);
        }

        [Test]
        public void Durchschnittsalter()
        {
            var schule = new Schule();
            var schueler1 = new Schueler { Name = "Onur", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 10, 15), Schulklasse = "3aWI" };
            var schueler2 = new Schueler { Name = "Maurice", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 12, 22), Schulklasse = "3aWI" };
            var schueler3 = new Schueler { Name = "Maylin", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 1, 3), Schulklasse = "1aMD" };
            var schueler4 = new Schueler { Name = "Sally", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 5, 18), Schulklasse = "1aMD" };
            schule.SchuelerHinzufuegen(schueler1);
            schule.SchuelerHinzufuegen(schueler2);
            schule.SchuelerHinzufuegen(schueler3);
            schule.SchuelerHinzufuegen(schueler4);

            double summeAlter = 0;
            int anzahlSchueler = schule.AnzahlDerSchueler();
            foreach (var schueler in schule.SchuelerListe)
            {
                summeAlter += (DateTime.Today - schueler.Geburtsdatum).Days / 365.25;
            }
            double erwartetesDurchschnittsalter = summeAlter / anzahlSchueler;

            Assert.AreEqual(erwartetesDurchschnittsalter, schule.Durchschnittsalter(), 0.1);
        }

        [Test]
        public void AnteilFrauen()
        {
            var schule = new Schule();
            var schueler1 = new Schueler { Name = "Onur", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 10, 15), Schulklasse = "3aWI" };
            var schueler2 = new Schueler { Name = "Maurice", Geschlecht = "Männlich", Geburtsdatum = new DateTime(2007, 12, 22), Schulklasse = "3aWI" };
            var schueler3 = new Schueler { Name = "Maylin", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 1, 3), Schulklasse = "1aMD" };
            var schueler4 = new Schueler { Name = "Sally", Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2010, 5, 18), Schulklasse = "1aMD" };
            schule.SchuelerHinzufuegen(schueler1);
            schule.SchuelerHinzufuegen(schueler2);
            schule.SchuelerHinzufuegen(schueler3);
            schule.SchuelerHinzufuegen(schueler4);

            double anteilFrauen = schule.AnteilFrauen();

            Assert.AreEqual(50.0, anteilFrauen, 0.1);
        }
    }
}
