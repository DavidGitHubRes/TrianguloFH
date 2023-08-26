namespace TrianguloFH;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void CalBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            //lados del triangulo
            double a = Convert.ToDouble(EnA.Text);
            double b = Convert.ToDouble(EnB.Text);
            double c = Convert.ToDouble(EnC.Text);

            //sacamos el semiperimetro
            double s = (a + b + c) / 2;


            //usamos la formula de heron
            //sacamos el area sacandole raiz cuadrada
            Double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //imprimimos el area
            lblS.Text = $"Superficie del triangulo: {Area}";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }

    }
}

