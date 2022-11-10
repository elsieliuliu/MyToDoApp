using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MyToDo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDo : ContentPage
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private async void OnSaveButton_Clicked(object sender, EventArgs e)
        {
            var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                $"{Path.GetRandomFileName()}.notes.txt");
            File.WriteAllText(filename,ToDoText.Text);
            await Navigation.PopModalAsync(); // this line takes you back to the main page
 
        }

        private void OnDeleteButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}