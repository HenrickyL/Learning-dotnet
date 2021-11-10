using System;

namespace byteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, double salario) : base(cpf,salario) {

            
        }
        public override double GetBonificacao(){
            return this.Salario*1.2; 
        }
        public override void AumentarSalario()
        {
            this.Salario*=1.15;
        }

        public override string ToString()
        {
            string cpfFormated = Formatar(this.CPF,5);
            string str = "::Diretor::\n";
            str+=$"Nome: {this.Nome}\n";
            str+=$"CPF: {cpfFormated}\n";
            str+=$"Salario: {this.Salario}";

            return str;
        }
    }
}