using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dis_Hekimi1
{
    public partial class MainWindow : Form
    {


        public static AnaSayfa anaSayfa;
        public static Doktorlar doktorlar;
        public static Randevular randevular;
        public static Goruntuler goruntuler;

        public static Form activeForm;
        public MainWindow()
        {
            InitializeComponent();
            activeForm = new Form() { MdiParent = this };
            anaSayfa = new AnaSayfa() { MdiParent = this };
            doktorlar = new Doktorlar() { MdiParent = this };
            randevular = new Randevular() { MdiParent = this };
            goruntuler = new Goruntuler() { MdiParent = this };


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = anaSayfa;
            activeForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
            activeForm.Hide();
            activeForm = doktorlar;
            activeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = randevular;
            activeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = goruntuler;
            activeForm.Show();
        }
    }
}
