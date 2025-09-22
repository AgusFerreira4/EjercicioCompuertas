namespace Library.Tests;

public class CompuertaOrTests
{
    //Add y GetName ya se testea en CompuertasAndTest
    //Seteo de las instancias a usar
    private CompuertaOR Or;
    private CompuertaOR Or2;
    
    [SetUp]
    public void Setup()
    {
        Or = new CompuertaOR("or-1");
    }
    
    //Comprueba si retorna 1/true cuando 1 entrada es verdadera
    [Test]
    public void CompuertaOr_ShouldReturn_True()
    {
        bool entrada1 = true;
        bool entrada2 = true;
        
        Or.AddEntrada(entrada1);
        Or.AddEntrada(entrada2);
        
        Assert.IsTrue(Or.Calcular());
    }
    
    //Comprueba si retorna 0 solo cuando todas las entradas son 0/false
    [Test]
    public void CompuertaOr_ShouldReturn_False()
    {
        bool entrada1 = false;
        bool entrada2 = false;
        
        Or.AddEntrada(entrada1);
        Or.AddEntrada(entrada2);
        
        Assert.IsFalse(Or.Calcular());
    }
    
}