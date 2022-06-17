

namespace CVInterface;

public interface ICVAlgorythm
{
	public string DatasetPath { set; }
	public object TargetImage { set; }
	
	public ICVResult Calc();
}