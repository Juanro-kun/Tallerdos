namespace Taller_2_Gestor.Forms
{
    partial class MainForm : BaseForm
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
            tlpRoot = new TableLayoutPanel();
            panelMenu = new Panel();
            ContentHost = new Panel();
            tlpRoot.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle());
            tlpRoot.Controls.Add(panelMenu, 0, 0);
            tlpRoot.Controls.Add(ContentHost, 1, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 1;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(800, 450);
            tlpRoot.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 33, 33);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(194, 444);
            panelMenu.TabIndex = 0;
            // 
            // ContentHost
            // 
            ContentHost.Dock = DockStyle.Fill;
            ContentHost.Location = new Point(203, 3);
            ContentHost.Name = "ContentHost";
            ContentHost.Size = new Size(594, 444);
            ContentHost.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpRoot);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tlpRoot.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel panelMenu;
        private Panel ContentHost;
    }
}