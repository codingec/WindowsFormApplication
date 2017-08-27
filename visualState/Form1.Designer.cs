namespace visualState
{
    partial class Form1
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.lbproduct = new System.Windows.Forms.Label();
            this.lbdescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labprice = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.labquantity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(596, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(596, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(596, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(183, 14);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(181, 20);
            this.product.TabIndex = 3;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(183, 53);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(181, 20);
            this.description.TabIndex = 4;
            // 
            // lbproduct
            // 
            this.lbproduct.AutoSize = true;
            this.lbproduct.Location = new System.Drawing.Point(113, 17);
            this.lbproduct.Name = "lbproduct";
            this.lbproduct.Size = new System.Drawing.Size(52, 13);
            this.lbproduct.TabIndex = 5;
            this.lbproduct.Text = "Products:";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(113, 55);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(63, 13);
            this.lbdescription.TabIndex = 6;
            this.lbdescription.Text = "Description:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::visualState.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labprice
            // 
            this.labprice.AutoSize = true;
            this.labprice.Location = new System.Drawing.Point(113, 95);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(34, 13);
            this.labprice.TabIndex = 10;
            this.labprice.Text = "Price:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(183, 93);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(181, 20);
            this.price.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(183, 129);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(181, 20);
            this.quantity.TabIndex = 11;
            // 
            // labquantity
            // 
            this.labquantity.AutoSize = true;
            this.labquantity.Location = new System.Drawing.Point(113, 132);
            this.labquantity.Name = "labquantity";
            this.labquantity.Size = new System.Drawing.Size(49, 13);
            this.labquantity.TabIndex = 13;
            this.labquantity.Text = "Quantity:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 249);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.labprice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.lbproduct);
            this.Controls.Add(this.description);
            this.Controls.Add(this.product);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label lbproduct;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labquantity;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

