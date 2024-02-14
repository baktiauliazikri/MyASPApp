using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyASPApp.Models;

namespace MyASPApp.DAL
{
    public class InMemoryTrainer : ITrainer
    {
        private List<Trainer> _trainers;
        public InMemoryTrainer()
        {
            _trainers = new List<Trainer>{
                new Trainer {Id=1,Name="Bakti Aulia Zikri", Expertise="ASP.Net Core"},
                new Trainer {Id=2,Name="Maisan Nabil Zuhdi", Expertise="Microsoft Azure"},
                new Trainer {Id=3,Name="Nabila Muyassari Yumni", Expertise="Azure DevOps"}
            };
        }
        public void Add(Trainer trainer)
        {
            trainer.Id = _trainers.Max(r => r.Id) + 1;
            _trainers.Add(trainer);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Trainer Get(int id)
        {
            var result = _trainers.SingleOrDefault(r=>r.Id==id);
            return result;
        }

        public IEnumerable<Trainer> GetAll()
        {
            return _trainers.OrderBy(r=>r.Name);
        }

        public void Update(int id, Trainer trainer)
        {
            throw new NotImplementedException();
        }
    }
}