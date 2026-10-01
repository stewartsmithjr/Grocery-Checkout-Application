using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4226_Assignment2
{
    public partial class containFrm : Form
    {
        Form1 form;
        public containFrm(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void containFrm_Load(object sender, EventArgs e)
        {
            containsTxtBox.Text = form.Get_Contains_Text();
        }
    }
}
