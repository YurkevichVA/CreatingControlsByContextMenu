namespace CreatingControlsByContextMenu
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckBoxCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCreate,
            this.TextBoxCreate,
            this.CheckBoxCreate});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(267, 76);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(266, 24);
            this.ButtonCreate.Text = "Створити кнопку (3)";
            this.ButtonCreate.Click += new System.EventHandler(this.AddControl);
            // 
            // TextBoxCreate
            // 
            this.TextBoxCreate.Name = "TextBoxCreate";
            this.TextBoxCreate.Size = new System.Drawing.Size(266, 24);
            this.TextBoxCreate.Text = "Створити текстове поле (3)";
            this.TextBoxCreate.Click += new System.EventHandler(this.AddControl);
            // 
            // CheckBoxCreate
            // 
            this.CheckBoxCreate.Name = "CheckBoxCreate";
            this.CheckBoxCreate.Size = new System.Drawing.Size(266, 24);
            this.CheckBoxCreate.Text = "Створити чекбокс (3)";
            this.CheckBoxCreate.Click += new System.EventHandler(this.AddControl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenu;
            this.Name = "Form1";
            this.Text = "Натисніть праву кнопку миші";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ButtonCreate;
        private System.Windows.Forms.ToolStripMenuItem TextBoxCreate;
        private System.Windows.Forms.ToolStripMenuItem CheckBoxCreate;
    }
}

