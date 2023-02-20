namespace DependecyInversionPrinciple;

class MailService1
{
	public void SendMail(IMailServer mailServer, string to, string body)
	{
		mailServer.Send(to, body);
	}
}
interface IMailServer
{
	void Send(string to, string body);
}
class Gmail1 : IMailServer
{
	public void Send(string to, string body)
	{
		Console.WriteLine("Gmail Mail send");
	}
}
class Yandex1 : IMailServer
{
	public void Send(string to, string body)
	{
		Console.WriteLine("Yandex Mail send");
	}
}