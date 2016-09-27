using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneQuestionQuiz
{
    public partial class frmOneQuestionQuiz : Form
    {
        public frmOneQuestionQuiz()
        {
            InitializeComponent();
        }

        private void lblQuestion_Load(object sender, EventArgs e)
        {
            
        }

        private void rdoBad_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Sucks to suck.";
        }

        private void rdoMeh_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "That's okay i guess";
        }

        private void rdoGood_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "That's Great!";
        }
    }
}
