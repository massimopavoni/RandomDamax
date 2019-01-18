public class Classe
{
    public long IdClasse { get; private set; }
    public byte Anno { get; private set; }
    public char Sezione { get; private set; }
    public string Indirizzo { get; private set; }

    public Classe(long idClasse, byte anno, char sezione, string indirizzo)
    {
        IdClasse = idClasse;
        Anno = anno;
        Sezione = sezione;
        Indirizzo = indirizzo;
    }
}
