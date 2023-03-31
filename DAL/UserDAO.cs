using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAO:PostContext
    {
        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            T_User user = db.T_User.FirstOrDefault(row => row.Username == model.Username && row.Password == model.Password );
            if (user != null && user.ID != 0) 
            {
                dto.ID = user.ID;
                dto.Username = user.Username;
                dto.Name = user.NameSurname;
                dto.Password = user.Password;
                dto.ImagePath = user.ImagePath;
                dto.isAdmin = user.isAdmin;
            }
            return dto;
        }
    }
}
