namespace AllObjects.Services;

public abstract class Automovel
{
    protected string marca { get; set; }
    protected string modelo { get; set; }
    protected DateTime fabricacao { get; set; }

    public Automovel(string marca, string modelo, DateTime fabricacao)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.fabricacao = fabricacao;
    }

    protected void andar()
    {
        Console.WriteLine("Em movimento...");
    }
    
    protected void parar()
    {
        Console.WriteLine("Parado...");
    }

    public abstract void buzinar();

}