using System.Diagnostics.CodeAnalysis;
using LearningCenter.Infraestructure.Context;
using LearningCenter.Infraestructure.Models;

namespace LearningCenter.Infraestructure;

public class TutorialMySQLInfraestructure : ITutorialInfraestructure
{

    private LearningCenterDBContext _learningCenterDbContext;

    public TutorialMySQLInfraestructure(LearningCenterDBContext learningCenterDbContext)
    {
        _learningCenterDbContext = learningCenterDbContext;
    }
    
    
    public List<Tutorial> GetAll()
    {
        //Conecta BBDD
        /*List<string> list = new List<string>();
        list.Add("Value SQL 1");
        list.Add("Value SQL 2");
        list.Add("Value SQL 3");*/

        return _learningCenterDbContext.Tutorials.Where(category=> category.IsActive).ToList();

    }

    public bool save(string name)
    {
        Tutorial tutorial = new Tutorial();
        tutorial.Name = name;
        tutorial.IsActive = true;

        _learningCenterDbContext.Tutorials.Add(tutorial);
        
        _learningCenterDbContext.SaveChanges();

        return true;
    }

    public bool update(int id, string name)
    {
        Tutorial tutorial =  _learningCenterDbContext.Tutorials.Find(id);
        tutorial.Name = name;

        _learningCenterDbContext.Tutorials.Update(tutorial);
        
        _learningCenterDbContext.SaveChanges();

        return true;
    }

    public bool delete(int id)
    {  
        Tutorial tutorial =  _learningCenterDbContext.Tutorials.Find(id);
        
        tutorial.IsActive = false;

        _learningCenterDbContext.Tutorials.Update(tutorial);

        //_learningCenterDbContext.Tutorials.Remove(tutorial); Eliminacion física
        
        _learningCenterDbContext.SaveChanges();

        return true;
    }
}