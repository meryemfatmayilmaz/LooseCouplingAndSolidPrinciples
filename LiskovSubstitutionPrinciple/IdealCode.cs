namespace LiskovSubstitutionPrinciple;
abstract class Cloud
{
	public abstract void MachineLearning();
}
interface ITranslatable
{
	void Translate();
}
class AWS : Cloud, ITranslatable
{

	public void Translate() => Console.WriteLine("AWS translate");
	public override void MachineLearning() => Console.WriteLine("AWS machine learning ");
}
class Azure : Cloud
{
	public override void MachineLearning() => Console.WriteLine("Azure machine learning");
}
