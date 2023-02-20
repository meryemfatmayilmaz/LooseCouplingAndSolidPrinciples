namespace SingleResponsiblePrinciple
{
	class Database
	{
		public void Connect()
		{
			//..
			Console.WriteLine("Db bağlantısı sağlanmıştır.");
		}
		public void Disconnect()
		{
			//...
			Console.WriteLine("Db bağşantısı kesilmiştir.");
		}
		public string State { get; set; }
	}
	class PersonService
	{
		public List<Person> GetPersons()
		{
			return new List<Person>()
			{
				new Person(){Name ="Meryem",Surname="Yılmaz"}
			};
		}
	}
}
