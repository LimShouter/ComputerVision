using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopApp.ViewModel;

public class HomeViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
	
	
}