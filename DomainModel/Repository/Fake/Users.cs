using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract.Repository;

namespace DomainModel.Repository.Fake
{
    public class Users : IUsers
    {
        public string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Entities.UserCollection GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entities.User user)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entities.User user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Entities.User user)
        {
            throw new NotImplementedException();
        }
    }
}
