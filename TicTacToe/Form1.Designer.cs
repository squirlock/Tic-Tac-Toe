namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFileStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripNewGameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextHelpStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAboutAppItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAboutDevItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.contextFileStrip.SuspendLayout();
            this.contextHelpStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileItem,
            this.toolStripHelpItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(379, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripFileItem
            // 
            this.toolStripFileItem.DropDown = this.contextFileStrip;
            this.toolStripFileItem.Name = "toolStripFileItem";
            this.toolStripFileItem.Size = new System.Drawing.Size(46, 24);
            this.toolStripFileItem.Text = "File";
            // 
            // contextFileStrip
            // 
            this.contextFileStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextFileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewGameItem,
            this.toolStripExitItem});
            this.contextFileStrip.Name = "contextFileStrip";
            this.contextFileStrip.OwnerItem = this.toolStripFileItem;
            this.contextFileStrip.Size = new System.Drawing.Size(152, 52);
            this.contextFileStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextFileStrip_ItemClicked);
            // 
            // toolStripNewGameItem
            // 
            this.toolStripNewGameItem.Name = "toolStripNewGameItem";
            this.toolStripNewGameItem.Size = new System.Drawing.Size(151, 24);
            this.toolStripNewGameItem.Text = "New Game";
            // 
            // toolStripExitItem
            // 
            this.toolStripExitItem.Name = "toolStripExitItem";
            this.toolStripExitItem.Size = new System.Drawing.Size(151, 24);
            this.toolStripExitItem.Text = "Exit";
            // 
            // toolStripHelpItem
            // 
            this.toolStripHelpItem.DropDown = this.contextHelpStrip;
            this.toolStripHelpItem.Name = "toolStripHelpItem";
            this.toolStripHelpItem.Size = new System.Drawing.Size(55, 24);
            this.toolStripHelpItem.Text = "Help";
            // 
            // contextHelpStrip
            // 
            this.contextHelpStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextHelpStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAboutAppItem,
            this.toolStripAboutDevItem});
            this.contextHelpStrip.Name = "contextHelpStrip";
            this.contextHelpStrip.OwnerItem = this.toolStripHelpItem;
            this.contextHelpStrip.Size = new System.Drawing.Size(193, 52);
            this.contextHelpStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextHelpStrip_ItemClicked);
            // 
            // toolStripAboutAppItem
            // 
            this.toolStripAboutAppItem.Name = "toolStripAboutAppItem";
            this.toolStripAboutAppItem.Size = new System.Drawing.Size(192, 24);
            this.toolStripAboutAppItem.Text = "About App";
            // 
            // toolStripAboutDevItem
            // 
            this.toolStripAboutDevItem.Name = "toolStripAboutDevItem";
            this.toolStripAboutDevItem.Size = new System.Drawing.Size(192, 24);
            this.toolStripAboutDevItem.Text = "About Developer";
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A1.Location = new System.Drawing.Point(2, 30);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(125, 125);
            this.A1.TabIndex = 3;
            this.A1.TabStop = false;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(127, 30);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(125, 125);
            this.A2.TabIndex = 3;
            this.A2.TabStop = false;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(252, 30);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(125, 125);
            this.A3.TabIndex = 3;
            this.A3.TabStop = false;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(2, 155);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(125, 125);
            this.B1.TabIndex = 3;
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(127, 155);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(125, 125);
            this.B2.TabIndex = 3;
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(252, 155);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(125, 125);
            this.B3.TabIndex = 3;
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(2, 280);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(125, 125);
            this.C1.TabIndex = 3;
            this.C1.TabStop = false;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(127, 280);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(125, 125);
            this.C2.TabIndex = 3;
            this.C2.TabStop = false;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(252, 280);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(125, 125);
            this.C3.TabIndex = 3;
            this.C3.TabStop = false;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(379, 406);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ankit\'s TicTacToe";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextFileStrip.ResumeLayout(false);
            this.contextHelpStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileItem;
        private System.Windows.Forms.ContextMenuStrip contextFileStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewGameItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelpItem;
        private System.Windows.Forms.ContextMenuStrip contextHelpStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripAboutAppItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripAboutDevItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
    }
}

