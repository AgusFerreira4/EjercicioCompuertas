namespace Library.Tests;

public class CompuertaNotTest
{
    //Add y GetName ya se testea en CompuertasAndTest
    //Seteo de las instancias a usar
    private CompuertaNot Not;
    
    [SetUp]
    public void Setup()
    {
        Not = new CompuertaNot("or-1");
    }
    
    //Comprueba si permite agregar solo una entrada
    [Test]
    public void CompuertaNot_ShouldHave_OneEntrace()
    {
        bool entrada1 = false;
        bool entrada2 = false;
        bool entrada3 = false;
        bool entrada4 = false;
        
        Not.AddEntrada(entrada1);
        Not.AddEntrada(entrada2);
        Not.AddEntrada(entrada3);
        Not.AddEntrada(entrada4);
        
        Assert.That(1, Is.EqualTo(Not.Entradas.Count));
    }
    
    //Comprueba si retorna true cuando la entrada es false
    [Test]
    public void CompuertaNot_ShouldReturn_True()
    {
        bool entrada1 = false;
        
        Not.AddEntrada(entrada1);
        
        Assert.IsTrue(Not.Calcular());
    }
    
    //Comprueba si retorna false cuando la entrada es true
    [Test]
    public void CompuertaNot_ShouldReturn_False()
    {
        bool entrada1 = true;
        
        Not.AddEntrada(entrada1);
        
        Assert.IsFalse(Not.Calcular());
    }
    
}