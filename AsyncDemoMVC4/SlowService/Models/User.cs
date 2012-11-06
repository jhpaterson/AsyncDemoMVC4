
namespace SlowService.Models
{
    public class User
    {
        string firstname;
        string lastname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}