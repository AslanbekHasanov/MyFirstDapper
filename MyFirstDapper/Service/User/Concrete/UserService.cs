using MyFirstDapper.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDapper.Service.User.Concrete
{
    public class UserService : IUserService
    {
        public UserService(IDapper dapper)
        {
            _dapper = dapper;   
        }
        private readonly IDapper _dapper;
        public async Task<PersonModel> Create(PersonModel model)
        {
            return await _dapper.Create<PersonModel>(@$"insert into persons(fullname,login,password,image_url)
               values('{model.FullName}','{model.Login},'{model.Password}','{model.ImageUrl}')", null, CommandType.Text);

        }

        public async Task<bool> Delete(int Id)
        {
            return await _dapper.Delete<bool>($"delete from person where id ={Id}", null, CommandType.Text);
        }

        public async Task<PersonModel> Get(int Id)
        {
            return await _dapper.Get<PersonModel>($"select * from persons where id ={Id}", null, CommandType.Text);
        }

        public async Task<IEnumerable<PersonModel>> GetAll()
        {
            return await _dapper.GetAll<PersonModel>("select * from persons",null, CommandType.Text);
        }

        public async Task<PersonModel> Update(int Id, PersonModel model)
        {
            return await _dapper.Update<PersonModel>(@$"update persons set fullname ='{model.FullName}',
                                                  login ='{model.Login}',password ='{model.Password}',image_url ='{model.ImageUrl}' where id ={Id} ", null, CommandType.Text);
        }
    }
}
