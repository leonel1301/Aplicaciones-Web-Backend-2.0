using LearningCenter.Infraestructure.Models;

namespace LearningCenter.Infraestructure;

public interface IBicycleInfraestructure
{
    List<Bicycle> GetAll();
    
    public bool save(string name);
    public bool update(int id, string name);
    public bool delete(int id);
}