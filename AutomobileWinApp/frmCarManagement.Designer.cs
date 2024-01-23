using System.Drawing;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            label1 = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            dgvCarList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(20, 20);
            lbCarID.Margin = new Padding(2, 0, 2, 0);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(20, 50);
            lbCarName.Margin = new Padding(2, 0, 2, 0);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(366, 20);
            lbPrice.Margin = new Padding(2, 0, 2, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(366, 50);
            lbReleaseYear.Margin = new Padding(2, 0, 2, 0);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(133, 17);
            txtCarID.Margin = new Padding(2);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(186, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(133, 50);
            txtCarName.Margin = new Padding(2);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(186, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(133, 80);
            txtManufacturer.Margin = new Padding(2);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(186, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(453, 17);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(453, 47);
            txtReleaseYear.Margin = new Padding(2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(204, 23);
            txtReleaseYear.TabIndex = 9;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(11, 165);
            dgvCarList.Margin = new Padding(2);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.RowTemplate.Height = 33;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(712, 182);
            dgvCarList.TabIndex = 13;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(133, 130);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(317, 130);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(483, 130);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(317, 351);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 384);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(label1);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Margin = new Padding(2);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label label1;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}