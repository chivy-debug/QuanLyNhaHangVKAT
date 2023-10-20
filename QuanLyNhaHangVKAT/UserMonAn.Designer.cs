namespace QuanLyNhaHangVKAT
{
    partial class UserMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMonAn));
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnFoodWatch = new System.Windows.Forms.Button();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnCancelFood = new System.Windows.Forms.Button();
            this.btnLuuFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemoveFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnRemoveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveFood.Location = new System.Drawing.Point(981, 42);
            this.btnRemoveFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(97, 42);
            this.btnRemoveFood.TabIndex = 4;
            this.btnRemoveFood.Text = "Xóa";
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAddFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddFood.Location = new System.Drawing.Point(678, 42);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(115, 42);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEditFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEditFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditFood.Location = new System.Drawing.Point(840, 42);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(97, 42);
            this.btnEditFood.TabIndex = 5;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnFoodWatch
            // 
            this.btnFoodWatch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFoodWatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnFoodWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFoodWatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFoodWatch.Location = new System.Drawing.Point(527, 42);
            this.btnFoodWatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoodWatch.Name = "btnFoodWatch";
            this.btnFoodWatch.Size = new System.Drawing.Size(91, 42);
            this.btnFoodWatch.TabIndex = 6;
            this.btnFoodWatch.Text = "Tải lại";
            this.btnFoodWatch.UseVisualStyleBackColor = true;
            this.btnFoodWatch.Click += new System.EventHandler(this.btnFoodWatch_Click);
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmFoodPrice.Location = new System.Drawing.Point(226, 249);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(96, 26);
            this.nmFoodPrice.TabIndex = 20;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(226, 174);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(208, 28);
            this.cbFoodCategory.TabIndex = 23;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(224, 103);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(210, 23);
            this.txtFoodName.TabIndex = 21;
            // 
            // txtFoodId
            // 
            this.txtFoodId.BackColor = System.Drawing.SystemColors.Control;
            this.txtFoodId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodId.Location = new System.Drawing.Point(226, 52);
            this.txtFoodId.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(134, 23);
            this.txtFoodId.TabIndex = 22;
            this.txtFoodId.TextChanged += new System.EventHandler(this.txtFoodId_TextChanged);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.Location = new System.Drawing.Point(255, 52);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(195, 19);
            this.txtSearchFood.TabIndex = 24;
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(62, 109);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 102;
            this.dgvFood.Size = new System.Drawing.Size(556, 440);
            this.dgvFood.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtFoodId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtFoodName);
            this.groupBox1.Controls.Add(this.nmFoodPrice);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cbFoodCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(678, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 318);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 43);
            this.button2.TabIndex = 25;
            this.button2.Text = "     ID";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "     Tên thức ăn";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(15, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "     Giá";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 40);
            this.button3.TabIndex = 27;
            this.button3.Text = "     Danh mục";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFood.FlatAppearance.BorderSize = 0;
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.Location = new System.Drawing.Point(73, 31);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(175, 61);
            this.btnSearchFood.TabIndex = 29;
            this.btnSearchFood.Text = "     Tìm kiếm";
            this.btnSearchFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnCancelFood
            // 
            this.btnCancelFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelFood.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancelFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFood.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelFood.Image")));
            this.btnCancelFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelFood.Location = new System.Drawing.Point(825, 507);
            this.btnCancelFood.Name = "btnCancelFood";
            this.btnCancelFood.Size = new System.Drawing.Size(143, 42);
            this.btnCancelFood.TabIndex = 19;
            this.btnCancelFood.Text = "   Hủy bỏ";
            this.btnCancelFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelFood.UseVisualStyleBackColor = true;
            this.btnCancelFood.Click += new System.EventHandler(this.btnCancelFood_Click);
            // 
            // btnLuuFood
            // 
            this.btnLuuFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuFood.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLuuFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuuFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuFood.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuFood.Image")));
            this.btnLuuFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuuFood.Location = new System.Drawing.Point(1023, 507);
            this.btnLuuFood.Name = "btnLuuFood";
            this.btnLuuFood.Size = new System.Drawing.Size(119, 42);
            this.btnLuuFood.TabIndex = 18;
            this.btnLuuFood.Text = "   Lưu";
            this.btnLuuFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuFood.UseVisualStyleBackColor = true;
            this.btnLuuFood.Click += new System.EventHandler(this.btnLuuFood_Click);
            // 
            // UserMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.btnCancelFood);
            this.Controls.Add(this.btnLuuFood);
            this.Controls.Add(this.btnFoodWatch);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.btnAddFood);
            this.Name = "UserMonAn";
            this.Size = new System.Drawing.Size(1244, 597);
            this.Load += new System.EventHandler(this.UserMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnFoodWatch;
        private System.Windows.Forms.Button btnLuuFood;
        private System.Windows.Forms.Button btnCancelFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
