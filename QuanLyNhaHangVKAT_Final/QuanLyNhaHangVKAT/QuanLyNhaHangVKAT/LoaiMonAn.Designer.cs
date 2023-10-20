namespace QuanLyNhaHangVKAT
{
    partial class LoaiMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiMonAn));
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.bntRemoveCategory = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCategory = new System.Windows.Forms.Button();
            this.btnLuuCategory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.White;
            this.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditCategory.Location = new System.Drawing.Point(255, 59);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(97, 42);
            this.btnEditCategory.TabIndex = 5;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddCategory.Location = new System.Drawing.Point(99, 59);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(115, 42);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // bntRemoveCategory
            // 
            this.bntRemoveCategory.BackColor = System.Drawing.Color.White;
            this.bntRemoveCategory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bntRemoveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.bntRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRemoveCategory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRemoveCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntRemoveCategory.Location = new System.Drawing.Point(403, 59);
            this.bntRemoveCategory.Margin = new System.Windows.Forms.Padding(4);
            this.bntRemoveCategory.Name = "bntRemoveCategory";
            this.bntRemoveCategory.Size = new System.Drawing.Size(97, 42);
            this.bntRemoveCategory.TabIndex = 4;
            this.bntRemoveCategory.Text = "Xóa";
            this.bntRemoveCategory.UseVisualStyleBackColor = false;
            this.bntRemoveCategory.Click += new System.EventHandler(this.bntRemoveCategory_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(615, 140);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 102;
            this.dgvCategory.Size = new System.Drawing.Size(534, 364);
            this.dgvCategory.TabIndex = 11;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCategoryName.Location = new System.Drawing.Point(234, 97);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(191, 26);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Location = new System.Drawing.Point(7, 95);
            this.txtIdCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.ReadOnly = true;
            this.txtIdCategory.Size = new System.Drawing.Size(191, 26);
            this.txtIdCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh sách loại món ăn ";
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCategory.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancelCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCategory.Image")));
            this.btnCancelCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelCategory.Location = new System.Drawing.Point(834, 529);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Size = new System.Drawing.Size(143, 42);
            this.btnCancelCategory.TabIndex = 129;
            this.btnCancelCategory.Text = "   Hủy bỏ";
            this.btnCancelCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelCategory.UseVisualStyleBackColor = true;
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // btnLuuCategory
            // 
            this.btnLuuCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCategory.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLuuCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuuCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCategory.Image")));
            this.btnLuuCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuuCategory.Location = new System.Drawing.Point(1030, 529);
            this.btnLuuCategory.Name = "btnLuuCategory";
            this.btnLuuCategory.Size = new System.Drawing.Size(119, 42);
            this.btnLuuCategory.TabIndex = 128;
            this.btnLuuCategory.Text = "   Lưu";
            this.btnLuuCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuCategory.UseVisualStyleBackColor = true;
            this.btnLuuCategory.Click += new System.EventHandler(this.btnLuuCategory_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 40);
            this.button2.TabIndex = 31;
            this.button2.Text = "     ID";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFood.FlatAppearance.BorderSize = 0;
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.Location = new System.Drawing.Point(234, 33);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(153, 40);
            this.btnSearchFood.TabIndex = 30;
            this.btnSearchFood.Text = "     Tên loại";
            this.btnSearchFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchFood);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Controls.Add(this.txtIdCategory);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 147);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại món ăn";
            // 
            // LoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelCategory);
            this.Controls.Add(this.btnLuuCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.bntRemoveCategory);
            this.Controls.Add(this.dgvCategory);
            this.Name = "LoaiMonAn";
            this.Size = new System.Drawing.Size(1244, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button bntRemoveCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtIdCategory;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelCategory;
        private System.Windows.Forms.Button btnLuuCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
