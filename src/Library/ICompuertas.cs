namespace Library;

public interface ICompuertas
{
    //Propiedades de la clase
    string Name { get; set; }
    List<bool> Entradas { get; set; }
    bool Salida { get; set;}

    //Metodos de la clase
    string GetName();
    void AddEntrada(bool entrada);
    bool Calcular();
}
