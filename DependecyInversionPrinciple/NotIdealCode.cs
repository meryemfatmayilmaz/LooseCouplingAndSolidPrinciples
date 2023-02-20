namespace DependecyInversionPrinciple;
class MailService
{
	public void SendMail(Gmail gmail)
	{
		gmail.Send("...");
	}
}
class Gmail
{
	public void Send(string mail)
	{
		//...
	}
}
class Yandex
{
	public void SendMail(string mail, string to)
	{
		//Send Mail..
	}
}

