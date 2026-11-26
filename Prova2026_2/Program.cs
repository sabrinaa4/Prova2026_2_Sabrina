try
{
    Carro car = new Carro();
    car._veiculoID = 1;
    car._descricao = "descricao x";
    car._nomeMarca = "Gol";
    car._anoFabricacao = 2020;
    car.valorDiaria = 100;
    car._qtdPortas = 4;
    car._tamBagageiro = 100;
    //Console.WriteLine(car.CalcularAluguel(10));


    Moto m = new Moto();
    m._veiculoID = 2;
    m._descricao = "descricao x";
    m._nomeMarca = "Gol";
    m._anoFabricacao = 2020;
    m.valorDiaria = 10;
    m._cilindrada = 4;
    m._partidaEletrica = true;
    m._peso = 32;
    m._capacidade = 2;
    Console.WriteLine(m.CalcularAluguel(10));


    Caminhao cam = new Caminhao();
    cam._veiculoID = 3;
    cam._descricao = "descricao x";
    cam._nomeMarca = "Gol";
    cam._anoFabricacao = 2020;
    cam.valorDiaria = 100;
    cam._qtdEixos = 10;
    cam._capacidadeCargas = 11000;
    cam._tipoCarroceria = "tipo x";
    cam._comprimento = 200;
    cam._altura = 30;
    Console.WriteLine(cam.CalcularAluguel(10));

    Aluguel a = new Aluguel(car, new DateOnly(2026,01,01), new DateOnly(2026,01,11));
    Aluguel ab = new Aluguel(m, new DateOnly(2026,01,01), new DateOnly(2026,01,11));
    Aluguel ac = new Aluguel(cam, new DateOnly(2026,01,01), new DateOnly(2026,01,11));
    
    //Console.WriteLine(a.CalcularTotalAluguel());
    //Console.WriteLine(ab.CalcularTotalAluguel());
    Console.WriteLine(ac.CalcularTotalAluguel());

}
catch (Exception ex)
{
    throw new Exception(ex.Message);
}