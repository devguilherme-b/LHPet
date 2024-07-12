namespace LHPet.Models;

public class Cliente
{
    // parâmentros da classe Cliente
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Paciente { get; set; }
    
    // usando o comendo "ctor" p/ criar um construtor do model cliente definindo os parâmetros necessário p/ criar a instância
    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}