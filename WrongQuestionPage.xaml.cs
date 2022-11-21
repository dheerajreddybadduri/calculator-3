using Calculator.Pages;
using Calculator.Services;

namespace Calculator;

public partial class WrongQuestionPage : ContentPage
{
	public WrongQuestionPage()
	{
		InitializeComponent();
	}

    public async void navigateToNextQuestion(object sender, EventArgs e)
    {
        var int_num = StorageService.currNum + 1;
        StorageService.setCurrentPage(int_num);
        await Navigation.PushAsync(new APITestPage());
    }

    public async void trySameQuestionAgain(object sender, EventArgs e)
    {
        var int_num = StorageService.currNum;
        StorageService.setCurrentPage(int_num);
        await Navigation.PushAsync(new APITestPage());
    }
}