using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers.Interfaces;
using TecNM.Practica2.Core.Services.Interface;

namespace TecNM.Practica2.Core.Managers;

public class Manager : IManager{
    private readonly IService _service;

    public Manager(IService service){
        _service = service;
    }

    public Bmi GetBmi(Person person){
        return _service.ProcessBmi(person);
    }
}