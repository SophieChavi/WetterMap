namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int a = 0;
	int b = 0;
	int c = 0;
	bool first = false;
	string operation = "";

    public AnimalList Animals= new AnimalList();

    List<KeyValuePair<string, int>> keyValuePairs = new List<KeyValuePair<string, int>>();

	public MainPage()
	{
		InitializeComponent();
        //      label.BindingContext = slider;
        //      label.SetBinding(Label.RotationProperty, "Value");

        animalList.ItemsSource = Animals.Animals;
    }

    private void Int_Btn_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
		lbl_input.Text += button.Text;
    }

    private void Act_Btn_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (button.Text=="=")
		{
            if (first)
            {
                b = int.Parse(lbl_input.Text);
                keyValuePairs.Add(new KeyValuePair<string, int>(operation, b));
            }

            switch (operation)
			{
				case "+": c = a + b; break;
                case "-": c = a - b; break;
				default: c = int.Parse(lbl_input.Text); break;
            }
			
			a = c;
			first = true;
			lbl_output.Text = c.ToString();

		}
		else if(button.Text == "Step Back")
		{
			keyValuePairs.RemoveAt(keyValuePairs.Count - 1);
			c = do_calculation();

            a = c;
            first = true;
            lbl_output.Text = c.ToString();
        }
        else
        {
			if(first)
			{
				b = int.Parse(lbl_input.Text);
                keyValuePairs.Add(new KeyValuePair<string, int>(button.Text, b));
            }
			else
			{
                a = int.Parse(lbl_input.Text);
                keyValuePairs.Add(new KeyValuePair<string, int>("NONE", a));
            }
				
			operation = button.Text;
			lbl_input.Text = "";
			first = true;
        }
    }

	public int do_calculation()
	{
		int res = 0;
		for(int i = 0; i < keyValuePairs.Count; i++)
		{
			switch(keyValuePairs[i].Key)
			{
				case "+": res += keyValuePairs[i].Value; break;
                case "-": res -= keyValuePairs[i].Value; break;
                case "NONE": res = keyValuePairs[i].Value; break;
            }
		}
		return res;
	}
}

