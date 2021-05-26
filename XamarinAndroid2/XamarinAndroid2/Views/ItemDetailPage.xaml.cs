using System.ComponentModel;
using Xamarin.Forms;
using XamarinAndroid2.ViewModels;

namespace XamarinAndroid2.Views
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