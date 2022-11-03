namespace EjercicicosTema9;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (entry.Text == "")
		{
			entry.Text="0";
		}
		else
		{
			try
			{
				var num = Convert.ToDouble(entry.Text);
				var numInt = Convert.ToInt32(num);
				if (numInt >= 100)
				{
					entry.Text = "99";
				}
				else 
				{
					entry.Text = numInt.ToString();
				}

			}
			catch (Exception tumare)
			{
				entry.Text = "50";
			}


		}
	}
}

