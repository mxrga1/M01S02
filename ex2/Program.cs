using ex2;

  

    FichaInscricao FichaInscricao = new FichaInscricao()
    {
        Id = 1,
        Nome = "Vinicius Margarida",
        DataNascimento = new DateTime (1999, 01, 25),
        MenorIdade = false,
    };

    FichaInscricao.ImprimirDados();

    Console.ReadLine();
    
