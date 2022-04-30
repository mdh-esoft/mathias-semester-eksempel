using EksempelOldSchoolUdenDI.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksempelOldSchoolUdenDIUdenDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SletMedlem_Click(object sender, EventArgs e)
        {
            var facade = DomainFacade.GetFacade();
            facade.MedlemsDomain.SletMedlem(42);
        }
    }
}
