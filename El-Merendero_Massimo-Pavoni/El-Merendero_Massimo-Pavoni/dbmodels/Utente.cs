public class Utente
{
    public long IdUtente { get; private set; }
    public string Username { get; private set; }
    public byte[] PasswordHash { get; private set; }
    public bool ElMerendero { get; private set; }
    public long ClasseDiAppartenenza { get; private set; }
    public long ClasseRappresentata { get; private set; }
    
    public Utente(long idUtente, string username, byte[] passwordHash, bool elMerendero, long classeDiAppartenenza, long classeRappresentata)
    {
        IdUtente = idUtente;
        Username = username;
        PasswordHash = passwordHash;
        ElMerendero = elMerendero;
        ClasseDiAppartenenza = classeDiAppartenenza;
        ClasseRappresentata = classeRappresentata;
    }
}
