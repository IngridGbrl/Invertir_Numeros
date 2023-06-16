namespace Invertir_Numeros;

///<Summary>
///<Createddate>15/06/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>15/06/2023</lastmodificationdate>
///<lastmodificationdescription>
///se asignaron un nombre a cada entry
///
///</lastmodificationdescription>
///<lastmodifierautor>Ingrid Gabriel</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
    /// Constructor de la clase
    /// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento que se ejecutará al preisonar el boton e invertira los números y verificará que no sean valores nulos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
   
    private void btnInvertir_Clicked(object sender, EventArgs e)
    {
        

        if (!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text) && 
            !string.IsNullOrEmpty(datoC.Text) && !string.IsNullOrEmpty(datoD.Text))
        {
            double Dato1, Dato2, Dato3, Dato4;
            Dato1 = Convert.ToDouble(datoA.Text);
            Dato2 = Convert.ToDouble(datoB.Text);
            Dato3 = Convert.ToDouble(datoC.Text);
            Dato4 = Convert.ToDouble(datoD.Text);

            datoA.Text = Convert.ToString(Dato4);
            datoB.Text = Convert.ToString(Dato3);
            datoC.Text = Convert.ToString(Dato2);
            datoD.Text = Convert.ToString(Dato1);
        }
        else
        {
            DisplayAlert("error", "Introduce todos los numeros", "ok");
        }
    }
}


