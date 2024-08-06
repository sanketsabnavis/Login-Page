namespace Login;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void OnLoginButtonClicked(object sender, EventArgs e)
	{
		string username = usernameEntry.Text;
		string password = passwordEntry.Text;

		// simple validation logic
		if (username == "admin" && password == "password")
		{
			DisplayAlert("Login Success", "Welcome", "OK");
			return;
		}
		else
		{
			messageLabel.Text = "Invalid username or password";
			messageLabel.IsVisible = true;
		}
	}
}