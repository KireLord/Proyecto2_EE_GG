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

        // Aquí puedes agregar la lógica para guardar los datos de registro en algún lugar,
        // como una base de datos o sistema de almacenamiento

        // Por ejemplo, puedes utilizar una clase de servicio para realizar la inserción en una base de datos
        //UserService.Register(username, password);

        // Mostrar mensaje de éxito o redirigir a la página de inicio de sesión
        DisplayAlert("Registro exitoso", "Usuario registrado correctamente", "OK");

        // Redirigir a la página de inicio de sesión
        //Navigation.PopAsync();
    }
}

