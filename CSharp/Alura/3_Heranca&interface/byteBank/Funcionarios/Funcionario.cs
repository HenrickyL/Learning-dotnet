using System;

namespace byteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios {get; private set;}
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario){
            this.Salario = salario;
            this.CPF = cpf;
            Funcionario.TotalFuncionarios++;
        }
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        
        protected string Formatar(string s,int lasters){
            int len = s.Length;
            string str = "";
            for(int i=0;i<len; i++){
                if(i<len-lasters){
                    str += "-";
                }else{
                    str += s[i];

                }
            }
            return str;
        } 


        public override string ToString()
        {
            string cpfFormated = Formatar(this.CPF,5);
            string str = "::Funcionario::\n";
            str+=$"Nome: {this.Nome}\n";
            str+=$"CPF: {cpfFormated}\n";
            str+=$"Salario: {this.Salario}";

            return str;
        }
    }
}