using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Note_App
{
    public partial class Form1 : Form
    {

        private DataTable table;
        
        
        public Form1()
        {
            InitializeComponent();

            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if table is already initialized
            if (table == null)
            {
                // If not initialized, create a new DataTable and configure columns
                table = new DataTable();
            }

            // Set DataGridView data source
            dataGridView1.DataSource = table;

            // Configure DataGridView columns
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 620;
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New note created successsfully", "New note created", MessageBoxButtons.OK);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
          
              table.Rows.Add(txtTitle.Text, txtMessage.Text);

              dataGridView1.DataSource = table;

              MessageBox.Show("Note has been saved successfully!", "Note Saved", MessageBoxButtons.OK);

              txtTitle.Clear();
        }

        
        private void btnRead_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView has a current cell
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                // Check if a row is selected
                if (index > -1 && table != null && index < table.Rows.Count)
                {
                    txtTitle.Text = table.Rows[index].Field<string>("Title");
                    txtMessage.Text = table.Rows[index].Field<string>("Messages");
                }
                else
                {
                    // Handle the scenario where the selected row is invalid
                    MessageBox.Show("Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the scenario where no cell is selected
                MessageBox.Show("Please select a cell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;


                table.Rows[index].Delete();
            }
            else
            {
                // Handle the scenario where no cell is selected
                MessageBox.Show("Please select a cell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
