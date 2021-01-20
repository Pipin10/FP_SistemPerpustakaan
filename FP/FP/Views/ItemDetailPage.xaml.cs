using System.ComponentModel;
using Xamarin.Forms;
using FP.ViewModels;

namespace FP.Views
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