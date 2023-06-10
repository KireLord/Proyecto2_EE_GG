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

        // Aquí puedes agregar la lógica para validar las credenciales de inicio de sesión
        // y guardar los datos si son válidos

        if (IsValidLogin(username, password))
        {
            // Guarda los datos de inicio de sesión utilizando Preferences
            Preferences.Set("username", username);
            Preferences.Set("password", password);

            // Navega a la siguiente página después de iniciar sesión
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            // Muestra un mensaje de error si las credenciales son inválidas
            DisplayAlert("Error", "Credenciales inválidas", "OK");
        }
    }

    private bool IsValidLogin(string username, string password)
    {
        // Comprueba si las credenciales son válidas utilizando datos quemados
        string validUsername = "usuario";
        string validPassword = "contraseña";

        return username == validUsername && password == validPassword;
    }
}