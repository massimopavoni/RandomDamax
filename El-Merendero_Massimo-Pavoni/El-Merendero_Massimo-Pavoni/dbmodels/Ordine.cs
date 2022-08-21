using System;

public class Ordine
{
    public long IdOrdine { get; private set; }
    public long IdUtente { get; private set; }
    public long IdMerenda { get; private set; }
    public short Quantita { get; private set; }
    public DateTime DataRichiesta { get; private set; }
    public DateTime DataPagamento { get; private set; }

    public Ordine(long idUtente, long idMerenda, short quantita, DateTime dataRichiesta, DateTime? dataPagamento = null, long? idOrdine = null)
    {
        IdUtente = idUtente;
        IdMerenda = idMerenda;
        Quantita = quantita;
        DataRichiesta = dataRichiesta;
        if (dataPagamento != null) DataPagamento = (DateTime)dataPagamento;
        if (idOrdine != null) IdOrdine = (long)idOrdine;
    }
}
