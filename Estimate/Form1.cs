using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimate
{
    /// <summary>
    /// Main form with grid and common functions
    /// </summary>
    public partial class Form1 : Form
    {
        //private ADGV.AdvancedDataGridView dataGridView1 = new ADGV.AdvancedDataGridView();
        //private Cache memoryCache;
        private PleaseWaitForm f3 = new PleaseWaitForm();
        private List<bool> initialized = new List<bool>();
        private int columnIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tablesDataSet2.TestTable". При необходимости она может быть перемещена или удалена.
            this.testTableTableAdapter.Fill(this.tablesDataSet2.TestTable);
             this.advancedDataGridView1.SortStringChanged += new EventHandler(dataGridView1_SortStringChanged);
             this.advancedDataGridView1.CellMouseUp += new DataGridViewCellMouseEventHandler(dataGridView1_DataSourceComplete);
             this.advancedDataGridView1.CellMouseEnter += new DataGridViewCellEventHandler(cell);
             this.advancedDataGridView1.FilterStringChanged += new EventHandler(dataGridView1_FilterStringChanged);
             this.advancedDataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(dataGridView1_ColumnHeaderMouseClick);
           
            for (int i = 0; i < advancedDataGridView1.Columns.Count; i++)
            {
                initialized.Add(false);
            }
            this.advancedDataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
                columnIndex = e.ColumnIndex;
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, EventArgs e)
        {
            if (columnIndex != 0 && initialized[columnIndex] == false)
            {
                initialized[columnIndex] = true;
                if (!f3.IsHandleCreated)
                {
                    f3 = new PleaseWaitForm();
                    f3.Show();
                    f3.Update();
                    System.Threading.Thread.Sleep(3000);
                    this.Focus();
                }
            }

        }

        private void dataGridView1_DataSourceComplete(object sender, EventArgs e)
        {
            if(f3.IsHandleCreated)
            f3.Close();
        }


  

        /// <summary>
        /// Make shorter grid, move button and create sub-form for presenting information of row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            TabControl tabControl1 = new TabControl();

            if (button1.Text == ">")
            {            
                button1.Text = "<";
                advancedDataGridView1.Width -= Form1.ActiveForm.Width / 100 * 45; 
                button1.Location = new System.Drawing.Point(button1.Location.X - Form1.ActiveForm.Width / 100 * 45, advancedDataGridView1.Location.Y);

                tabControl1.Size = new System.Drawing.Size(Form1.ActiveForm.Width / 100 * 43, button1.Size.Height);
                tabControl1.TabPages.Add("Информация");
                tabControl1.TabPages.Add("Контакты");
                tabControl1.TabPages.Add("История");
                tabControl1.TabPages.Add("Фото");
                tabControl1.TabPages.Add("Источник");
                Form1.ActiveForm.Controls.Add(tabControl1);
                // tab Информация

                Label lbl1 = new Label();
                lbl1.Text = "text ";
                lbl1.Size = new System.Drawing.Size(500, 20);
               
                tabControl1.TabPages[0].Controls.Add(lbl1);

                //Контакты

                Label lbluser = new Label();
                Label lblemail = new Label();
                Label lblphone = new Label();
                Label lblsug = new Label();

                lbluser.Text = "Пользователь";
                lblemail.Text = "Email";
                lblphone.Text = "Телефоны";
                lblsug.Text = "Количество предложений";

                lbluser.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 10);
                lblemail.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 80);
                lblphone.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 150);
                lblsug.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 350);

                tabControl1.TabPages[1].Controls.Add(lbluser);
                tabControl1.TabPages[1].Controls.Add(lblemail);
                tabControl1.TabPages[1].Controls.Add(lblphone);
                tabControl1.TabPages[1].Controls.Add(lblsug);

                TextBox txtuser = new TextBox();
                TextBox txtemail = new TextBox();
                RichTextBox txtphone = new RichTextBox();
                TextBox txtsug = new TextBox();

                txtuser.Size = new Size(250, 20);
                txtemail.Size = new Size(250, 20);
                txtphone.Size = new Size(250, 150);
                txtsug.Size = new Size(250, 20);

                txtuser.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 35);
                txtemail.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 105);
                txtphone.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 175);
                txtsug.Location = new Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 375);

                tabControl1.TabPages[1].Controls.Add(txtuser);
                tabControl1.TabPages[1].Controls.Add(txtemail);
                tabControl1.TabPages[1].Controls.Add(txtphone);
                tabControl1.TabPages[1].Controls.Add(txtsug);
                //История

                RichTextBox txtHistory = new RichTextBox();
                txtHistory.Location = new System.Drawing.Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 10);
                txtHistory.Size = new System.Drawing.Size(tabControl1.Size.Width - 20, tabControl1.Size.Height - 40);
                tabControl1.TabPages[2].Controls.Add(txtHistory);

                //Фото



                //Источник
                WebBrowser wb = new WebBrowser();
                Uri uri = new Uri(@"file://C:\Users\Jack\Desktop\Шикарный ОФИС на Фуникулёре — 105 кв. метров. [2].html");
                wb.Navigate(uri); 
                wb.Location = new System.Drawing.Point(tabControl1.Location.X + 10, tabControl1.Location.Y + 10);
                wb.Size = new System.Drawing.Size(tabControl1.Size.Width - 20, tabControl1.Size.Height - 40);
                tabControl1.TabPages[4].Controls.Add(wb);

//----------------------------------------------------------------------------------------------------------------------------------------
                tabControl1.Location = new System.Drawing.Point(button1.Location.X + button1.Width * 2, button1.Location.Y);

                
            }
            else
            { 

                button1.Text = ">";
                advancedDataGridView1.Width += Form1.ActiveForm.Width / 100 * 45;
                button1.Location = new System.Drawing.Point(advancedDataGridView1.Location.X + advancedDataGridView1.Width, advancedDataGridView1.Location.Y);

            }
        }

        /// <summary>
        /// On click show form for adding row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// On click delete selected rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable someDataTable = new DataTable();

            string connString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Tables;Integrated Security=True";
            SqlConnection oldb = new SqlConnection(connString);
            try
            {
                oldb.Open();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Ошибка подключения:{0}", se.Message);
                return;
            }
            SqlCommand cmd = new SqlCommand("Delete From TestTable" +
               " where TestID = @TestID", oldb);
            SqlParameter param = new SqlParameter();
            //задаем имя параметра
            param.ParameterName = "@TestID";
            //задаем значение параметра
            var removed = advancedDataGridView1.CurrentRow;
            param.Value = advancedDataGridView1.CurrentRow.Cells[0].Value;
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Int;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();

                //обновление таблицы
                advancedDataGridView1.Rows.Remove(removed);
                advancedDataGridView1.Refresh();
            }
            catch
            {
                Console.Write("(((");
            }


            
        }

        //}
        /// <summary>
        /// On click compares some rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in advancedDataGridView1.SelectedRows)
            {
                var q = c.Cells;
                string rrrrr = "";
                foreach (DataGridViewCell m in q)
                {
                    rrrrr = rrrrr + m.Value;
                }
                MessageBox.Show(null, rrrrr, "1111");
            }
        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.testTableBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.testTableBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }
    }
}
