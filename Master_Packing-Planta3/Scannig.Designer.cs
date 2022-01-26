
namespace Master_Packing
{
    partial class Scannig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scannig));
            this.lbl_WO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_PN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Scan = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.gv_Scan = new System.Windows.Forms.DataGridView();
            this.lbl_Emp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_CountRecords = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PrintParcial = new System.Windows.Forms.Button();
            this.lbl_TotalBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Rev = new System.Windows.Forms.Label();
            this.asdas = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.lbl_actualBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Scan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_WO
            // 
            this.lbl_WO.AutoSize = true;
            this.lbl_WO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WO.Location = new System.Drawing.Point(332, 9);
            this.lbl_WO.Name = "lbl_WO";
            this.lbl_WO.Size = new System.Drawing.Size(87, 16);
            this.lbl_WO.TabIndex = 27;
            this.lbl_WO.Text = "Work Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Work Order:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(752, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "SCAN:";
            // 
            // lbl_PN
            // 
            this.lbl_PN.AutoSize = true;
            this.lbl_PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PN.Location = new System.Drawing.Point(96, 9);
            this.lbl_PN.Name = "lbl_PN";
            this.lbl_PN.Size = new System.Drawing.Size(59, 16);
            this.lbl_PN.TabIndex = 24;
            this.lbl_PN.Text = "Part N#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Part N#:";
            // 
            // txt_Scan
            // 
            this.txt_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Scan.Location = new System.Drawing.Point(815, 108);
            this.txt_Scan.Name = "txt_Scan";
            this.txt_Scan.Size = new System.Drawing.Size(445, 26);
            this.txt_Scan.TabIndex = 22;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.Location = new System.Drawing.Point(967, 152);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(86, 32);
            this.btn_Submit.TabIndex = 28;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            this.btn_Submit.Enter += new System.EventHandler(this.btn_Submit_Enter);
            // 
            // gv_Scan
            // 
            this.gv_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Scan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Scan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Scan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Scan.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Scan.Location = new System.Drawing.Point(12, 234);
            this.gv_Scan.Name = "gv_Scan";
            this.gv_Scan.Size = new System.Drawing.Size(1763, 569);
            this.gv_Scan.TabIndex = 21;
            this.gv_Scan.TabStop = false;
            // 
            // lbl_Emp
            // 
            this.lbl_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Emp.AutoSize = true;
            this.lbl_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp.Location = new System.Drawing.Point(746, 9);
            this.lbl_Emp.Name = "lbl_Emp";
            this.lbl_Emp.Size = new System.Drawing.Size(78, 16);
            this.lbl_Emp.TabIndex = 30;
            this.lbl_Emp.Text = "Employee";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Employee:";
            // 
            // lbl_CountRecords
            // 
            this.lbl_CountRecords.AutoSize = true;
            this.lbl_CountRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountRecords.Location = new System.Drawing.Point(89, 215);
            this.lbl_CountRecords.Name = "lbl_CountRecords";
            this.lbl_CountRecords.Size = new System.Drawing.Size(44, 16);
            this.lbl_CountRecords.TabIndex = 32;
            this.lbl_CountRecords.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Records:";
            // 
            // btn_PrintParcial
            // 
            this.btn_PrintParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PrintParcial.Location = new System.Drawing.Point(1689, 199);
            this.btn_PrintParcial.Name = "btn_PrintParcial";
            this.btn_PrintParcial.Size = new System.Drawing.Size(86, 32);
            this.btn_PrintParcial.TabIndex = 33;
            this.btn_PrintParcial.TabStop = false;
            this.btn_PrintParcial.Text = "Parcial";
            this.btn_PrintParcial.UseVisualStyleBackColor = true;
            this.btn_PrintParcial.Click += new System.EventHandler(this.btn_PrintParcial_Click);
            // 
            // lbl_TotalBox
            // 
            this.lbl_TotalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalBox.AutoSize = true;
            this.lbl_TotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBox.Location = new System.Drawing.Point(1451, 215);
            this.lbl_TotalBox.Name = "lbl_TotalBox";
            this.lbl_TotalBox.Size = new System.Drawing.Size(44, 16);
            this.lbl_TotalBox.TabIndex = 35;
            this.lbl_TotalBox.Text = "Total";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1344, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Box Records:";
            // 
            // lbl_Rev
            // 
            this.lbl_Rev.AutoSize = true;
            this.lbl_Rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rev.Location = new System.Drawing.Point(1000, 9);
            this.lbl_Rev.Name = "lbl_Rev";
            this.lbl_Rev.Size = new System.Drawing.Size(69, 16);
            this.lbl_Rev.TabIndex = 37;
            this.lbl_Rev.Text = "Revision";
            // 
            // asdas
            // 
            this.asdas.AutoSize = true;
            this.asdas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdas.Location = new System.Drawing.Point(921, 9);
            this.asdas.Name = "asdas";
            this.asdas.Size = new System.Drawing.Size(73, 16);
            this.asdas.TabIndex = 36;
            this.asdas.Text = "Revision:";
            // 
            // picLoader
            // 
            this.picLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.Location = new System.Drawing.Point(713, 386);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(269, 210);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoader.TabIndex = 38;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // lbl_actualBox
            // 
            this.lbl_actualBox.AutoSize = true;
            this.lbl_actualBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualBox.Location = new System.Drawing.Point(206, 114);
            this.lbl_actualBox.Name = "lbl_actualBox";
            this.lbl_actualBox.Size = new System.Drawing.Size(44, 16);
            this.lbl_actualBox.TabIndex = 40;
            this.lbl_actualBox.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Actual Box:";
            // 
            // Scannig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 815);
            this.Controls.Add(this.lbl_actualBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picLoader);
            this.Controls.Add(this.lbl_Rev);
            this.Controls.Add(this.asdas);
            this.Controls.Add(this.lbl_TotalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_PrintParcial);
            this.Controls.Add(this.lbl_CountRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Emp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_WO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_PN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Scan);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.gv_Scan);
            this.Name = "Scannig";
            this.Text = "Scannig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Scannig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Scan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_PN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Scan;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DataGridView gv_Scan;
        private System.Windows.Forms.Label lbl_Emp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_CountRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PrintParcial;
        private System.Windows.Forms.Label lbl_TotalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Rev;
        private System.Windows.Forms.Label asdas;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.Label lbl_actualBox;
        private System.Windows.Forms.Label label8;
    }
}