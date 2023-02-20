namespace OpenClosedPrinciple;
public class ParaGonderici
{
	public void Gonder(IBanka banka, int tutar, string hesapNo)
	{
		banka.ParaTransferi(tutar, hesapNo);
	}

}
public interface IBanka
{
	bool ParaTransferi(int tutar, string hesapNo);
}
public class Garanti : IBanka
{
	public string HesapNo { get; set; }
	public void ParaGonder(int tutar)
	{
		//..
	}
	public bool ParaTransferi(int tutar, string hesapNo)
	{
		try
		{
			HesapNo = hesapNo;
			ParaGonder(tutar);
			return true;
		}
		catch (Exception)
		{

			return false;
		}
	}
}
public class HalkBank : IBanka
{
	public bool ParaTransferi(int tutar, string hesapNo)
	{
		throw new NotImplementedException();
	}
}
// add other banks
