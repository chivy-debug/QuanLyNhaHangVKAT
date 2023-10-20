namespace QuanLyNhaHangVKAT
{
    partial class doanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doanhThu));
            this.txtTotalDoanhThu = new System.Windows.Forms.TextBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalDoanhThu
            // 
            this.txtTotalDoanhThu.AcceptsReturn = true;
            this.txtTotalDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTotalDoanhThu.Location = new System.Drawing.Point(383, 510);
            this.txtTotalDoanhThu.Name = "txtTotalDoanhThu";
            this.txtTotalDoanhThu.ReadOnly = true;
            this.txtTotalDoanhThu.Size = new System.Drawing.Size(169, 27);
            this.txtTotalDoanhThu.TabIndex = 10;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(138, 136);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 102;
            this.dgvThongKe.Size = new System.Drawing.Size(999, 340);
            this.dgvThongKe.TabIndex = 6;
            // 
            // dtOut
            // 
            this.dtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOut.Location = new System.Drawing.Point(872, 80);
            this.dtOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(265, 26);
            this.dtOut.TabIndex = 2;
            // 
            // dtIn
            // 
            this.dtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIn.Location = new System.Drawing.Point(138, 80);
            this.dtIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(265, 26);
            this.dtIn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Doanh thu nhà hàng";
            // 
            // btnThongke
            // 
            this.btnThongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(546, 71);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(200, 40);
            this.btnThongke.TabIndex = 30;
            this.btnThongke.Text = "     Tìm kiếm";
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 59);
            this.button1.TabIndex = 27;
            this.button1.Text = "     Tổng doanh thu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // doanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.txtTotalDoanhThu);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "doanhThu";
            this.Size = new System.Drawing.Size(1244, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalDoanhThu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label label1;
    }
}
