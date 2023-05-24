using LearningCenter.Infraestructure.Models;

namespace LearningCenter.Domain;

public interface IBicycleDomain
{ 
    public List<Bicycle> GetAll();
    
    
    public bool save(string name);
    public bool update(int id, string name);
    public bool delete(int id);
}