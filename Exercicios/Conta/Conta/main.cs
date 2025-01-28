
Titular titular = new Titular();

titular.nome = "Vitor Hugo Assis Da Silva";
titular.cpf = "150.740.689-40";
titular.telefone = "(44)9-97744706";
titular.dataNascimento = "25/09/2004";

Conta conta = new Conta();

conta.agencia = "1234";
conta.numeroDaConta = "6789-0";
conta.saldo = 1300;
conta.limite = 3000;

conta.Titular = titular; //permitindo que o objeto conta (que é uma instancia da classe Conta) tenha acesso a classe Titular por um objeto titular (instancia da classe Titular). Permitindo que a instancia conta tenha acesso a classe Titular pelo objeto titular.

conta.InformacoesConta();
