    
class ContaCorrente{
    public string titular ;
    public int agencia;
    public int numero;
    public double saldo;
    public ContaCorrente(string titular,int agencia, int numero){
        this.titular = titular;
        this.agencia = agencia;
        this.numero = numero;
        this.saldo = 0.0;
    }
    public ContaCorrente(){}

    public  bool Sacar(double valor){
        if(this.saldo>= valor){
            this.saldo -= valor;
            return true;
        }else{
            return false;
        }
    }
    public bool Depositar(double valor){
            if(valor>=0){
                this.saldo += valor;

                return true;
            }
            return false;
        }

    public override string ToString(){
        string str = "";
        str+=$"Titular:{this.titular}\n";
        str+=$"Agência:{this.agencia}\n";
        str+=$"Numero:{this.numero}\n";
        str+=$"Saldo:{this.saldo}\n";
        return str;
    }  

    
}    
