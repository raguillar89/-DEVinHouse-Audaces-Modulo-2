namespace Exercicio1ao10.Model
{
    class PessoaJuridica : Clientes
    {
        private string _Cnpj { get; set; }
        private int _AccountNumber;

        public int AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        public string Cnpj
        {
            get { return _Cnpj; }
            set { _Cnpj = value; }
        }

        public PessoaJuridica() { }

        public PessoaJuridica(string name, string clientType, int accountNumber, string address, string phoneNumber, double balance, string cnpj) : base(name, clientType, address, phoneNumber, balance)
        {
            _AccountNumber = accountNumber;
            _Cnpj = cnpj;
        }

        public override string ConverterTexto()
        {           
            return $"{base.ConverterTexto()}\nCNPJ: {_Cnpj}\nNúmero da Conta: {_AccountNumber}";            
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCNPJ: {_Cnpj}\nNúmero da Conta: {_AccountNumber}";
        }
    }
}
