using DB_csahrp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_csahrp.IUserRepositories
{
    public interface IUserRepository
    {
        public void Create(string firstname, string lastname, string email, int age, string phone);
        public void Update(int id, string row, string anything);
        public Users Read(int id);
        public void Delete(int id);
        public List<Users> GetAll();

    }
}
