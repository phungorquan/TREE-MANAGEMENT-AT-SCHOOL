using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Vattu : UserControl
    {
        public Vattu()
        {
            InitializeComponent();
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
//-----------------------------------------------------------------------------------------//
        //Button calback
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm vào danh sách");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã hủy");
        }

//----------------------------------------------------------------------------------//
//All textbox call Back
        private void VattuTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        //Đơn Vi TextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiachiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void soluongTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NgayMuaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SotienTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
