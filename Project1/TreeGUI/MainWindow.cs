using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            SidePanel.Height = buttonCayCanh.Height;
            SidePanel.Top = buttonCayCanh.Top;
            quanLyCayCanh1.BringToFront();
        }
        //Ben Trai màn hình chính
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành viên thực hiện: \n\t Bùi Trung Điền\n\t Tống Anh Quân \n\t Nguyễn Đông Quân\n Đồ án Công nghệ phần mềm 2019");
        }
        private void buttonCayCanh_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCayCanh.Height;
            SidePanel.Top = buttonCayCanh.Top;
            quanLyCayCanh1.BringToFront();
        }
        private void buttonVatTu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonVatTu.Height;
            SidePanel.Top = buttonVatTu.Top;
            vattu1.BringToFront();
        }
        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonBaoCao.Height;
            SidePanel.Top = buttonBaoCao.Top;
            userControl11.BringToFront();
        }


//------------------------------------------------------------------------------------//
// Control Button
        //Shutdown Button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thực sự Thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void setting_Click(object sender, EventArgs e)
        {
            Setting f = new Setting();
            f.ShowDialog();
        }
        //----------------------------------------------------------------------------//


    }
}
