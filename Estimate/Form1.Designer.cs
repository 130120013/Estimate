using System.Windows.Forms;

namespace Estimate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.tablesDataSet2 = new Estimate.TablesDataSet2();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableTableAdapter = new Estimate.TablesDataSet2TableAdapters.TestTableTableAdapter();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1052, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 453);
            this.button1.TabIndex = 1;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 88);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 88);
            this.button4.TabIndex = 4;
            this.button4.Text = "Экспорт в Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(914, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 88);
            this.button5.TabIndex = 5;
            this.button5.Text = "Поиск дублирующихся записей\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(758, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 88);
            this.button6.TabIndex = 6;
            this.button6.Text = "Мои выборки";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(605, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 88);
            this.button7.TabIndex = 7;
            this.button7.Text = "Сравнить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(452, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 88);
            this.button8.TabIndex = 8;
            this.button8.Text = "Статистика";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.randomFieldDataGridViewTextBoxColumn,
            this.r1DataGridViewTextBoxColumn,
            this.r2DataGridViewTextBoxColumn,
            this.r3DataGridViewTextBoxColumn,
            this.r4DataGridViewTextBoxColumn,
            this.r5DataGridViewTextBoxColumn,
            this.r7DataGridViewTextBoxColumn,
            this.r8DataGridViewTextBoxColumn,
            this.r6DataGridViewTextBoxColumn,
            this.r9DataGridViewTextBoxColumn,
            this.r10DataGridViewTextBoxColumn,
            this.r11DataGridViewTextBoxColumn,
            this.r12DataGridViewTextBoxColumn,
            this.r13DataGridViewTextBoxColumn,
            this.r14DataGridViewTextBoxColumn,
            this.r15DataGridViewTextBoxColumn,
            this.r16DataGridViewTextBoxColumn,
            this.r17DataGridViewTextBoxColumn,
            this.r18DataGridViewTextBoxColumn,
            this.r19DataGridViewTextBoxColumn,
            this.r20DataGridViewTextBoxColumn,
            this.r21DataGridViewTextBoxColumn,
            this.r22DataGridViewTextBoxColumn,
            this.r23DataGridViewTextBoxColumn,
            this.r24DataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.testTableBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 162);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(1042, 453);
            this.advancedDataGridView1.TabIndex = 10;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // tablesDataSet2
            // 
            this.tablesDataSet2.DataSetName = "TablesDataSet2";
            this.tablesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            this.testTableBindingSource.DataSource = this.tablesDataSet2;
            // 
            // testTableTableAdapter
            // 
            this.testTableTableAdapter.ClearBeforeFill = true;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "TestID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "TestID";
            this.testIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // randomFieldDataGridViewTextBoxColumn
            // 
            this.randomFieldDataGridViewTextBoxColumn.DataPropertyName = "RandomField";
            this.randomFieldDataGridViewTextBoxColumn.HeaderText = "RandomField";
            this.randomFieldDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.randomFieldDataGridViewTextBoxColumn.Name = "randomFieldDataGridViewTextBoxColumn";
            this.randomFieldDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r1DataGridViewTextBoxColumn
            // 
            this.r1DataGridViewTextBoxColumn.DataPropertyName = "R1";
            this.r1DataGridViewTextBoxColumn.HeaderText = "R1";
            this.r1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r1DataGridViewTextBoxColumn.Name = "r1DataGridViewTextBoxColumn";
            this.r1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r2DataGridViewTextBoxColumn
            // 
            this.r2DataGridViewTextBoxColumn.DataPropertyName = "r2";
            this.r2DataGridViewTextBoxColumn.HeaderText = "r2";
            this.r2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r2DataGridViewTextBoxColumn.Name = "r2DataGridViewTextBoxColumn";
            this.r2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r3DataGridViewTextBoxColumn
            // 
            this.r3DataGridViewTextBoxColumn.DataPropertyName = "r3";
            this.r3DataGridViewTextBoxColumn.HeaderText = "r3";
            this.r3DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r3DataGridViewTextBoxColumn.Name = "r3DataGridViewTextBoxColumn";
            this.r3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r4DataGridViewTextBoxColumn
            // 
            this.r4DataGridViewTextBoxColumn.DataPropertyName = "r4";
            this.r4DataGridViewTextBoxColumn.HeaderText = "r4";
            this.r4DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r4DataGridViewTextBoxColumn.Name = "r4DataGridViewTextBoxColumn";
            this.r4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r5DataGridViewTextBoxColumn
            // 
            this.r5DataGridViewTextBoxColumn.DataPropertyName = "r5";
            this.r5DataGridViewTextBoxColumn.HeaderText = "r5";
            this.r5DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r5DataGridViewTextBoxColumn.Name = "r5DataGridViewTextBoxColumn";
            this.r5DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r7DataGridViewTextBoxColumn
            // 
            this.r7DataGridViewTextBoxColumn.DataPropertyName = "r7";
            this.r7DataGridViewTextBoxColumn.HeaderText = "r7";
            this.r7DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r7DataGridViewTextBoxColumn.Name = "r7DataGridViewTextBoxColumn";
            this.r7DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r8DataGridViewTextBoxColumn
            // 
            this.r8DataGridViewTextBoxColumn.DataPropertyName = "r8";
            this.r8DataGridViewTextBoxColumn.HeaderText = "r8";
            this.r8DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r8DataGridViewTextBoxColumn.Name = "r8DataGridViewTextBoxColumn";
            this.r8DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r6DataGridViewTextBoxColumn
            // 
            this.r6DataGridViewTextBoxColumn.DataPropertyName = "r6";
            this.r6DataGridViewTextBoxColumn.HeaderText = "r6";
            this.r6DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r6DataGridViewTextBoxColumn.Name = "r6DataGridViewTextBoxColumn";
            this.r6DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r9DataGridViewTextBoxColumn
            // 
            this.r9DataGridViewTextBoxColumn.DataPropertyName = "r9";
            this.r9DataGridViewTextBoxColumn.HeaderText = "r9";
            this.r9DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r9DataGridViewTextBoxColumn.Name = "r9DataGridViewTextBoxColumn";
            this.r9DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r10DataGridViewTextBoxColumn
            // 
            this.r10DataGridViewTextBoxColumn.DataPropertyName = "r10";
            this.r10DataGridViewTextBoxColumn.HeaderText = "r10";
            this.r10DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r10DataGridViewTextBoxColumn.Name = "r10DataGridViewTextBoxColumn";
            this.r10DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r11DataGridViewTextBoxColumn
            // 
            this.r11DataGridViewTextBoxColumn.DataPropertyName = "r11";
            this.r11DataGridViewTextBoxColumn.HeaderText = "r11";
            this.r11DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r11DataGridViewTextBoxColumn.Name = "r11DataGridViewTextBoxColumn";
            this.r11DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r12DataGridViewTextBoxColumn
            // 
            this.r12DataGridViewTextBoxColumn.DataPropertyName = "r12";
            this.r12DataGridViewTextBoxColumn.HeaderText = "r12";
            this.r12DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r12DataGridViewTextBoxColumn.Name = "r12DataGridViewTextBoxColumn";
            this.r12DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r13DataGridViewTextBoxColumn
            // 
            this.r13DataGridViewTextBoxColumn.DataPropertyName = "r13";
            this.r13DataGridViewTextBoxColumn.HeaderText = "r13";
            this.r13DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r13DataGridViewTextBoxColumn.Name = "r13DataGridViewTextBoxColumn";
            this.r13DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r14DataGridViewTextBoxColumn
            // 
            this.r14DataGridViewTextBoxColumn.DataPropertyName = "r14";
            this.r14DataGridViewTextBoxColumn.HeaderText = "r14";
            this.r14DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r14DataGridViewTextBoxColumn.Name = "r14DataGridViewTextBoxColumn";
            this.r14DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r15DataGridViewTextBoxColumn
            // 
            this.r15DataGridViewTextBoxColumn.DataPropertyName = "r15";
            this.r15DataGridViewTextBoxColumn.HeaderText = "r15";
            this.r15DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r15DataGridViewTextBoxColumn.Name = "r15DataGridViewTextBoxColumn";
            this.r15DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r16DataGridViewTextBoxColumn
            // 
            this.r16DataGridViewTextBoxColumn.DataPropertyName = "r16";
            this.r16DataGridViewTextBoxColumn.HeaderText = "r16";
            this.r16DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r16DataGridViewTextBoxColumn.Name = "r16DataGridViewTextBoxColumn";
            this.r16DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r17DataGridViewTextBoxColumn
            // 
            this.r17DataGridViewTextBoxColumn.DataPropertyName = "r17";
            this.r17DataGridViewTextBoxColumn.HeaderText = "r17";
            this.r17DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r17DataGridViewTextBoxColumn.Name = "r17DataGridViewTextBoxColumn";
            this.r17DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r18DataGridViewTextBoxColumn
            // 
            this.r18DataGridViewTextBoxColumn.DataPropertyName = "r18";
            this.r18DataGridViewTextBoxColumn.HeaderText = "r18";
            this.r18DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r18DataGridViewTextBoxColumn.Name = "r18DataGridViewTextBoxColumn";
            this.r18DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r19DataGridViewTextBoxColumn
            // 
            this.r19DataGridViewTextBoxColumn.DataPropertyName = "r19";
            this.r19DataGridViewTextBoxColumn.HeaderText = "r19";
            this.r19DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r19DataGridViewTextBoxColumn.Name = "r19DataGridViewTextBoxColumn";
            this.r19DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r20DataGridViewTextBoxColumn
            // 
            this.r20DataGridViewTextBoxColumn.DataPropertyName = "r20";
            this.r20DataGridViewTextBoxColumn.HeaderText = "r20";
            this.r20DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r20DataGridViewTextBoxColumn.Name = "r20DataGridViewTextBoxColumn";
            this.r20DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r21DataGridViewTextBoxColumn
            // 
            this.r21DataGridViewTextBoxColumn.DataPropertyName = "r21";
            this.r21DataGridViewTextBoxColumn.HeaderText = "r21";
            this.r21DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r21DataGridViewTextBoxColumn.Name = "r21DataGridViewTextBoxColumn";
            this.r21DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r22DataGridViewTextBoxColumn
            // 
            this.r22DataGridViewTextBoxColumn.DataPropertyName = "r22";
            this.r22DataGridViewTextBoxColumn.HeaderText = "r22";
            this.r22DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r22DataGridViewTextBoxColumn.Name = "r22DataGridViewTextBoxColumn";
            this.r22DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r23DataGridViewTextBoxColumn
            // 
            this.r23DataGridViewTextBoxColumn.DataPropertyName = "r23";
            this.r23DataGridViewTextBoxColumn.HeaderText = "r23";
            this.r23DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r23DataGridViewTextBoxColumn.Name = "r23DataGridViewTextBoxColumn";
            this.r23DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // r24DataGridViewTextBoxColumn
            // 
            this.r24DataGridViewTextBoxColumn.DataPropertyName = "r24";
            this.r24DataGridViewTextBoxColumn.HeaderText = "r24";
            this.r24DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.r24DataGridViewTextBoxColumn.Name = "r24DataGridViewTextBoxColumn";
            this.r24DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 627);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private TablesDataSet2 tablesDataSet2;
        private BindingSource testTableBindingSource;
        private TablesDataSet2TableAdapters.TestTableTableAdapter testTableTableAdapter;
        private DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn randomFieldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r9DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r10DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r11DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r12DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r13DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r14DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r15DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r16DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r17DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r18DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r19DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r20DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r21DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r22DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r23DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn r24DataGridViewTextBoxColumn;
    }
}

