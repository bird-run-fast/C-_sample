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
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();

            StatusLabel.Text = "";

            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox.SelectedIndex = 0;

            MailcheckBox.Checked = false;
            FreeRadioButton.Checked = true;

            SetMailAddressTextBox();
            PlanChange();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();
        }

        private void SetMailAddressTextBox()
        {
            MailAddressTextBox.Enabled = MailcheckBox.Checked;
            MailAddressLabel.Enabled = MailcheckBox.Checked;
        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }

        private void PlanChange()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("IDを入力してください");
                return;
            }

            if (IdTextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入力できません");
                return;
            }
            if (MailAddressTextBox.Text.Contains(","))
            {
                MessageBox.Show("メールアドレスにカンマは入力できません");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "保存しますか？", 
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (var sw = new
                    System.IO.StreamWriter(
                    "save.csv", true, Encoding.GetEncoding("shift_jis"))) 
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailcheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailAddressTextBox.Text);
                    sw.Write(",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write("1");
                    }
                    else
                    {
                        sw.Write("0");
                    }
                    sw.Write(",");
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");
                }

                StatusLabel.Text = "保存しました";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
