namespace DataGrid
{
    partial class GridDepartamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridDepart = new DataGridView();
            txtPesquisarDepart = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridDepart).BeginInit();
            SuspendLayout();
            // 
            // dataGridDepart
            // 
            dataGridDepart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDepart.Location = new Point(12, 88);
            dataGridDepart.Name = "dataGridDepart";
            dataGridDepart.RowTemplate.Height = 25;
            dataGridDepart.Size = new Size(776, 238);
            dataGridDepart.TabIndex = 0;
            dataGridDepart.CellDoubleClick += dataGridDepart_CellDoubleClick;
            // 
            // txtPesquisarDepart
            // 
            txtPesquisarDepart.Location = new Point(12, 59);
            txtPesquisarDepart.Name = "txtPesquisarDepart";
            txtPesquisarDepart.Size = new Size(347, 23);
            txtPesquisarDepart.TabIndex = 1;
            // 
            // GridDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPesquisarDepart);
            Controls.Add(dataGridDepart);
            Name = "GridDepartamentos";
            Text = "GridDepartamentos";
            Load += GridDepartamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridDepart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridDepart;
        private TextBox txtPesquisarDepart;
    }
}