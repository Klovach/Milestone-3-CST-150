namespace Milestone_3_CST_150
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRestockName = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtNewQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtSearchByPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchByPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRestockNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(811, 561);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 32);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(846, 20);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 12;
            this.txtEmployeeID.Text = "230939983";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Store ID";
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(846, 48);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(100, 22);
            this.txtStoreID.TabIndex = 14;
            this.txtStoreID.Text = "103";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(846, 76);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 16;
            this.txtDate.Text = "9/15/2022";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(591, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 61);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(592, 514);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(96, 16);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Delete Product";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Location = new System.Drawing.Point(588, 89);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(106, 16);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Restock Product";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtRestockName
            // 
            this.txtRestockName.Location = new System.Drawing.Point(591, 108);
            this.txtRestockName.Name = "txtRestockName";
            this.txtRestockName.Size = new System.Drawing.Size(133, 22);
            this.txtRestockName.TabIndex = 24;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(591, 284);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(137, 22);
            this.txtNewName.TabIndex = 23;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(590, 264);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(123, 16);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "New Product Name";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(595, 533);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(129, 22);
            this.txtDelete.TabIndex = 31;
            // 
            // txtNewQuantity
            // 
            this.txtNewQuantity.Location = new System.Drawing.Point(595, 345);
            this.txtNewQuantity.Name = "txtNewQuantity";
            this.txtNewQuantity.Size = new System.Drawing.Size(133, 22);
            this.txtNewQuantity.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "New Product Quantity";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(595, 405);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(133, 22);
            this.txtNewPrice.TabIndex = 35;
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(594, 385);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(117, 16);
            this.lblNewPrice.TabIndex = 34;
            this.lblNewPrice.Text = "New Product Price";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(815, 522);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 33);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear Values";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDisplay.Location = new System.Drawing.Point(33, 92);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(543, 490);
            this.txtDisplay.TabIndex = 38;
            this.txtDisplay.Text = "";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(35, 64);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(244, 22);
            this.txtSearchByName.TabIndex = 40;
            // 
            // txtSearchByPrice
            // 
            this.txtSearchByPrice.Location = new System.Drawing.Point(389, 64);
            this.txtSearchByPrice.Name = "txtSearchByPrice";
            this.txtSearchByPrice.Size = new System.Drawing.Size(108, 22);
            this.txtSearchByPrice.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(595, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 25);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(591, 194);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(133, 57);
            this.btnRestock.TabIndex = 44;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Search By Name";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(285, 61);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(79, 25);
            this.btnSearchByName.TabIndex = 46;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchByPrice
            // 
            this.btnSearchByPrice.Location = new System.Drawing.Point(503, 61);
            this.btnSearchByPrice.Name = "btnSearchByPrice";
            this.btnSearchByPrice.Size = new System.Drawing.Size(73, 25);
            this.btnSearchByPrice.TabIndex = 47;
            this.btnSearchByPrice.Text = "Search";
            this.btnSearchByPrice.UseVisualStyleBackColor = true;
            this.btnSearchByPrice.Click += new System.EventHandler(this.btnSearchByPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Search By Price";
            // 
            // txtRestockNum
            // 
            this.txtRestockNum.Location = new System.Drawing.Point(591, 166);
            this.txtRestockNum.Name = "txtRestockNum";
            this.txtRestockNum.Size = new System.Drawing.Size(133, 22);
            this.txtRestockNum.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "New Product Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 607);
            this.Controls.Add(this.txtRestockNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchByPrice);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearchByPrice);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.txtNewQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtRestockName);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Milestone 3 - CST-150";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCost;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TextBox txtRestockName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox txtNewQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchByPrice;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchByPrice;
        private System.Windows.Forms.TextBox txtRestockNum;
        private System.Windows.Forms.Label label7;
    }
}


