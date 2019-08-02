namespace ProductsByCategory
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
            this.BeveragesButton = new System.Windows.Forms.Button();
            this.ConfectionsButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.FreeFormSelectCategoryButton = new System.Windows.Forms.Button();
            this.TwoCategoryForProductsButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BeveragesButton
            // 
            this.BeveragesButton.Location = new System.Drawing.Point(11, 10);
            this.BeveragesButton.Name = "BeveragesButton";
            this.BeveragesButton.Size = new System.Drawing.Size(147, 23);
            this.BeveragesButton.TabIndex = 0;
            this.BeveragesButton.Text = "Beverages";
            this.BeveragesButton.UseVisualStyleBackColor = true;
            this.BeveragesButton.Click += new System.EventHandler(this.BeveragesButton_Click);
            // 
            // ConfectionsButton
            // 
            this.ConfectionsButton.Location = new System.Drawing.Point(164, 10);
            this.ConfectionsButton.Name = "ConfectionsButton";
            this.ConfectionsButton.Size = new System.Drawing.Size(147, 23);
            this.ConfectionsButton.TabIndex = 2;
            this.ConfectionsButton.Text = "Confections";
            this.ConfectionsButton.UseVisualStyleBackColor = true;
            this.ConfectionsButton.Click += new System.EventHandler(this.ConfectionsButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(12, 182);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(146, 21);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // FreeFormSelectCategoryButton
            // 
            this.FreeFormSelectCategoryButton.Location = new System.Drawing.Point(164, 180);
            this.FreeFormSelectCategoryButton.Name = "FreeFormSelectCategoryButton";
            this.FreeFormSelectCategoryButton.Size = new System.Drawing.Size(147, 23);
            this.FreeFormSelectCategoryButton.TabIndex = 4;
            this.FreeFormSelectCategoryButton.Text = "<- Select";
            this.FreeFormSelectCategoryButton.UseVisualStyleBackColor = true;
            this.FreeFormSelectCategoryButton.Click += new System.EventHandler(this.FreeFormSelectCategoryButton_Click);
            // 
            // TwoCategoryForProductsButton
            // 
            this.TwoCategoryForProductsButton.Location = new System.Drawing.Point(12, 209);
            this.TwoCategoryForProductsButton.Name = "TwoCategoryForProductsButton";
            this.TwoCategoryForProductsButton.Size = new System.Drawing.Size(299, 23);
            this.TwoCategoryForProductsButton.TabIndex = 5;
            this.TwoCategoryForProductsButton.Text = "Two categories for products";
            this.TwoCategoryForProductsButton.UseVisualStyleBackColor = true;
            this.TwoCategoryForProductsButton.Click += new System.EventHandler(this.TwoCategoryForProductsButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 121);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 247);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TwoCategoryForProductsButton);
            this.Controls.Add(this.FreeFormSelectCategoryButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ConfectionsButton);
            this.Controls.Add(this.BeveragesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework Enumerations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeveragesButton;
        private System.Windows.Forms.Button ConfectionsButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button FreeFormSelectCategoryButton;
        private System.Windows.Forms.Button TwoCategoryForProductsButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

