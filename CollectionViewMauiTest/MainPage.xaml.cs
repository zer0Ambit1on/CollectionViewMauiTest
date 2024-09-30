namespace CollectionViewMauiTest
{
    public partial class MainPage : ContentPage
    {
        public List<AbstractIndexPage> AbstactPageIndexes { get; set; }
        public MainPage()
        {
            InitializeComponent();
            AbstactPageIndexes =
            [
                new AbstractIndexPage() { Index = 0 },
                new AbstractIndexPage() { Index = 1 },
            ];
            BindingContext = this;
        }
    }

}
