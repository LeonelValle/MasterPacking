
namespace Master_Packing
{
    partial class Reports
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.dg_Report = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "YYYY-MM-DD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(44, 93);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(320, 20);
            this.txt_Search.TabIndex = 12;
            // 
            // cb_filter
            // 
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Work Order",
            "Serial Number",
            "Date Packing",
            "Part NO#"});
            this.cb_filter.Location = new System.Drawing.Point(44, 42);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(320, 21);
            this.cb_filter.TabIndex = 11;
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(1515, 116);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(92, 36);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(410, 93);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // dg_Report
            // 
            this.dg_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Report.Location = new System.Drawing.Point(12, 158);
            this.dg_Report.Name = "dg_Report";
            this.dg_Report.Size = new System.Drawing.Size(1595, 631);
            this.dg_Report.TabIndex = 8;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 801);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dg_Report);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DataGridView dg_Report;
    }
}