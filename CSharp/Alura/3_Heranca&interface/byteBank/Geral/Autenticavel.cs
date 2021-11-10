namespace byteBank.Geral
{
    public interface Autenticavel
    {
        string Senha { get; set; }

       bool Autenticar(string senha);
    }
}