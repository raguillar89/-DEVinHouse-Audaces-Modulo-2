namespace Exercicio1ao10.Model
{
    abstract class Clientes
    {
        private string _Name;
        private string _ClientType;
        private string _Address;
        private string _PhoneNumber;
        private double _Balance;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string ClientType
        {
            get { return _ClientType; }
            set { _ClientType = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        protected Clientes() { }

        protected Clientes(string name, string clientType, string address, string phoneNumber, double balance) : this()
        {
            _Name = name;
            _ClientType = clientType;
            _Address = address;
            _PhoneNumber = phoneNumber;
            _Balance = balance;
        }

        protected void ResumoCliente()
        {
            Console.WriteLine($"\nNome: {_Name}\nTipo de Cliente: {_ClientType}\nEndereço: {_Address}\nTelefone: {_PhoneNumber}\nSaldo: {_Balance}");
        }
    }
}
