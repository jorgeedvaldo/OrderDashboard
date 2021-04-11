using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderDashboard
{
    public partial class FrmPrincipal : Form
    {
  
        public FrmPrincipal()
        {
            InitializeComponent();

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top + panel5.Top;
        }


        void MostrarOcultarMenuVendas() 
        {
            button9.Visible = !button9.Visible;
            button8.Visible = !button8.Visible;

            button10.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
        }

        void MostrarOcultarMenuEncomendas()
        {
            button9.Visible = false;
            button8.Visible = false;

            button10.Visible = !button10.Visible;
            button15.Visible = !button15.Visible;

            button16.Visible = false;
            button17.Visible = false;
        }

        void MostrarOcultarMenuUtilizadores()
        {
            button9.Visible = false;
            button8.Visible = false;

            button10.Visible = false;
            button15.Visible = false;

            button16.Visible = !button16.Visible;
            button17.Visible = !button17.Visible;
        }

        void OcultarTudo() 
        {
            button9.Visible = false;
            button8.Visible = false;

            button10.Visible = false;
            button15.Visible = false;

            button16.Visible = false;
            button17.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarTudo(); 

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top + panel5.Top;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarOcultarMenuVendas();

            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top + panel5.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarOcultarMenuEncomendas();

            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top + panel5.Top;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            OcultarTudo();
           
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top + panel5.Top;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OcultarTudo();

            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top + panel5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OcultarTudo();

            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top + panel5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarOcultarMenuUtilizadores();

            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top + panel5.Top;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja terminar a aplicação?", "Terminar Aplicação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jorgeedvaldo");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }  
    }
}
