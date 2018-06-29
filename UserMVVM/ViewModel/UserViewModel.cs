using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMVVM.Model;

namespace UserMVVM.ViewModel
{
    class UserViewModel
    {
        public List<UserModel> Users { get; set; }

        public UserViewModel()
        {
            LoadUsers();

        }
        public void LoadUsers()
        {
            List<UserModel> usersList = new List<UserModel>
            {
                new UserModel { FirstName = "Vincent", LastName = "Fourberie" },
                new UserModel { FirstName = "Arnaud", LastName = "Papote" },
                new UserModel { FirstName = "Sandrine", LastName = "Trahison" }
            };

            Users = usersList;

        }
    }
}
