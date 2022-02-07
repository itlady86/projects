using System;

using System.Linq;


namespace PhoneBook
{
	/// <summary>
	/// Description of Records.
	/// </summary>
	public class Record
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public int phoneNumber { get; set; }
		public string email { get; set; }
		public string department { get; set; }
		
				
		
		public Record(string firstName, string lastName, int phoneNumber, string email, string department) 
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.phoneNumber = phoneNumber;
			this.email = email;
			this.department = department;
		}
					
		public override string ToString()
		{
			return string.Format("{0};{1};{2};{3};{4}", firstName, lastName, phoneNumber, email, department);
		}
		
		
		public string DataToString() 
		{
			return string.Format("{0} {1}   -   {2}   -   {3}  -  {4}", firstName, lastName, phoneNumber, email, department);
		}
		
 
	}
}
