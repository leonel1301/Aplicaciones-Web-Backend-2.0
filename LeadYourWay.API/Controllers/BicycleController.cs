using LearningCenter.API.Request;
using LearningCenter.Domain;
using LearningCenter.Infraestructure;
using LearningCenter.Infraestructure.Context;
using LearningCenter.Infraestructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers;

public class BicycleController
{ 
    private IBicycleInfraestructure _bicycleInfraestructure;
    private IBicycleDomain _bicycleDomain;

    public BicycleController(IBicycleInfraestructure bicycleInfraestructure,IBicycleDomain bicycleDomain)
    {
        _bicycleInfraestructure = bicycleInfraestructure;
        _bicycleDomain = bicycleDomain;
    }
    
    [HttpGet]
    [Route("api/bicycle")]
    public List<Bicycle> GetAll()
    {
        return _bicycleDomain.GetAll();
    }
    
    // [HttpPost]
    // [Route("api/bicycle")]
    // public bool save(string name)
    // {
    //     return _bicycleDomain.save(name);
    // }
    
    [HttpPut]
    [Route("api/bicycle")]
    public bool update(int id, string name)
    {
        return _bicycleDomain.update(id,name);
    }
    
    [HttpDelete]
    [Route("api/bicycle")]
    public bool delete(int id)
    {
        return _bicycleDomain.delete(id);
    }
    
    [HttpPost]
    [Route("api/bicycle")]
    public void Post([FromBody] BicycleRequest request)
    {
        Bicycle bicycle = new Bicycle()
        {
            Name = request.Name
        };
        _bicycleDomain.save(bicycle.Name);
    }
    
}