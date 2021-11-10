using byteBank.Geral;

namespace byteBank.Geral
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel user, string senha){
            bool userAuth = user.Autenticar(senha);

            return userAuth;
        }
    }
}