const apiBaseUrl = "https://localhost:7128/School";

async function berechneSumme() {
  let zahl1 = document.getElementById("zahl1").value;
  let zahl2 = document.getElementById("zahl2").value;

  let daten = {
    Ausgangszahl: parseInt(zahl1),
    Summant: parseInt(zahl2),
  };

  try {
    let response = await fetch("https://localhost:7128/api/nummern/Summe", {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(daten),
    });

    if (!response.ok) {
      throw new Error("Serverfehler!");
    }

    let result = await response.json();
    document.getElementById("ergebnis").textContent = result.summe;
  } catch (error) {
    console.error("Fehler:", error);
  }
}

async function ladeSchueler() {
  try {
    let response = await fetch(`${apiBaseUrl}/AlleSchueler`);
    if (!response.ok) throw new Error("Fehler beim Laden der Schüler");

    let schueler = await response.json();
    let liste = document.getElementById("schuelerListe");
    liste.innerHTML = "";

    schueler.forEach((s) => {
      let li = document.createElement("li");
      li.textContent = `${s.name}, Geburtsdatum: ${s.geburtsdatum}, Geschlecht: ${s.geschlecht}, Klasse: ${s.schulklasse}`;
      liste.appendChild(li);
    });
  } catch (error) {
    console.error("Fehler:", error);
  }
}

async function addSchueler() {
  let name = document.getElementById("name").value;
  let geburtsdatum = document.getElementById("geburtsdatum").value;
  let geschlecht = document.getElementById("geschlecht").value;
  let schulklasse = document.getElementById("klasse").value;

  let neuerSchueler = { name, geburtsdatum, geschlecht, schulklasse };

  try {
    let response = await fetch(`${apiBaseUrl}/AddSchueler`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(neuerSchueler),
    });

    if (!response.ok) throw new Error("Fehler beim Hinzufügen");

    ladeSchueler();
  } catch (error) {
    console.error("Fehler:", error);
  }
}

async function ladeDurchschnittsalter() {
  try {
    let response = await fetch(`${apiBaseUrl}/Durchschnittsalter`);
    if (!response.ok)
      throw new Error("Fehler beim Laden des Durchschnittsalters");

    let alter = await response.json();
    document.getElementById(
      "durchschnittsalter"
    ).textContent = `Durchschnittsalter: ${alter.toFixed(2)} Jahre`;
  } catch (error) {
    console.error("Fehler:", error);
  }
}

async function ladeGeschlecht() {
  try {
    let response = await fetch(`${apiBaseUrl}/Geschlecht`);
    if (!response.ok)
      throw new Error("Fehler beim Laden der Geschlechter-Statistik");

    let geschlechtData = await response.json();
    document.getElementById(
      "geschlechtStatistik"
    ).textContent = `Männlich: ${geschlechtData.m}, Weiblich: ${geschlechtData.w}`;
  } catch (error) {
    console.error("Fehler:", error);
  }
}
