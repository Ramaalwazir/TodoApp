using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private todolist _todolist;
        public MainWindow()
        {
            InitializeComponent();
            _todolist = new todolist();

        }
        /// <summary>
        /// lägg till en todo-item i listan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, RoutedEventArgs e )
         
        {
            string task =TaskTextBox.Text;

            if (!string.IsNullOrEmpty(task))

            {
                _todolist.AddTask(task);
                updateTaskList();
                TaskTextBox.Clear();
            }
        }
        /// <summary>
        /// Uppdatera Listan med todo_items.
        /// </summary>
        private void updateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in _todolist.GetAllTask())
         {
                TasksListBox.Items.Add(task);
         }
       }
private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

    if(TasksListBox.SelectedIndex >=0 )
            {
                _todolist.RemoveTask(TasksListBox.SelectedIndex);
                updateTaskList();
           }
        }

    }
}

