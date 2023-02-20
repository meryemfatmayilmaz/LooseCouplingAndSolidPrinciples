namespace InterfaceSegrationPrinciple;
interface IPrint
{
	public void Print(string text);
}
interface IScan
{
	public void Scan(string text);
}
interface IFax
{
	public void Fax(string text);
}
interface IPrintDublex
{
	public void PrintDublex(string text);
}
class HpPrinter : IPrint, IFax, IScan, IPrintDublex
{
	public void Fax(string text) => Console.WriteLine("HpPrinter Fax");
	public void Print(string text) => Console.WriteLine("HpPrinter print");
	public void PrintDublex(string text) => Console.WriteLine("HpPrinter PrintDublex");
	public void Scan(string text) => Console.WriteLine("HpPrinter Scan");
}
