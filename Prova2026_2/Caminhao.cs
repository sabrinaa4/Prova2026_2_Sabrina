public class Caminhao : Veiculo
{
    public int _qtdEixos {  get; set; }
    public int _capacidadeCargas { get; set; }
    public string _tipoCarroceria { get; set; }
    public double _comprimento { get; set; }
    public double _altura { get; set; }

    public override double CalcularAluguel(int dias)
    {
        double total = base.CalcularAluguel(dias);
        if (_capacidadeCargas > 10000)
        {
            return total = total + (total * 0.20);
        }
        return total;
    }
}