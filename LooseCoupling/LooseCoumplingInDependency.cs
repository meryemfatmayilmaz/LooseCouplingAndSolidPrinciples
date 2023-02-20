namespace LooseCoupling
{
	class MailSender
	{
		public void Send(IMailServer mailServer)
		{
			mailServer.Send("sampleTo@deneme.com", "sampleFrom@deneme.com");
		}
	}
	interface IMailServer
	{
		void Send(string to, string from);
	}
	class Gmail : IMailServer
	{
		public void Send(string to, string from)
		{
			//...
		}
	}
	class Yandex : IMailServer
	{
		public void Send(string to, string from)
		{
			//...
		}
	}
	class Hotmail : IMailServer
	{
		public void Send(string to, string from)
		{
			//...
		}
	}

}
