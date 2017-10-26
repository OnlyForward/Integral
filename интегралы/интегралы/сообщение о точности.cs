using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая1
{
    public partial class сообщение_о_точности : Form
    {
        public сообщение_о_точности(string k)
        {
            InitializeComponent();
            textBox1.Text = k;
        }
    }
}
