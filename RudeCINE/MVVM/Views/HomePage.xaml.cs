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
				Image = "oppenheimer.jpg",
                Type = "Thriller",
                Time = 250,
                AgeRestriction = 18
			},

            new Films
            {
                Name = "Garfield",
                Hour = "15:30",
                Image = "garfield.jpg",
                Type = "Cartoon",
                Time = 170,
                AgeRestriction = 8
            },

            new Films
            {
                Name = "Barbie",
                Hour = "19:45",
                Image = "barbie.jpg",
                Type = "Family Movie",
                Time = 150,
                AgeRestriction = 13
            },

            new Films
            {
                Name = "Seksmisja",
                Hour = "20:15",
                Image = "seksmisja.jpg",
                Type = "Action Movie",
                Time = 180,
                AgeRestriction = 18
            }
        };
	}

}