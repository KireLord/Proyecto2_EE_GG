namespace SignInAndSignUpUI;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignIn");
	}
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        string username = usernameEntry1.Text;
        string password = passwordEntry1.Text;

        // Aqu� puedes agregar la l�gica para guardar los datos de registro en alg�n lugar,
        // como una base de datos o sistema de almacenamiento

        // Por ejemplo, puedes utilizar una clase de servicio para realizar la inserci�n en una base de datos
        //UserService.Register(username, password);

        // Mostrar mensaje de �xito o redirigir a la p�gina de inicio de sesi�n
        DisplayAlert("Registro exitoso", "Usuario registrado correctamente", "OK");

        // Redirigir a la p�gina de inicio de sesi�n
        //Navigation.PopAsync();
    }
}

