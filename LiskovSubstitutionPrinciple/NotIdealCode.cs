namespace LiskovSubstitutionPrinciple;

internal abstract class Cloud1
{
	public abstract void Translate1();
	public abstract void MachineLearning1();
}
class AWS1 : Cloud1
{
	public override void Translate1() => Console.WriteLine("AWS Translate.");
	public override void MachineLearning1() => Console.WriteLine("AWS machine learning");
}

class Azure1 : Cloud1
{
	public override void MachineLearning1() => Console.WriteLine("AWS machine learning");
	public override void Translate1() => throw new NotImplementedException();
}
