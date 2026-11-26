public class Carro : Veiculo
{
    public int _qtdPortas {  get; set; }
    public int _tamBagageiro { get; set; }

    public override double CalcularAluguel(int dias)
    {
        double total = base.CalcularAluguel(dias);

        if (dias > 7)
        {
            return total = total - (total * 0.10);
        }
        return total;
    }
}