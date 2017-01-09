namespace Assignment7
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
            this.lblCusPath = new System.Windows.Forms.Label();
            this.txtCustFilePath = new System.Windows.Forms.TextBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnLoadCustom = new System.Windows.Forms.Button();
            this.lstOfCustomers = new System.Windows.Forms.ListBox();
            this.lblBoatFilePath = new System.Windows.Forms.Label();
            this.txtBoatFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadBoats = new System.Windows.Forms.Button();
            this.btnSaveBoats = new System.Windows.Forms.Button();
            this.lblBoats = new System.Windows.Forms.Label();
            this.lstOfBoats = new System.Windows.Forms.ListBox();
            this.lblCustomInfo = new System.Windows.Forms.Label();
            this.grBoxBoatsOwned = new System.Windows.Forms.GroupBox();
            this.lblBoatsOwned = new System.Windows.Forms.Label();
            this.lblBoatInfo = new System.Windows.Forms.Label();
            this.btnAssignBoat = new System.Windows.Forms.Button();
            this.grBoxBoatsOwned.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCusPath
            // 
            this.lblCusPath.AutoSize = true;
            this.lblCusPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPath.Location = new System.Drawing.Point(13, 13);
            this.lblCusPath.Name = "lblCusPath";
            this.lblCusPath.Size = new System.Drawing.Size(132, 16);
            this.lblCusPath.TabIndex = 0;
            this.lblCusPath.Text = "Customer file path";
            // 
            // txtCustFilePath
            // 
            this.txtCustFilePath.Location = new System.Drawing.Point(152, 13);
            this.txtCustFilePath.Name = "txtCustFilePath";
            this.txtCustFilePath.Size = new System.Drawing.Size(181, 20);
            this.txtCustFilePath.TabIndex = 1;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(13, 99);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(81, 16);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadCustom
            // 
            this.btnLoadCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCustom.Location = new System.Drawing.Point(101, 54);
            this.btnLoadCustom.Name = "btnLoadCustom";
            this.btnLoadCustom.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCustom.TabIndex = 3;
            this.btnLoadCustom.Text = "Load";
            this.btnLoadCustom.UseVisualStyleBackColor = true;
            this.btnLoadCustom.Click += new System.EventHandler(this.btnLoadCustom_Click);
            // 
            // lstOfCustomers
            // 
            this.lstOfCustomers.FormattingEnabled = true;
            this.lstOfCustomers.Location = new System.Drawing.Point(12, 119);
            this.lstOfCustomers.Name = "lstOfCustomers";
            this.lstOfCustomers.Size = new System.Drawing.Size(238, 95);
            this.lstOfCustomers.TabIndex = 4;
            this.lstOfCustomers.SelectedIndexChanged += new System.EventHandler(this.lstOfCustomers_SelectedIndexChanged);
            // 
            // lblBoatFilePath
            // 
            this.lblBoatFilePath.AutoSize = true;
            this.lblBoatFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoatFilePath.Location = new System.Drawing.Point(373, 19);
            this.lblBoatFilePath.Name = "lblBoatFilePath";
            this.lblBoatFilePath.Size = new System.Drawing.Size(99, 16);
            this.lblBoatFilePath.TabIndex = 5;
            this.lblBoatFilePath.Text = "Boat file path";
            // 
            // txtBoatFilePath
            // 
            this.txtBoatFilePath.Location = new System.Drawing.Point(479, 19);
            this.txtBoatFilePath.Name = "txtBoatFilePath";
            this.txtBoatFilePath.Size = new System.Drawing.Size(187, 20);
            this.txtBoatFilePath.TabIndex = 6;
            // 
            // btnLoadBoats
            // 
            this.btnLoadBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBoats.Location = new System.Drawing.Point(376, 53);
            this.btnLoadBoats.Name = "btnLoadBoats";
            this.btnLoadBoats.Size = new System.Drawing.Size(96, 23);
            this.btnLoadBoats.TabIndex = 7;
            this.btnLoadBoats.Text = "Load Boats";
            this.btnLoadBoats.UseVisualStyleBackColor = true;
            this.btnLoadBoats.Click += new System.EventHandler(this.btnLoadBoats_Click);
            // 
            // btnSaveBoats
            // 
            this.btnSaveBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBoats.Location = new System.Drawing.Point(511, 53);
            this.btnSaveBoats.Name = "btnSaveBoats";
            this.btnSaveBoats.Size = new System.Drawing.Size(98, 23);
            this.btnSaveBoats.TabIndex = 8;
            this.btnSaveBoats.Text = "Save Boat";
            this.btnSaveBoats.UseVisualStyleBackColor = true;
            this.btnSaveBoats.Click += new System.EventHandler(this.btnSaveBoats_Click);
            // 
            // lblBoats
            // 
            this.lblBoats.AutoSize = true;
            this.lblBoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoats.Location = new System.Drawing.Point(373, 99);
            this.lblBoats.Name = "lblBoats";
            this.lblBoats.Size = new System.Drawing.Size(48, 16);
            this.lblBoats.TabIndex = 9;
            this.lblBoats.Text = "Boats";
            // 
            // lstOfBoats
            // 
            this.lstOfBoats.FormattingEnabled = true;
            this.lstOfBoats.Location = new System.Drawing.Point(376, 118);
            this.lstOfBoats.Name = "lstOfBoats";
            this.lstOfBoats.Size = new System.Drawing.Size(233, 95);
            this.lstOfBoats.TabIndex = 10;
            this.lstOfBoats.SelectedIndexChanged += new System.EventHandler(this.lstOfBoats_SelectedIndexChanged);
            // 
            // lblCustomInfo
            // 
            this.lblCustomInfo.AutoSize = true;
            this.lblCustomInfo.Location = new System.Drawing.Point(16, 238);
            this.lblCustomInfo.Name = "lblCustomInfo";
            this.lblCustomInfo.Size = new System.Drawing.Size(35, 13);
            this.lblCustomInfo.TabIndex = 11;
            this.lblCustomInfo.Text = "label1";
            // 
            // grBoxBoatsOwned
            // 
            this.grBoxBoatsOwned.Controls.Add(this.lblBoatsOwned);
            this.grBoxBoatsOwned.Location = new System.Drawing.Point(19, 334);
            this.grBoxBoatsOwned.Name = "grBoxBoatsOwned";
            this.grBoxBoatsOwned.Size = new System.Drawing.Size(231, 100);
            this.grBoxBoatsOwned.TabIndex = 12;
            this.grBoxBoatsOwned.TabStop = false;
            this.grBoxBoatsOwned.Text = "Boats Owned";
            // 
            // lblBoatsOwned
            // 
            this.lblBoatsOwned.AutoSize = true;
            this.lblBoatsOwned.Location = new System.Drawing.Point(20, 30);
            this.lblBoatsOwned.Name = "lblBoatsOwned";
            this.lblBoatsOwned.Size = new System.Drawing.Size(35, 13);
            this.lblBoatsOwned.TabIndex = 0;
            this.lblBoatsOwned.Text = "label1";
            // 
            // lblBoatInfo
            // 
            this.lblBoatInfo.AutoSize = true;
            this.lblBoatInfo.Location = new System.Drawing.Point(376, 238);
            this.lblBoatInfo.Name = "lblBoatInfo";
            this.lblBoatInfo.Size = new System.Drawing.Size(35, 13);
            this.lblBoatInfo.TabIndex = 13;
            this.lblBoatInfo.Text = "label1";
            // 
            // btnAssignBoat
            // 
            this.btnAssignBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignBoat.Location = new System.Drawing.Point(277, 156);
            this.btnAssignBoat.Name = "btnAssignBoat";
            this.btnAssignBoat.Size = new System.Drawing.Size(75, 42);
            this.btnAssignBoat.TabIndex = 14;
            this.btnAssignBoat.Text = "Assign Boat";
            this.btnAssignBoat.UseVisualStyleBackColor = true;
            this.btnAssignBoat.Click += new System.EventHandler(this.btnAssignBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 446);
            this.Controls.Add(this.btnAssignBoat);
            this.Controls.Add(this.lblBoatInfo);
            this.Controls.Add(this.grBoxBoatsOwned);
            this.Controls.Add(this.lblCustomInfo);
            this.Controls.Add(this.lstOfBoats);
            this.Controls.Add(this.lblBoats);
            this.Controls.Add(this.btnSaveBoats);
            this.Controls.Add(this.btnLoadBoats);
            this.Controls.Add(this.txtBoatFilePath);
            this.Controls.Add(this.lblBoatFilePath);
            this.Controls.Add(this.lstOfCustomers);
            this.Controls.Add(this.btnLoadCustom);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.txtCustFilePath);
            this.Controls.Add(this.lblCusPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBoxBoatsOwned.ResumeLayout(false);
            this.grBoxBoatsOwned.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusPath;
        private System.Windows.Forms.TextBox txtCustFilePath;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnLoadCustom;
        private System.Windows.Forms.ListBox lstOfCustomers;
        private System.Windows.Forms.Label lblBoatFilePath;
        private System.Windows.Forms.TextBox txtBoatFilePath;
        private System.Windows.Forms.Button btnLoadBoats;
        private System.Windows.Forms.Button btnSaveBoats;
        private System.Windows.Forms.Label lblBoats;
        private System.Windows.Forms.ListBox lstOfBoats;
        private System.Windows.Forms.Label lblCustomInfo;
        private System.Windows.Forms.GroupBox grBoxBoatsOwned;
        private System.Windows.Forms.Label lblBoatsOwned;
        private System.Windows.Forms.Label lblBoatInfo;
        private System.Windows.Forms.Button btnAssignBoat;

        
    }
}

