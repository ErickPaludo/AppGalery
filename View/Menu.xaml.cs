using Gallery.Models;
using Gallery.Repositorios;
using static System.Net.Mime.MediaTypeNames;

namespace Gallery.View;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
        var categorias = new CategoryRepository().GetCategories();

        foreach (var category in categorias)
        {
            var lblcategory = new Label();
            lblcategory.Text = category.Name;

            foreach(var component  in category.Components)
            {
                var lblcomponentTitle = new Label();
                lblcomponentTitle.Text = component.Titulo;

                var lblcomponentDescription = new Label();
                lblcomponentDescription.Text = component.Descricao;

                MenuContainer.Children.Add(lblcomponentTitle);
                MenuContainer.Children.Add(lblcomponentDescription);

            }
        }
    }
}