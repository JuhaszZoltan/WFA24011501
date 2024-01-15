namespace WFA24011501
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewRent = new Button();
            cbxType = new ComboBox();
            dgvRents = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lblUI01 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRents).BeginInit();
            SuspendLayout();
            // 
            // btnNewRent
            // 
            btnNewRent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewRent.ForeColor = Color.ForestGreen;
            btnNewRent.Location = new Point(12, 22);
            btnNewRent.Name = "btnNewRent";
            btnNewRent.Size = new Size(448, 53);
            btnNewRent.TabIndex = 0;
            btnNewRent.Text = "ADD NEW RENT";
            btnNewRent.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(496, 46);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(264, 29);
            cbxType.TabIndex = 1;
            // 
            // dgvRents
            // 
            dgvRents.AllowUserToAddRows = false;
            dgvRents.AllowUserToDeleteRows = false;
            dgvRents.AllowUserToResizeColumns = false;
            dgvRents.AllowUserToResizeRows = false;
            dgvRents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRents.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvRents.Location = new Point(12, 96);
            dgvRents.Name = "dgvRents";
            dgvRents.RowHeadersVisible = false;
            dgvRents.RowTemplate.Height = 25;
            dgvRents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRents.Size = new Size(748, 310);
            dgvRents.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "Customer";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 1F;
            Column2.HeaderText = "koboldID";
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.FillWeight = 3F;
            Column3.HeaderText = "Bike";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "Start";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 2F;
            Column5.HeaderText = "End";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 1F;
            Column6.HeaderText = "Price";
            Column6.Name = "Column6";
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(496, 22);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(166, 21);
            lblUI01.TabIndex = 3;
            lblUI01.Text = "filter for this type only:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 418);
            Controls.Add(lblUI01);
            Controls.Add(dgvRents);
            Controls.Add(cbxType);
            Controls.Add(btnNewRent);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Kobold Bikers 2023";
            ((System.ComponentModel.ISupportInitialize)dgvRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewRent;
        private ComboBox cbxType;
        private DataGridView dgvRents;
        private Label lblUI01;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
