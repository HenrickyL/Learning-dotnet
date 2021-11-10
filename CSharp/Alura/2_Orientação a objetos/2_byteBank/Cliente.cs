using System;
using System.Collections.Generic;

namespace _1_byteBank{
    public class Cliente{
        public string nome;
        public string cpf;
        public string profissao;

        public Cliente(string nome,string cpf,string profissao){
            this.nome = nome;
            this.cpf = cpf;
            this.profissao = profissao;
        }
        private string Formatar(string s,int lasters){
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

        public override string ToString(){
            string str = "";
            string cpfFormated = Formatar(this.cpf,3);
            str+=$"Nome:{this.nome}\n";
            str+=$"CPF:{cpfFormated}\n";
            str+=$"Profissão:{this.profissao}\n";

            return str;
        }
    }
}