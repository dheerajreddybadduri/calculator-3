namespace Calculator;

public partial class App : Application
{
	public static HistoryViewModel historyViewModel;
	public App()
	{
		InitializeComponent();
		historyViewModel = new HistoryViewModel();

	}
}

