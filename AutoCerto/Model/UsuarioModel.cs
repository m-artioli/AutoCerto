namespace AutoCerto.Model;

public class UsuarioModel
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public string Nome { get; set; }
    public string SenhaHash { get; set; }
}