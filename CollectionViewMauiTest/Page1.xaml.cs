namespace CollectionViewMauiTest;

public partial class Page1 : ContentView
{
	public Page1()
	{
		InitializeComponent();
        DataTestViewModel vm = new DataTestViewModel();
        listView.BindingContext = vm;
    }
}