using System;
using System.Windows.Forms;

namespace FirstVersion
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();    //закрыть форму
        }
    }
}
