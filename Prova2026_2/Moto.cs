public class Moto : Veiculo
{
    public int _cilindrada {  get; set; }
    public bool _partidaEletrica { get; set; }
    public double _peso { get; set; }
    public int _capacidade { get; set; }

    public override double CalcularAluguel(int dias)
    {
        double total = base.CalcularAluguel(dias);
        if (dias > 5)
        {
            return total = total - (total * 0.15);
        }
        return total;
    }
}