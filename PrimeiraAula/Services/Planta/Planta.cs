namespace AllObjects.Services;

public abstract class Planta
{
    protected bool engenheiro { get; set; }
    protected bool alvara { get; set; }

    protected Planta(bool engenheiro, bool alvara)
    {
        this.engenheiro = engenheiro;
        this.alvara = alvara;
    }

    public abstract bool construir();
}