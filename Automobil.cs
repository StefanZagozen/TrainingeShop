public class Automobil
{
    private string marke;
    private string modell;
    private int baujahr;
    private string farbe;
    private int kilometerstand;

    public Automobil(string marke, string modell, int baujahr, string farbe, int kilometerstand)
    {
        this.marke = marke;
        this.modell = modell;
        this.baujahr = baujahr;
        this.farbe = farbe;
        this.kilometerstand = kilometerstand;
    }

    public void Fahren(int kilometer)
    {
        kilometerstand += kilometer;
        // Logik zum Fahren kann hier ergänzt werden
    }

    public void Bremsen()
    {
        // Logik zum Bremsen kann hier ergänzt werden
    }

    public void Tanken()
    {
        // Logik zum Tanken kann hier ergänzt werden
    }

    // Optional: Getter-Methoden für die Attribute
    public string GetMarke() => marke;
    public string GetModell() => modell;
    public int GetBaujahr() => baujahr;
    public string GetFarbe() => farbe;
    public int GetKilometerstand() => kilometerstand;
}