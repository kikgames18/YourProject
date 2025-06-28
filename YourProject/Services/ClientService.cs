using System.Collections.Generic;
using YourProject.Data;
using YourProject.Models;

namespace YourProject.Services
{
    public class ClientService
    {
        private readonly AppDbContext _context;

        public ClientService()
        {
            _context = new AppDbContext();
        }

        public List<Client> GetAllClients()
        {
            return _context.GetAllClients();
        }

        public void AddClient(Client client)
        {
            _context.AddClient(client);
        }

        public void UpdateClient(Client client)
        {
            _context.AddClient(client); // Alternatively, you can add an update method in AppDbContext
        }

        public void DeleteClient(int clientId)
        {
            _context.DeleteClient(clientId);
        }
    }
}
