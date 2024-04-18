using HumanResource.src.DbContext;
using System;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class MainApplication : Form
    {
        private Dbcontext dbcontext;
        public MainApplication()
        {
            InitializeComponent();
        }
        private void ConnectToDatabase()
        {

            dbcontext = new Dbcontext();
            dbcontext.connectDB();

        }

        private void connectDB(object sender, EventArgs e)
        {
            ConnectToDatabase();

        }

        private void MainApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
