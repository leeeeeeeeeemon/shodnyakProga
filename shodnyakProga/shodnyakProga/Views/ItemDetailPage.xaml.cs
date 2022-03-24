using shodnyakProga.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace shodnyakProga.Views
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