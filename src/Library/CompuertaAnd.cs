namespace Library;

public class CompuertaAnd : ICompuertas
{
    public string Name { get; set; }
    public List<bool> Entradas { get; set; }
    public bool Salida { get; set; }

    public CompuertaAnd(string nombre)
    {
        Entradas = new List<bool>();
        this.Name = nombre;
    }

    public string GetName()
    {
        return this.Name;
    }

    public void AddEntrada(bool entrada)
    {
        Entradas.Add(entrada);
    }

    public bool Calcular()
    {
        foreach (bool entrada in Entradas)
        {
            if (!entrada)
            {
                Salida = false;
                return Salida;
            }
        }
        Salida = true;
        return Salida;
    }
}