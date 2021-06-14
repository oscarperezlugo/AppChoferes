using System.ComponentModel;
using Xamarin.Forms;
using AppChoferes.ViewModels;

namespace AppChoferes.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}