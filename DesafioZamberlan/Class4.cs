namespace _2_Padel;
public class Treinador
{
    public string NomeTreinador { get; set; }
    public string Clube { get; set; }

    public Treinador(string nomeTreinador, string clube)
    {
        this.NomeTreinador = nomeTreinador;
        this.Clube = clube;
    }
}
