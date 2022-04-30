using EksempelNewSchool.Domain;

namespace EksempelNewSchool
{
    public partial class Form1 : Form
    {
        private readonly IMedlemsDomain medlemsDomain;

        public Form1(IMedlemsDomain medlemsDomain)
        {
            InitializeComponent();
            this.medlemsDomain = medlemsDomain;
        }

        private void SletMedlem_Click(object sender, EventArgs e)
        {
            medlemsDomain.SletMedlem(42);
        }
    }
}