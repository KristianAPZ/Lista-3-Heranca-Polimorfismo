using Models04;

ContaCorrente contaKris = new ContaCorrente(5f);


contaKris.Depositar(10f);
contaKris.Sacar(20f);
contaKris.ExibirSaldo();

ContaPoupanca contaDiego = new ContaPoupanca(100f);
contaDiego.Depositar(250f);
contaDiego.Sacar(2000f);
contaDiego.ExibirSaldo();