using GetSearchVideo.ViewModels;

namespace GetSearchVideo.Views;

public partial class MainView : ContentPage
{
	public MainView(MainVewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}