namespace AutoCerto.Model;

public class UsuarioModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}