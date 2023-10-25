using System.Collections.ObjectModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {

        public string MyTitle { get; set; } = "Lista de tareas";

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Agregado", "Ok");
        }
    }
}