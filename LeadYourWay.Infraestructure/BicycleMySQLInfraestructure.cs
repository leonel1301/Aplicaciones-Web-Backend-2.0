using LearningCenter.Infraestructure.Context;
using LearningCenter.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure;

public class BicycleMySQLInfraestructure : IBicycleInfraestructure
{
    

    private readonly LeadYourWayDBContext _leadYourWayDBContext;
    public DbSet<Bicycle> Bicycles { get; set; }

    public BicycleMySQLInfraestructure(LeadYourWayDBContext leadYourWayDBContext)
    {
        _leadYourWayDBContext = leadYourWayDBContext;
    }
    
    public List<Bicycle> GetAll()
    { 
        return _leadYourWayDBContext.Bicycles.ToList();
    } 

    public bool save(string name)
    { 
        Bicycle bicycle = new Bicycle();
        bicycle.Name = name;
        bicycle.IsActive = true;
        
        _leadYourWayDBContext.Bicycles.Add(bicycle);
        
        _leadYourWayDBContext.SaveChanges();
        
        return true;
    }

    public bool update(int id, string name)
    {
        Bicycle bicycle =  _leadYourWayDBContext.Bicycles.Find(id);
        bicycle.Name = name;

        _leadYourWayDBContext.Bicycles.Update(bicycle);
        
        _leadYourWayDBContext.SaveChanges();

        return true;
    }

    public bool delete(int id)
    {
        // delete bicycle
        Bicycle bicycle =  _leadYourWayDBContext.Bicycles.Find(id);
        _leadYourWayDBContext.Bicycles.Remove(bicycle);
        _leadYourWayDBContext.SaveChanges();
        return true;
    }
}