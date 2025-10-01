using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test2.services;
namespace test2.forms
{
    public partial class Form4 : Form
    {
        private HelloService _helloService;

        public Form4()
        {
            InitializeComponent();
            _helloService = new HelloService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = _helloService.GetHelloMessage("Katun");
            MessageBox.Show(msg, "Test Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
