using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactsData : IEquatable< ContactsData > , IComparable<ContactsData>
    {
        private string firstname;
		private string lastname = "";

        public ContactsData(string firstname)
        {
            this.firstname = firstname;

        }

	    public bool Equals(ContactsData other)
	    {
		    if (Object.ReferenceEquals(other, null))
		    {
			    return false;
		    }

		    if (object.ReferenceEquals(this, other))
		    {
			    return true;
		    }

		    return Firstname  == other.Firstname && Lastname == other.Lastname;
	    }



	    public override int GetHashCode()
	    {
		    return Firstname.GetHashCode() + Lastname.GetHashCode();
	    }

		public int CompareTo(ContactsData other)
		{
			if (Object.ReferenceEquals(other,null))
			return 1;
			return this.ToString().CompareTo(other.ToString());
		}

	    public override string ToString()
	    {
		    return $"lastname={Lastname};firstname={Firstname}";
	    }

	    public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
		public string Middlename { get; set; } = "";
		public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
	      
}
