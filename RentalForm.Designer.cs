namespace WFA24011501
{
    partial class RentalForm
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
            lblUI01 = new Label();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            cbxKoboldNames = new ComboBox();
            nudDays = new NumericUpDown();
            dtpStartDate = new DateTimePicker();
            dgvBikes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnNewRent = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBikes).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 24);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(185, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "select customer by name:";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 92);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(181, 21);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "start of the rental period:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 169);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(122, 21);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "number of days:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(12, 248);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(107, 21);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "choose a bike:";
            // 
            // cbxKoboldNames
            // 
            cbxKoboldNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKoboldNames.FormattingEnabled = true;
            cbxKoboldNames.Location = new Point(12, 48);
            cbxKoboldNames.Name = "cbxKoboldNames";
            cbxKoboldNames.Size = new Size(333, 29);
            cbxKoboldNames.TabIndex = 1;
            // 
            // nudDays
            // 
            nudDays.Location = new Point(13, 194);
            nudDays.Margin = new Padding(4);
            nudDays.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDays.Name = "nudDays";
            nudDays.Size = new Size(332, 29);
            nudDays.TabIndex = 2;
            nudDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(12, 116);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(333, 29);
            dtpStartDate.TabIndex = 3;
            // 
            // dgvBikes
            // 
            dgvBikes.AllowUserToAddRows = false;
            dgvBikes.AllowUserToDeleteRows = false;
            dgvBikes.AllowUserToResizeColumns = false;
            dgvBikes.AllowUserToResizeRows = false;
            dgvBikes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBikes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBikes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBikes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvBikes.Location = new Point(12, 272);
            dgvBikes.Name = "dgvBikes";
            dgvBikes.RowHeadersVisible = false;
            dgvBikes.RowTemplate.Height = 25;
            dgvBikes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBikes.Size = new Size(333, 187);
            dgvBikes.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 2F;
            Column2.HeaderText = "type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 2F;
            Column3.HeaderText = "color";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 1F;
            Column4.HeaderText = "size";
            Column4.Name = "Column4";
            // 
            // btnNewRent
            // 
            btnNewRent.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewRent.Location = new Point(12, 480);
            btnNewRent.Name = "btnNewRent";
            btnNewRent.Size = new Size(333, 48);
            btnNewRent.TabIndex = 5;
            btnNewRent.Text = "new rental";
            btnNewRent.UseVisualStyleBackColor = true;
            // 
            // RentalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 540);
            Controls.Add(btnNewRent);
            Controls.Add(dgvBikes);
            Controls.Add(dtpStartDate);
            Controls.Add(nudDays);
            Controls.Add(cbxKoboldNames);
            Controls.Add(lblUI04);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "RentalForm";
            Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBikes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblUI04;
        private ComboBox cbxKoboldNames;
        private NumericUpDown nudDays;
        private DateTimePicker dtpStartDate;
        private DataGridView dgvBikes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnNewRent;
    }
}