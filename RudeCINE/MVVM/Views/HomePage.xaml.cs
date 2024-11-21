using RudeCINE.MVVM.Models;
using System.Collections.ObjectModel;

namespace RudeCINE.MVVM.Views;

public partial class HomePage : ContentPage
{
	public ObservableCollection<Films> Films { get; set; }
	public HomePage()
	{
		InitializeComponent();
		CollectionInitialization();
		BindingContext = this;
	}

    public void CollectionInitialization()
	{
		Films = new ObservableCollection<Films>
        {
			new Films
			{
				Name = "Oppenheimer",
				Hour = "21:00",
				Image = "oppenheimer.jpg"
			},

            new Films
            {
                Name = "Garfield",
                Hour = "15:30",
                Image = "garfield.jpg"
            },

            new Films
            {
                Name = "Barbie",
                Hour = "19:45",
                Image = "barbie.jpg"
            },

            new Films
            {
                Name = "Seksmisja",
                Hour = "20:15",
                Image = "seksmisja.jpg"
            }
        };
	}

	private void OnCollectionViewScrolled(object sender, ItemsViewScrolledEventArgs e)
	{
		CollectionView cW = new();
		cW.Scrolled += OnCollectionViewScrolled;
	}
}