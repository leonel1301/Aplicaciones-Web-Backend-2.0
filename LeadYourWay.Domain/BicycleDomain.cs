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
        if (!IsValidData(name))
        {
            throw new Exception("Less than 3");
        }

        if (name.Length > 20)
        {
            throw new Exception("More than 20");
        }
        return _bicycleInfraestructure.save(name);
    }
    
    public bool update(int id, string name)
    {
        if (!IsValidData(name))
        {
            throw new Exception("Less than 3");
        }

        if (name.Length > 20)
        {
            throw new Exception("More than 20");
        }

        return _bicycleInfraestructure.update(id, name);
    }
    
    public bool delete(int id)
    {
        return _bicycleInfraestructure.delete(id);
    }
    
    private bool IsValidData(string name)
    {
        if (name.Length < 3) return  false;
        return true;
    }
}