namespace MauiApp1;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(String fruitName, String fruitIamge, String fruitDescription)
	{
		InitializeComponent();

		showName.Text = fruitName;
		showImage.Source = fruitIamge;
		showDescription.Text = fruitDescription;
		

	}
}