using System;
using System.ComponentModel;


namespace Entities
{

    public class User
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public Entities.Culture Culture { get; set; }
        public bool IsEnabled { get; set; }
        public UserSettings Settings { get; set; }
        public Role Role { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsEmployee { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public User()
        {
            Settings = new UserSettings();

            this.Id = -1;
            this.Culture = null;
            this.IsEnabled = true;
            this.Role = null;
            this.IsAuthenticated = false;
            this.IsEmployee = false;
        }


        public User(Culture culture, Role role)
            : this()
        {
            this.Culture = culture;
            this.Role = role;
        }


        public User(string name, string password)
            : this()
        {
            this.Name = name;
            this.Password = password;
        }


        public User Clone()
        {
            User user = new User();
            user.Copy(this);

            return user;
        }


        public void Copy(User user)
        {
            this.Id = user.Id;
            this.Name = user.Name;
            this.Password = user.Password;
            this.Culture = user.Culture;
            this.IsEnabled = user.IsEnabled;
            this.IsAuthenticated = user.IsAuthenticated;

            this.Settings.Copy(user.Settings);
            this.Role = user.Role;
            this.IsEmployee = user.IsEmployee;
        }
    }
}
