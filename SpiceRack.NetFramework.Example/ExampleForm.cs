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
            SeedProductionData();
            SeedDebugData();
        }

        private void CreateDatabase()
        {
            try
            {
                ProvideFeedback("Creating Database: Example");
                _exampleDatabaseContext.Database.EnsureCreated();
                ProvideFeedback("Created Database: Example");
            }
            catch (Exception e)
            {
                ProvideFeedback(e.Message);
            }
        }

        private void DeleteDatabase()
        {
            try
            {
                ProvideFeedback("Deleting Database: Example");
                _exampleDatabaseContext.Database.EnsureDeleted();
                ProvideFeedback("Deleted Database: Example");
            }
            catch (Exception e)
            {
                ProvideFeedback(e.Message);
            }
        }

        private void SeedProductionData()
        {
            try
            {
                ProvideFeedback("Seeding Production Data");
                _exampleDatabaseContext.SeedProductionData();
                ProvideFeedback("Seeded Production Data");
            }
            catch (Exception e)
            {
                ProvideFeedback(e.Message);
            }
        }

        private void SeedDebugData()
        {
            try
            {
                ProvideFeedback("Seeding Debug Data");
                _exampleDatabaseContext.SeedDebugData();
                ProvideFeedback("Seeded Debug Data");
            }
            catch (Exception e)
            {
                ProvideFeedback(e.Message);
            }
        }

        private void ProvideFeedback(string feedback)
        {
            FeedbackArea.Text += feedback + Environment.NewLine;
            FeedbackArea.Refresh();
        }
    }
}
