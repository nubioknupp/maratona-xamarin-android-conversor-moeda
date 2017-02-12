using Android.App;
using Android.Widget;
using Android.OS;

namespace ConversorMoeda
{
	[Activity(Label = "Conversor de Moedas", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var cmdConverter = FindViewById<Button>(Resource.Id.cmdConverter);
			var txtValorDolar = FindViewById<EditText>(Resource.Id.txtValorDolar);
			var txtValorReal = FindViewById<EditText>(Resource.Id.txtValorReal);

			cmdConverter.Click += delegate 
			{
				txtValorReal.Text = (double.Parse(txtValorDolar.Text) * 3.11) + "";
			};
		}
	}
}

