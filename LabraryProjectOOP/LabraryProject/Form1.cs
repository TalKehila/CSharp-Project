using Logic;
using static Logic.Item;

namespace LabraryProject
{
    public partial class Form1 : Form
    {
        ItemManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = ItemManager.ItemManagerInstance;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ButtonEmployeeForPassWordAndUserName_Click(object sender, EventArgs e)
        {
            //buttom for the password and username
        }
        private void TextBoxForUserNameEmpolyee_TextChanged(object sender, EventArgs e)
        {
            //empolee enter here username

        }
        private void TextBoxForPasswordEmpolyee_TextChanged(object sender, EventArgs e)
        {
            //empolee enter here password 
        }
        private void ButtonEmployeeForPassWordAndUserName_Click_1(object sender, EventArgs e)
        {
            string userName = UserNameEmpolyee.Text;
            string password = PasswordEmpolyee.Text;         
            if (manager.employeeManager.IsEmployee(userName, password))
            {
                bool isEmployee = true;
                EmpolyeeLogInPage empolyeeLogInPage = new EmpolyeeLogInPage(manager, isEmployee);
                empolyeeLogInPage.Show();
                this.Hide();
            }
            else if (manager.employeeManager.IsUser(userName, password))
            {
             
                bool isEmployee = false;
                EmpolyeeLogInPage empolyeeLogInPage = new EmpolyeeLogInPage(manager, isEmployee);
                empolyeeLogInPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong details. Please try again.");
            }
        }
        private void TextBoxForPasswordEmpolyee_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void UserNameEmpolyee_TextChanged(object sender, EventArgs e)
        {

        }
        private void LabelPasswordUser_Click(object sender, EventArgs e)
        {

        }
        private void LabelSerachBook_Click(object sender, EventArgs e)
        {

        }
    }
}
