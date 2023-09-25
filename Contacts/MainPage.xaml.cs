namespace Contacts;

/* 
There's three elements of .Net MAUI:
 - State: the data that the app is currently using
 - View: a UI element that the user sees
 - Event: something that happens that changes the state
*/

public partial class MainPage : ContentPage
{
	int count = 0; // this is the initial state

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e) // this is the event handler
	{
		count++; // change the state based on event

		if (count == 1)
			// manually update the variable, text on the button called CounterBtn. 
			// Full defintions are in MainPage.xaml
			CounterBtn.Text = $"Clicked {count} time"; 
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


