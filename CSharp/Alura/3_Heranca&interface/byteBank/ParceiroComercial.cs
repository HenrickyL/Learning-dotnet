using byteBank.Geral;


namespace byteBank
{
    public class ParceiroComercial : Autenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha){
            return this.Senha == senha;
        }
        
    }
}