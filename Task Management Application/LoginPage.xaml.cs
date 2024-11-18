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
//    /// Interaction logic for LoginPage.xaml
//    /// </summary>
//    public partial class LoginPage : Page
//    {
//        public LoginPage()
//        {
//            InitializeComponent();
//        }

//        private void Loginbutton_Click(object sender, RoutedEventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(EmailText.Text) || string.IsNullOrWhiteSpace(PasswordText.Text))
//            {
//                MessageBox.Show("you should Reuired all Fields");
//                return;
//            }
//            TaskManagmentsysEntities taskManagmentsysEntities = new TaskManagmentsysEntities();
//            var EMP=taskManagmentsysEntities.UserTables.Where(x=> x.UserEmail == EmailText.Text && x.UserPassword== PasswordText.Text).FirstOrDefault();
     
//            if (EMP != null)
//            {
//                if (EMP.UserRole == "Manger")
//                {
//                    UserManagmentPage userManagmentPage = new UserManagmentPage();
//                    this.NavigationService.Navigate(userManagmentPage);
//                    MessageBox.Show("Loggin Succsessfully");
                    
//                    return;
//                }
//                else 
//                {
//                   ViewTaskPage viewTaskPage = new ViewTaskPage();
//                    this.NavigationService.Navigate(viewTaskPage);
//                    MessageBox.Show("Loggin Succsessfully");
                  

//                }
               

//            }
//            else
//            {
//                MessageBox.Show("invalid email or password");
//            }
//        }
//    }
//}
