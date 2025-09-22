namespace Library;

public class CompuertaNot
{
    public string Name { get; set; }
    public List<bool> Entradas { get; set; }
    public bool Salida { get; set; }

    public CompuertaNot(string nombre)
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
        if (Entradas.Count == 0)
        {
            Entradas.Add(entrada);
        }
        else
        {
            Console.WriteLine("Solo se permite una entrada en la compuerta Not");
        }
        
    }

    public bool Calcular()
    {
        if (Entradas[0])
        {
            Salida = false;
            return Salida;
        }
        Salida = true;
        return Salida;
    }
}