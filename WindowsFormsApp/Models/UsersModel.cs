using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WindowsFormsApp.Models
{
    public class UsersModel
    {
        //Fields
        private string userFirstName;
        private string userLastName;
        private string id;
        private string birthDate;
        private string adress;
        private string city;
        private string picture;

        //Properties

        [DisplayName("User First Name")]
        [Required(ErrorMessage ="First Name is requird")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="Name need to be between 2 and 10")]
        public string UserFirstName
        { get => userFirstName; set => userFirstName = value; }

        [Required(ErrorMessage = "Last Name is requird")]
        [DisplayName("User Last Name")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Name need to be between 2 and 10")]
        public string UserLastName 
        { get => userLastName; set => userLastName = value; }

        [Required(ErrorMessage = "Id is requird")]
        [DisplayName("User ID")]
        [Range(0, Int64.MaxValue, ErrorMessage = "Contact number should not contain characters")]
        [StringLength(20, MinimumLength = 11, ErrorMessage = "Contact number should have minimum 11 digits")]
        public string Id 
        { get => id; set => id = value; }

        [DisplayName("User Birth Date")]
        [Required(ErrorMessage = "Birthday is requird")]
        public string BirthDate
        { get => birthDate; set => birthDate = value; }

        [DisplayName("User Adress")]
        public string Adress 
        { get => adress; set => adress = value; }

        [DisplayName("User City")]
        public string City
        { get => city; set => city = value; }

        [DisplayName("User Picture")]
        public string Picture
        { get => picture; set => picture = value; }




    }
}
