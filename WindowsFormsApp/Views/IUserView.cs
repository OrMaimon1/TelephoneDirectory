using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Views
{
    public interface IUserView
    {   
        //Properties
        string UserFirstName { get; set; }
        string UserLastName { get; set; }
        string Id { get; set; }
        string BirthDate { get; set; }
        string Adress { get; set; }
        string City { get; set; }
        string Picture { get; set; }
        string SearchValue{ get; set; }
        bool IsUpdated { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }

        //Event
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetUserListBindingSourse(BindingSource userList);
        void show();
    }
}
