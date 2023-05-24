using System.Diagnostics.CodeAnalysis;
using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public class TutorialDomain : ITutorialDomain
{
    public ITutorialInfraestructure _tutorialInfraestructure;

    public TutorialDomain(ITutorialInfraestructure tutorialInfraestructure)
    {
        _tutorialInfraestructure = tutorialInfraestructure;
    }
    public bool save(string name)
    {
        if (!this.IsValidData(name)) throw new Exception("less than 3");
        
        return _tutorialInfraestructure.save(name);
    }

    public bool update(int id, string name)
    {
        if (!this.IsValidData(name)) throw new Exception("less than 3");
        return _tutorialInfraestructure.update(id,name);
    }

    public bool delete(int id)
    {
        return _tutorialInfraestructure.delete(id);
    }


    private bool IsValidData(string name)
    {
        if (name.Length < 3) return  false;
        return true;

    }
}