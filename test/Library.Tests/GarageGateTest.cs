namespace Library.Tests;

public class GarageGateTest
{
    private GarageGate Garage;

    [Test]
    public void Case_0_0_0_ShouldReturn_0_NotOpen()
    {
        Garage = new GarageGate(false, false, false);
        Assert.IsFalse(Garage.OpenGate());
    }
    
    [Test]
    public void Case_0_0_1_ShouldReturn_1_Open()
    {
        Garage = new GarageGate(false, false, true);
        Assert.IsTrue(Garage.OpenGate());
    }
    
    [Test]
    public void Case_0_1_0_ShouldReturn_0_NotOpen()
    {
        Garage = new GarageGate(false, true, false);
        Assert.IsFalse(Garage.OpenGate());
    }
    
    [Test]
    public void Case_0_1_1_ShouldReturn_0_NotOpen()
    {
        Garage = new GarageGate(false, true, true);
        Assert.IsFalse(Garage.OpenGate());
    }
    
    [Test]
    public void Case_1_0_0_ShouldReturn_0_NotOpen()
    {
        Garage = new GarageGate(true, false, false);
        Assert.IsFalse(Garage.OpenGate());
    }
    
    [Test]
    public void Case_1_0_1_ShouldReturn_0_NotOpen()
    {
        Garage = new GarageGate(true, false, true);
        Assert.IsFalse(Garage.OpenGate());
    }
    
    [Test]
    public void Case_1_0_1_ShouldReturn_1_Open()
    {
        Garage = new GarageGate(true, true, true);
        Assert.IsTrue(Garage.OpenGate());
    }
}