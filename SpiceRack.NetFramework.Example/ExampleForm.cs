using System;
using System.Windows.Forms;
using SpiceRack.NetFramework.Example.DataAccess;

namespace SpiceRack.NetFramework.Example
{
    public partial class ExampleForm : Form
    {
        private readonly ExampleDatabaseContext _exampleDatabaseContext;

        public ExampleForm()
        {
            InitializeComponent();

            _exampleDatabaseContext = new ExampleDatabaseContext();
        }

        private void DoItButton_Click(object sender, EventArgs e)
        {
            DeleteDatabase();
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            try
            {
                ProvideFeedback("Creating Database: Example");
                _exampleDatabaseContext.Database.EnsureDeleted();
                ProvideFeedback("Created Database: Example");
            }
            catch (Exception e)
            {
                ProvideFeedback(e.Message);
            }
        }

        private void DeleteDatabase()
        {
            ProvideFeedback("Deleting Database: Example");
            _exampleDatabaseContext.Database.EnsureDeleted();
            ProvideFeedback("Deleted Database: Example");
        }

        private void ProvideFeedback(string feedback)
        {
            FeedbackArea.Text += feedback + Environment.NewLine;
            FeedbackArea.Refresh();
        }
    }
}
