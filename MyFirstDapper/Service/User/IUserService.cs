using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDapper.Service.User
{
    public interface IUserService
    {
        Task<IEnumerable<PersonModel>> GetAll();

        Task<PersonModel> Get(int Id);

        Task<PersonModel> Create(PersonModel model);

        Task<bool> Delete(int Id);

        Task<PersonModel> Update(int Id, PersonModel model);
    }
}
