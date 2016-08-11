namespace PokeManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartupSettings = new System.Windows.Forms.TabPage();
            this.HumanizeSettings = new System.Windows.Forms.TabPage();
            this.InventorySettings = new System.Windows.Forms.TabPage();
            this.PokemonSettings = new System.Windows.Forms.TabPage();
            this.SniperSettings = new System.Windows.Forms.TabPage();
            this.LocationFeeder = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pokeManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StartupSettings);
            this.tabControl1.Controls.Add(this.HumanizeSettings);
            this.tabControl1.Controls.Add(this.InventorySettings);
            this.tabControl1.Controls.Add(this.PokemonSettings);
            this.tabControl1.Controls.Add(this.SniperSettings);
            this.tabControl1.Controls.Add(this.LocationFeeder);
            this.tabControl1.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tabControl1.ItemSize = new System.Drawing.Size(400, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // StartupSettings
            // 
            this.StartupSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.StartupSettings.ForeColor = System.Drawing.Color.White;
            this.StartupSettings.Location = new System.Drawing.Point(4, 54);
            this.StartupSettings.Margin = new System.Windows.Forms.Padding(0);
            this.StartupSettings.Name = "StartupSettings";
            this.StartupSettings.Padding = new System.Windows.Forms.Padding(3);
            this.StartupSettings.Size = new System.Drawing.Size(900, 486);
            this.StartupSettings.TabIndex = 0;
            this.StartupSettings.Text = "Startup Settings";
            this.StartupSettings.Click += new System.EventHandler(this.StartupSettings_Click);
            // 
            // HumanizeSettings
            // 
            this.HumanizeSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HumanizeSettings.ForeColor = System.Drawing.Color.White;
            this.HumanizeSettings.Location = new System.Drawing.Point(4, 54);
            this.HumanizeSettings.Name = "HumanizeSettings";
            this.HumanizeSettings.Padding = new System.Windows.Forms.Padding(3);
            this.HumanizeSettings.Size = new System.Drawing.Size(900, 546);
            this.HumanizeSettings.TabIndex = 1;
            this.HumanizeSettings.Text = "Humanize Settings";
            // 
            // InventorySettings
            // 
            this.InventorySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InventorySettings.ForeColor = System.Drawing.Color.White;
            this.InventorySettings.Location = new System.Drawing.Point(4, 54);
            this.InventorySettings.Name = "InventorySettings";
            this.InventorySettings.Size = new System.Drawing.Size(900, 546);
            this.InventorySettings.TabIndex = 2;
            this.InventorySettings.Text = "Inventory Settings";
            // 
            // PokemonSettings
            // 
            this.PokemonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PokemonSettings.ForeColor = System.Drawing.Color.White;
            this.PokemonSettings.Location = new System.Drawing.Point(4, 54);
            this.PokemonSettings.Name = "PokemonSettings";
            this.PokemonSettings.Size = new System.Drawing.Size(900, 546);
            this.PokemonSettings.TabIndex = 3;
            this.PokemonSettings.Text = "Pokemon Settings";
            // 
            // SniperSettings
            // 
            this.SniperSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SniperSettings.ForeColor = System.Drawing.Color.White;
            this.SniperSettings.Location = new System.Drawing.Point(4, 54);
            this.SniperSettings.Name = "SniperSettings";
            this.SniperSettings.Size = new System.Drawing.Size(900, 546);
            this.SniperSettings.TabIndex = 4;
            this.SniperSettings.Text = "Sniper Settings";
            // 
            // LocationFeeder
            // 
            this.LocationFeeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LocationFeeder.ForeColor = System.Drawing.Color.White;
            this.LocationFeeder.Location = new System.Drawing.Point(4, 54);
            this.LocationFeeder.Name = "LocationFeeder";
            this.LocationFeeder.Size = new System.Drawing.Size(900, 546);
            this.LocationFeeder.TabIndex = 5;
            this.LocationFeeder.Text = "Location Feeder";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Text = "PokeManager";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.BackColor = System.Drawing.Color.Brown;
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip3.Text = "PokeManager";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokeManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "TitleMenu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pokeManagerToolStripMenuItem
            // 
            this.pokeManagerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pokeManagerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pokeManagerToolStripMenuItem.Name = "pokeManagerToolStripMenuItem";
            this.pokeManagerToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.pokeManagerToolStripMenuItem.Text = "PokeManager";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Brown;
            this.statusStrip1.Location = new System.Drawing.Point(1, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 660);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(931, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 660);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(932, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("SansSerif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StartupSettings;
        private System.Windows.Forms.TabPage HumanizeSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage InventorySettings;
        private System.Windows.Forms.TabPage PokemonSettings;
        private System.Windows.Forms.TabPage SniperSettings;
        private System.Windows.Forms.TabPage LocationFeeder;
        private System.Windows.Forms.ToolStripMenuItem pokeManagerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

