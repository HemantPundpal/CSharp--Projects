namespace ReflectionDemoinCSharp
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
            this.LTableName = new System.Windows.Forms.Label();
            this.TxtbxTableName = new System.Windows.Forms.TextBox();
            this.BtnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.LMethods = new System.Windows.Forms.Label();
            this.LProperties = new System.Windows.Forms.Label();
            this.LConstructors = new System.Windows.Forms.Label();
            this.LstMethods = new System.Windows.Forms.ListBox();
            this.LstProperties = new System.Windows.Forms.ListBox();
            this.LstConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LTableName
            // 
            this.LTableName.AutoSize = true;
            this.LTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTableName.Location = new System.Drawing.Point(24, 25);
            this.LTableName.Name = "LTableName";
            this.LTableName.Size = new System.Drawing.Size(75, 13);
            this.LTableName.TabIndex = 0;
            this.LTableName.Text = "Table Name";
            this.LTableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtbxTableName
            // 
            this.TxtbxTableName.Location = new System.Drawing.Point(105, 22);
            this.TxtbxTableName.Name = "TxtbxTableName";
            this.TxtbxTableName.Size = new System.Drawing.Size(306, 20);
            this.TxtbxTableName.TabIndex = 1;
            // 
            // BtnDiscoverTypeInformation
            // 
            this.BtnDiscoverTypeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiscoverTypeInformation.Location = new System.Drawing.Point(470, 20);
            this.BtnDiscoverTypeInformation.Name = "BtnDiscoverTypeInformation";
            this.BtnDiscoverTypeInformation.Size = new System.Drawing.Size(296, 23);
            this.BtnDiscoverTypeInformation.TabIndex = 2;
            this.BtnDiscoverTypeInformation.Text = "Discover Type Information";
            this.BtnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.BtnDiscoverTypeInformation.Click += new System.EventHandler(this.BtnDiscoverTypeInformation_Click);
            // 
            // LMethods
            // 
            this.LMethods.AutoSize = true;
            this.LMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMethods.Location = new System.Drawing.Point(24, 81);
            this.LMethods.Name = "LMethods";
            this.LMethods.Size = new System.Drawing.Size(55, 13);
            this.LMethods.TabIndex = 3;
            this.LMethods.Text = "Methods";
            this.LMethods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LProperties
            // 
            this.LProperties.AutoSize = true;
            this.LProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProperties.Location = new System.Drawing.Point(283, 81);
            this.LProperties.Name = "LProperties";
            this.LProperties.Size = new System.Drawing.Size(64, 13);
            this.LProperties.TabIndex = 4;
            this.LProperties.Text = "Properties";
            this.LProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LConstructors
            // 
            this.LConstructors.AutoSize = true;
            this.LConstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConstructors.Location = new System.Drawing.Point(536, 81);
            this.LConstructors.Name = "LConstructors";
            this.LConstructors.Size = new System.Drawing.Size(78, 13);
            this.LConstructors.TabIndex = 5;
            this.LConstructors.Text = "Constructors";
            this.LConstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LstMethods
            // 
            this.LstMethods.FormattingEnabled = true;
            this.LstMethods.Location = new System.Drawing.Point(27, 109);
            this.LstMethods.Name = "LstMethods";
            this.LstMethods.Size = new System.Drawing.Size(224, 316);
            this.LstMethods.TabIndex = 6;
            // 
            // LstProperties
            // 
            this.LstProperties.FormattingEnabled = true;
            this.LstProperties.Location = new System.Drawing.Point(286, 109);
            this.LstProperties.Name = "LstProperties";
            this.LstProperties.Size = new System.Drawing.Size(224, 316);
            this.LstProperties.TabIndex = 7;
            // 
            // LstConstructors
            // 
            this.LstConstructors.FormattingEnabled = true;
            this.LstConstructors.Location = new System.Drawing.Point(539, 109);
            this.LstConstructors.Name = "LstConstructors";
            this.LstConstructors.Size = new System.Drawing.Size(227, 316);
            this.LstConstructors.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstConstructors);
            this.Controls.Add(this.LstProperties);
            this.Controls.Add(this.LstMethods);
            this.Controls.Add(this.LConstructors);
            this.Controls.Add(this.LProperties);
            this.Controls.Add(this.LMethods);
            this.Controls.Add(this.BtnDiscoverTypeInformation);
            this.Controls.Add(this.TxtbxTableName);
            this.Controls.Add(this.LTableName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTableName;
        private System.Windows.Forms.TextBox TxtbxTableName;
        private System.Windows.Forms.Button BtnDiscoverTypeInformation;
        private System.Windows.Forms.Label LMethods;
        private System.Windows.Forms.Label LProperties;
        private System.Windows.Forms.Label LConstructors;
        private System.Windows.Forms.ListBox LstMethods;
        private System.Windows.Forms.ListBox LstProperties;
        private System.Windows.Forms.ListBox LstConstructors;
    }
}

