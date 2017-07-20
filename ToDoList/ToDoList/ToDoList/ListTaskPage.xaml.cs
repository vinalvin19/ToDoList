using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListTaskPage : ContentPage
	{
        public List<ToDoItem> ToDoItems { get; set; }

		public ListTaskPage (List<ToDoItem> items)
		{
            ToDoItems = items;
            BindingContext = this;
			InitializeComponent ();
		}

        private void OnSelected(object sender, ItemTappedEventArgs e)
        {
            var ToDoItems = e.Item as ToDoItem;
            DisplayAlert("CHoosen!", ToDoItems.TaskName + "was selected!", "OK");
        }
    }
}