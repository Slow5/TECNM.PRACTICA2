using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Services.Interface;

namespace TecNM.Practica2.Core.Services
{
    public class Service : IService{
        public Bmi ProcessBmi(Person person)
        {
            var bmi = new Bmi();
            bmi.Index = (person.Weight / 9.81f) * 3.711f;     
            return bmi;
        }
    }
}