using LearningCenter.Infraestructure;
using LearningCenter.Infraestructure.Models;

namespace LearningCenter.Domain;

public class BicycleDomain : IBicycleDomain
{ 
    IBicycleInfraestructure _bicycleInfraestructure;
    
    public BicycleDomain(IBicycleInfraestructure bicycleInfraestructure)
    {
        _bicycleInfraestructure = bicycleInfraestructure;
    }
    
    public List<Bicycle> GetAll()
    {
          return _bicycleInfraestructure.GetAll();   
    }
    
    public bool save(string name)
    {
        // validations
        if (name == null || name.Length < 4)
        {
            return false;
        }
        return _bicycleInfraestructure.save(name);
    }
    
    public bool update(int id, string name)
    {
        if (name == null || name.Length < 4)
        {
            return false;
        }
        return _bicycleInfraestructure.update(id,name);
    }
    
    public bool delete(int id)
    {
        return _bicycleInfraestructure.delete(id);
    }
}