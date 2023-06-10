namespace SignInAndSignUpUI;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignUp");
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        // Aqu� puedes agregar la l�gica para validar las credenciales de inicio de sesi�n
        // y guardar los datos si son v�lidos

        if (IsValidLogin(username, password))
        {
            // Guarda los datos de inicio de sesi�n utilizando Preferences
            Preferences.Set("username", username);
            Preferences.Set("password", password);

            // Navega a la siguiente p�gina despu�s de iniciar sesi�n
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            // Muestra un mensaje de error si las credenciales son inv�lidas
            DisplayAlert("Error", "Credenciales inv�lidas", "OK");
        }
    }

    private bool IsValidLogin(string username, string password)
    {
        // Comprueba si las credenciales son v�lidas utilizando datos quemados
        string validUsername = "usuario";
        string validPassword = "contrase�a";

        return username == validUsername && password == validPassword;
    }
}