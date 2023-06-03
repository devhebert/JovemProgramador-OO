namespace AllObjects.Services;

public abstract class Inseto
{
    protected string cor { get; set; }
    protected double tamanho { get; set; }

    protected Inseto(string cor, double tamanho)
    {
        this.cor = cor;
        this.tamanho = tamanho;
    }

    public abstract void som();
}