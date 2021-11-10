using _1_byteBank;



namespace _1_byteBank{
    class ContaCorrente{
        private Cliente _titular ;
        public Cliente Titular{
            get;
            set;
        }

        private int _agencia;
        private int _numero;
        private double _saldo;
        public double Saldo{
            get{
                return _saldo;
            }
            set{
                if(value >= 0){
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(Cliente titular,int agencia, int numero){
            this._titular = titular;
            this._agencia = agencia;
            this._numero = numero;
            this._saldo = 0.0;
        }
        public ContaCorrente(){}

        public  bool Sacar(double valor){
            if(this._saldo>= valor){
                this._saldo -= valor;
                return true;
            }else{
                return false;
            }
        }
        public bool Depositar(double valor){
                if(valor>=0){
                    this._saldo += valor;

                    return true;
                }
                return false;
            }

        public override string ToString(){
            string str = "";
            str+=$"Titular:\n{this._titular}\n";
            str+=$"Agência:{this._agencia}\n";
            str+=$"Numero:{this._numero}\n";
            str+=$"Saldo:{this._saldo}\n";
            return str;
        }  

        
    }    
}

