using LearningCenter.Domain;
using LearningCenter.Infraestructure;
using Moq;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace LeadYourWay.Domain.Test;

public class BicycleDomainTest
{
    [Fact]
    public void save_ValidObject_ReturnTrue()
    {
        //Arrange
        string bicycle = "Bici fachera";

        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.save(bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var result = bicycleDomain.save(bicycle);
        
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void save_InvalidObject_ReturnException()
    {
        //Arrange
        string bicycle = "Bi";
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.save(bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var ex = Assert.Throws<Exception>(() => bicycleDomain.save(bicycle));
        
        //Assert
        Assert.AreEqual("Less than 3",ex.Message);
    }
    
    [Fact]
    public void save_InvalidObject_ReturnExceptionMax()
    {
        //Arrange
        string bicycle = "Bici fachera de la muerte";
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.save(bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var ex = Assert.Throws<Exception>(() => bicycleDomain.save(bicycle));
        
        //Assert
        Assert.AreEqual("More than 20",ex.Message);
    }
    
    [Fact]
    public void update_ValidObject_ReturnTrue()
    {
        //Arrange
        string bicycle = "Bici fachera";
        int id = 1;
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.update(id,bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var result = bicycleDomain.update(id,bicycle);
        
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void update_InvalidObject_ReturnException()
    {
        //Arrange
        string bicycle = "Bi";
        int id = 1;
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.update(id,bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var ex = Assert.Throws<Exception>(() => bicycleDomain.update(id,bicycle));
        
        //Assert
        Assert.AreEqual("Less than 3",ex.Message);
    }
    
    [Fact]
    public void update_InvalidObject_ReturnExceptionMax()
    {
        //Arrange
        string bicycle = "Bici fachera de la muerte";
        int id = 1;
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.update(id,bicycle)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var ex = Assert.Throws<Exception>(() => bicycleDomain.update(id,bicycle));
        
        //Assert
        Assert.AreEqual("More than 20",ex.Message);
    }
    
    [Fact]
    public void delete_ValidObject_ReturnTrue()
    {
        //Arrange
        int id = 1;
        
        //Mock
        var bicycleInfraestructure = new Mock<IBicycleInfraestructure>();
        bicycleInfraestructure.Setup(t => t.delete(id)).Returns(true);
        
        BicycleDomain bicycleDomain = new BicycleDomain(bicycleInfraestructure.Object);
        
        //Act
        var result = bicycleDomain.delete(id);
        
        //Assert
        Assert.True(result);
    }
}