public class Merenda
{
    public long IdMerenda { get; private set; }
    public string Nome { get; private set; }
    public string Variante { get; private set; }
    public TipoMerenda Tipo { get; private set; }
    public decimal CostoUnitario { get; private set; }
    public short Disponibilita { get; private set; }

    public Merenda(string nome, string variante, TipoMerenda tipo, decimal costoUnitario, short disponibilita, long? idMerenda = null)
    {
        Nome = nome;
        Variante = variante;
        Tipo = tipo;
        CostoUnitario = costoUnitario;
        Disponibilita = disponibilita;
        if(idMerenda != null) IdMerenda = (long)idMerenda;
    }
}
