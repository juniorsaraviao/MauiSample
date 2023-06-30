using System.Collections.ObjectModel;

namespace MauiSample;

public class CustomItem
{
    public string Name { get; set; }
    public double MaxLength { get; set; }
    public Keyboard KeyboardType { get; set; }
}

public partial class MainPage : ContentPage
{
	int count = 0;
	public ObservableCollection<CustomItem> CustomList { get; set; }

	public MainPage()
	{
		InitializeComponent();
		CustomList = new ObservableCollection<CustomItem>();
		AddCustomItems();
        BindingContext = this;
    }

	void AddCustomItems()
	{
		CustomList.Clear();

        for (int i = 0; i < 10; i++)
        {
            CustomList.Add(new CustomItem
            {
                MaxLength = 10,
                KeyboardType = Keyboard.Email,
                Name = "my value: " + i
            });
        }


  //      CustomList.Add(new CustomItem { Name = "Test1", MaxLength = 20, KeyboardType = Keyboard.Email });
		//CustomList.Add(new CustomItem { Name = "Test2", MaxLength = 30, KeyboardType = Keyboard.Plain });
		//CustomList.Add(new CustomItem { Name = "Test3", MaxLength = 10, KeyboardType = Keyboard.Numeric });
		//CustomList.Add(new CustomItem { Name = "Test4", MaxLength = 23, KeyboardType = Keyboard.Default });
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


