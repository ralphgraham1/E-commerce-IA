namespace Inventory_Management
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.PictureBox();
            this.btnOrders = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.PictureBox();
            this.btnCategories = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1264, 703);
            this.panelMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 703);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 601);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnProducts);
            this.panel4.Controls.Add(this.btnOrders);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnUsers);
            this.panel4.Controls.Add(this.btnCategories);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 601);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(111, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Orders";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(111, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Users";
            // 
            // btnProducts
            // 
            this.btnProducts.Image = global::Inventory_Management.Properties.Resources.trolley_96px1;
            this.btnProducts.Location = new System.Drawing.Point(32, 8);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(55, 46);
            this.btnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProducts.TabIndex = 3;
            this.btnProducts.TabStop = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Image = global::Inventory_Management.Properties.Resources.user_96px;
            this.btnOrders.Location = new System.Drawing.Point(32, 311);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(55, 46);
            this.btnOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOrders.TabIndex = 10;
            this.btnOrders.TabStop = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(111, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Products";
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::Inventory_Management.Properties.Resources.purchase_order_96px;
            this.btnUsers.Location = new System.Drawing.Point(32, 202);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(55, 46);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUsers.TabIndex = 12;
            this.btnUsers.TabStop = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Image = global::Inventory_Management.Properties.Resources.categorize_96px;
            this.btnCategories.Location = new System.Drawing.Point(32, 102);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(55, 46);
            this.btnCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCategories.TabIndex = 8;
            this.btnCategories.TabStop = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(111, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categories";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 81);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(640, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(520, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "hoprite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(456, -15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 105);
            this.label2.TabIndex = 1;
            this.label2.Text = "S";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(169)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 682);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 21);
            this.panel3.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 703);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}