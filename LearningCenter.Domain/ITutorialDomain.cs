namespace LearningCenter.Domain;

public interface ITutorialDomain
{
    public bool save(string name);
    public bool update(int id, string name);
    public bool delete(int id);
    
}