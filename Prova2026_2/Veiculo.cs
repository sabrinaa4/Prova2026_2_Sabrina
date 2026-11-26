public abstract class Veiculo
{
    public int _veiculoID {  get; set; }
    public string _descricao { get; set; }
    public string _nomeMarca { get; set; }
    public int _anoFabricacao { get; set; }
    private double _valorDiaria;
    public double valorDiaria
    {
        get {  return _valorDiaria; }
        set
        {
            if (value >= 0)
                _valorDiaria = value;
            else
                throw new Exception("O valor da diária deve ser igual ou maior que zero!");
        }
    }


    public virtual double CalcularAluguel(int dias)
    {
        return _valorDiaria * dias;
    }

}