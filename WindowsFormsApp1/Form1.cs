using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Book> books;
        public Form1()
        {
            //initial
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                books = new List<Book>();
           
        }
    }
}
