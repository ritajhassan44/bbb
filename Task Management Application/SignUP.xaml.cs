using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_Management_Application
{
    /// <summary>
    /// Interaction logic for SignUP.xaml
    /// </summary>
    public partial class SignUP : Page
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Emailtxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordtxt.Text)|| string.IsNullOrEmpty(Roletxt.Text))
            {
                MessageBox.Show("the fields are empity");
                return;
            }
            if (Nametxt.Text.Length < 8)
            {
                MessageBox.Show("you should make the name more then 8 characters");
                SignUP signUP = new SignUP();
                this.NavigationService.Navigate(signUP);
            }
            if (Passwordtxt.Text != ConfirmPasswordtxt.Text)
            {
                MessageBox.Show("THE passsword does'nt match");
                return;
            }
            //if (!(Regex.IsMatch(Passwordtxt.Text, "A-Z")) || (Regex.IsMatch(Passwordtxt.Text, "//d")) || (Regex.IsMatch(Passwordtxt.Text, "//w")))
            //{
            //    MessageBox.Show("the password is weak");
            //    return;
            //}
            if (Roletxt.Text == "manger")
            {
                
                UserManagmentPage userManagmentPage = new UserManagmentPage();
                this.NavigationService.Navigate(userManagmentPage);
                return;
            }
            else if(Roletxt.Text == "Emploee")
            {
               
                ViewTaskPage viewTaskPage = new ViewTaskPage();
                this.NavigationService.Navigate(viewTaskPage);
            }
         
            TaskManagmentsysEntities taskManagmentsysEntities = new TaskManagmentsysEntities();
      var signup=taskManagmentsysEntities.UserTables.Where(x=> x.UserEmail == Emailtxt.Text).FirstOrDefault();
            if (signup!=null)
            {
                MessageBox.Show("email already ecxist");
                return; 
            }
            else
            {
                MessageBox.Show("error");
            }
         
          
           
        }
        
       
    }
}
