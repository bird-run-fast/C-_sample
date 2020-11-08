using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSample
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void UserSaveFormButton_Click(object sender, EventArgs e)
        {
            using (UserSaveForm f = new UserSaveForm())
            {
                f.ShowDialog();
            }
                
        }

        private void UserListFormButton_Click(object sender, EventArgs e)
        {
            using (UserListForm f = new UserListForm())
            {
                f.ShowDialog();
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            using (GameForm f = new GameForm()) 
            {
                f.ShowDialog();
            }
        }
    }
}
