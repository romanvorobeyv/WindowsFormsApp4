using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection;

        public object DataGridViewName { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Furniture_inventory_DataSet.Name". При необходимости она может быть перемещена или удалена.
            this.nameTableAdapter.Fill(this.___Furniture_inventory_DataSet.Name);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("DELETE * FROM TableName WHERE Id = @pId", connection); this.nameTableAdapter.Fill(this.___Furniture_inventory_DataSet.Name); //TableName - имя таблицы, из которой удаляете запись
            _ = command.Parameters.Add(new OleDbParameter("@pId", this.DataGridViewName.Furniture_inventory.Cells["Id"].Value)); //DataGridViewName - имя DataGridView на форме
            command.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            public class PrintPreviewDialogSelectPrinter : PrintPreviewDialog
        {
            public PrintPreviewDialogSelectPrinter()
            {
                Shown += myPrintPreview_Shown;
            }


            public void myPrintPreview_Shown(object sender, EventArgs e)
            {
                //Get the toolstrip from the base control
                ToolStrip ts = (ToolStrip)this.Controls[1];
                //Get the print button from the toolstrip
                ToolStripItem printItem = ts.Items[0];//"printToolStripButton"

                ToolStripItem myPrintItem;
                myPrintItem = ts.Items.Add(printItem.Text, printItem.Image, new EventHandler(MybtnPrint_Click));
                myPrintItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                //Relocate the item to the beginning of the toolstrip
                ts.Items.Insert(0, myPrintItem);
                //Remove the orginal button
                ts.Items.Remove(printItem);
            }

            public void MybtnPrint_Click(object sender, EventArgs e)
            {
                PrintDialog dlgPrint = new PrintDialog();
                try
                {
                    dlgPrint.AllowSelection = true;
                    dlgPrint.ShowNetwork = true;
                    dlgPrint.Document = this.Document;
                    if (dlgPrint.ShowDialog() == DialogResult.OK)
                    {
                        this.Document.Print();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Print Error: " + ex.Message);
                }
            }
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
         this.Close();
    
    }
}
