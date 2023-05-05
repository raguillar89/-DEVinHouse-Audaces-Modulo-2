namespace Exercicio1ao10.Model
{
    class PessoaFisica : Clientes
    {
        private int _AccountNumber;
        private string _Cpf;
        private int _Age;

        public int AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public PessoaFisica() { }

        public PessoaFisica(string name, string clientType, int accountNumber, string address, string phoneNumber, double balance, string cpf, int age) : base(name, clientType, address, phoneNumber, balance)
        {
            _AccountNumber = accountNumber;
            _Cpf = cpf;
            _Age = age;
        }

        public override string ConverterTexto()
        {            
            return $"{base.ConverterTexto()}\nCPF: {_Cpf}\nIdade: {_Age}\nNúmero da Conta: {_AccountNumber}";            
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCPF: {_Cpf}\nIdade: {_Age}\nNúmero da Conta: {_AccountNumber}";
        }
    }
}
