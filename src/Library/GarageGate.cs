namespace Library;

public class GarageGate
{
    public bool A { get; set; }
    public bool B { get; set; }
    public bool C { get; set; }

    public GarageGate(bool a, bool b, bool c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public bool OpenGate()
    {
        CompuertaNot aNegado = new CompuertaNot("a negado");
        aNegado.AddEntrada(A);
        CompuertaNot bNegado = new CompuertaNot("b negado");
        bNegado.AddEntrada(B);

        CompuertaAnd and1 = new CompuertaAnd("a and b");
        and1.AddEntrada(A);
        and1.AddEntrada(B);
        
        CompuertaAnd and2 = new CompuertaAnd("(a_negado and b_negado");
        and2.AddEntrada(aNegado.Calcular());            //Podria haber usado un for y una lista de bools para agregar las entradas en los constructores de las compuertas;
        and2.AddEntrada(bNegado.Calcular());

        CompuertaOR or1 = new CompuertaOR("and1 or and2");
        or1.AddEntrada(and1.Calcular());
        or1.AddEntrada(and2.Calcular());

        CompuertaAnd and3 = new CompuertaAnd("or1 and c");
        and3.AddEntrada(C);
        and3.AddEntrada(or1.Calcular());

        bool resultado = and3.Calcular();

        return resultado;
    }
}