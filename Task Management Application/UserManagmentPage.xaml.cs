//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Task_Management_Application
//{
//    /// <summary>
//    /// Interaction logic for UserManagmentPage.xaml
//    /// </summary>
//    public partial class UserManagmentPage : Page
//    {
//        public UserManagmentPage()
//        {
//            InitializeComponent();
//            UserTable table = new UserTable();

//        }

//        private void add_Click(object sender, RoutedEventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(taskid.Text) || string.IsNullOrWhiteSpace(title.Text) || string.IsNullOrWhiteSpace(description.Text) || string.IsNullOrWhiteSpace(emailtext.Text))
//            {
//                MessageBox.Show("required");
//            }
//            TaskManagmentsysEntities taskManagmentsysEntities = new TaskManagmentsysEntities();
//            int id = int.Parse(taskid.Text);
//            var EMP = taskManagmentsysEntities.TasksTables.Where(x => x.TaskID == id && x.TaskTitle == title.Text && x.TaskDescription == description.Text).FirstOrDefault();
//            if (EMP != null)
//            {
//                TasksTable tasksTable = new TasksTable();
//                UserTable userTable = new UserTable();
//                tasksTable.UserTable = userTable;
//                tasksTable.TaskID = id;
//                tasksTable.TaskTitle = title.Text;
//                tasksTable.TaskDescription = description.Text;
//                tasksTable.TaskID = userTable.UserID;

//                userTable.TasksTables.Add(tasksTable);
//                MessageBox.Show("addedd succsessfully");
//            }
//            else
//            {
//                MessageBox.Show("error ");
//            }
        
//        }

//        private void delete_Click(object sender, RoutedEventArgs e)
//        {
//            if (taskid.Text == "" || title.Text == "" || description.Text == "")
//            {
//                MessageBox.Show("already deleted");
//            }
//            TaskManagmentsysEntities taskManagmentsysEntities = new TaskManagmentsysEntities();
//            int id = int.Parse(taskid.Text);
//            var EMP=taskManagmentsysEntities.TasksTables.Where(x=> x.TaskID== id).FirstOrDefault();
//            if (EMP != null)
//            {
//                TasksTable tasksTable = new TasksTable();
//                tasksTable.UserID = id;
//                tasksTable.TaskTitle= title.Text;
//                tasksTable.TaskDescription = description.Text;
//                taskManagmentsysEntities.TasksTables.Remove(tasksTable);
//                MessageBox.Show("the element was removed");
//            }
//            else
//            {
//                MessageBox.Show("error");
//            }
//        }
//    }
//}
