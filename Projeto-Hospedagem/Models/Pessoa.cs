public class Pessoa
{
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public Pessoa() { }
    public string NomeCompleto() => $"{Nome} {SobreNome}".ToUpper();
    
}