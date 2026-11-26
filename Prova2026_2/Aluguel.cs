public class Aluguel
{
    public Veiculo _veiculo {  get; set; }
    private DateOnly _dataInicio { get; set; }
    public DateOnly dataInicio
    {
        get {  return _dataInicio; }
        set
        {
            if (value <= _dataFim)
                throw new Exception("A data de fim deve ser posterior a data de início, revise as datas informadas.");
            else
                value = _dataInicio;
        }
    }
    public DateOnly _dataFim { get; set; }
    public int _totDias { get; set; }
    public double _valorTotal { get; set; }

    public Aluguel(Veiculo veiculo, DateOnly Inicio, DateOnly fim)
    {
        _veiculo = veiculo;
        dataInicio = Inicio;
        _dataFim = fim;
        _totDias = (fim.DayNumber - Inicio.DayNumber);
    }

    public double CalcularTotalAluguel()
    {
        return _valorTotal = _veiculo.CalcularAluguel(_totDias);
    }

    
}