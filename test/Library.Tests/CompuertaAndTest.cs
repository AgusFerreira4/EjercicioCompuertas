namespace Library.Tests;

public class CompuertaAndTests
{
    //Seteo de las instancias a usar
    private CompuertaAnd And;
    private CompuertaAnd And2;
    
    [SetUp]
    public void Setup()
    {
        And = new CompuertaAnd("and-1");
        And2 = new CompuertaAnd("and-2");
    }

    //Comprueba si funciona agregar entradas tanto para bool como para resultados de otras compuertas
    [Test]
    public void CompuertaAnd_ShouldAddAnEntrance()
    {
        bool entrada = false;
        And.AddEntrada(entrada);
        
        And2.AddEntrada(And.Calcular());
        
        Assert.That(And.Entradas.Count, Is.EqualTo(1));
        Assert.That(And2.Entradas.Count, Is.EqualTo(1));
    }

    //Comprueba si retorna 1/true cuando ambas entradas son 1
    [Test]
    public void CompuertaAnd_ShouldReturn_True()
    {
        bool entrada1 = true;
        bool entrada2 = true;
        
        And.AddEntrada(entrada1);
        And.AddEntrada(entrada2);
        
        Assert.IsTrue(And.Calcular());
    }
    
    //Comprueba si al haber algo falso retorna 0/falso, como funciona la compuerta and
    [Test]
    public void CompuertaAnd_ShouldReturn_False()
    {
        bool entrada1 = false;
        bool entrada2 = true;
        
        And.AddEntrada(entrada1);
        And.AddEntrada(entrada2);
        
        Assert.IsFalse(And.Calcular());
    }

    //Comprueba si se retorna el nombre de forma correcta 
    [Test]
    public void CompuertaAnd_ShouldReturn_Name()
    {
        And.Name = "and-4";
        Assert.That(And.GetName(), Is.EqualTo("and-4"));
    }
}