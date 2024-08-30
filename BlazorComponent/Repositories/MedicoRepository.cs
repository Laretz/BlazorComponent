using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public async Task<List<Medico>> GetAllAsync()
        {
           
            return new List<Medico>
            { 
                new Medico { Id = 1, Name = "Dr. João Silva", Crm = "123456" },
                new Medico { Id = 2, Name = "Dra. Maria Oliveira", Crm = "234567" },
                new Medico { Id = 3, Name = "Dr. Pedro Costa", Crm = "345678" },
                new Medico { Id = 4, Name = "Dra. Ana Souza", Crm = "456789" },
                new Medico { Id = 5, Name = "Dr. Lucas Santos", Crm = "567890" }
            };
        }
    }
}
