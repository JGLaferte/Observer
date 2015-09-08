using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormTester : Form
    {
        public FormTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch1.observerManager.register(light1);
            switch1.observerManager.register(light3);
            switch2.observerManager.register(light2);
            switch2.observerManager.register(light3);




        }
    }
}
