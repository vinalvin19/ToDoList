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
    public partial class CreatePage : ContentPage
    {
        public List<ToDoItem> toDoItems;
        public CreatePage()
        {
            toDoItems = new List<ToDoItem>();
            InitializeComponent();
        }

        private void OnSave(object sender, EventArgs e)
        {
            toDoItems.Add(new ToDoItem(
                    ToDoEntry.Text,
                    Priority.Text,
                    SetDueDate(
                        Date.Date,
                        Time.Time.Hours,
                        Time.Time.Minutes,
                        Time.Time.Seconds),
                    false
                )
            );
            Clear();
        }

        private DateTime SetDueDate(DateTime date, int hour, int minute, int second)
        {
            DateTime value = new DateTime(date.Year, date.Month, date.Day, hour, minute, second);
            return value;
        }

        private void Clear()
        {
            ToDoEntry.Text = Priority.Text = String.Empty;
            Date.Date = DateTime.Now;
            Time.Time = new TimeSpan(
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
            );
        }

        private void OnCancel(object sender, EventArgs e)
        {

        }

        private void OnReview(object sender, EventArgs e)
        {
            var tempList = toDoItems;
        }
    }
}