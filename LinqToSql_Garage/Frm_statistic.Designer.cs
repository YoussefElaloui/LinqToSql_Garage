
namespace LinqToSql_Garage
{
    partial class Frm_statistic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.page1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.page2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.page3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_page31 = new LinqToSql_Garage.uc_page3();
            this.uc_page21 = new LinqToSql_Garage.uc_page2();
            this.uc_page11 = new LinqToSql_Garage.uc_page1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.page1ToolStripMenuItem,
            this.page2ToolStripMenuItem,
            this.page3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // page1ToolStripMenuItem
            // 
            this.page1ToolStripMenuItem.Name = "page1ToolStripMenuItem";
            this.page1ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.page1ToolStripMenuItem.Text = "Page1";
            this.page1ToolStripMenuItem.Click += new System.EventHandler(this.page1ToolStripMenuItem_Click);
            // 
            // page2ToolStripMenuItem
            // 
            this.page2ToolStripMenuItem.Name = "page2ToolStripMenuItem";
            this.page2ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.page2ToolStripMenuItem.Text = "Page2";
            this.page2ToolStripMenuItem.Click += new System.EventHandler(this.page2ToolStripMenuItem_Click);
            // 
            // page3ToolStripMenuItem
            // 
            this.page3ToolStripMenuItem.Name = "page3ToolStripMenuItem";
            this.page3ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.page3ToolStripMenuItem.Text = "Page3";
            this.page3ToolStripMenuItem.Click += new System.EventHandler(this.page3ToolStripMenuItem_Click);
            // 
            // uc_page31
            // 
            this.uc_page31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_page31.Location = new System.Drawing.Point(31, 38);
            this.uc_page31.Margin = new System.Windows.Forms.Padding(6);
            this.uc_page31.Name = "uc_page31";
            this.uc_page31.Size = new System.Drawing.Size(833, 534);
            this.uc_page31.TabIndex = 3;
            // 
            // uc_page21
            // 
            this.uc_page21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_page21.Location = new System.Drawing.Point(31, 38);
            this.uc_page21.Margin = new System.Windows.Forms.Padding(6);
            this.uc_page21.Name = "uc_page21";
            this.uc_page21.Size = new System.Drawing.Size(833, 534);
            this.uc_page21.TabIndex = 2;
            // 
            // uc_page11
            // 
            this.uc_page11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_page11.Location = new System.Drawing.Point(69, 148);
            this.uc_page11.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uc_page11.Name = "uc_page11";
            this.uc_page11.Size = new System.Drawing.Size(679, 217);
            this.uc_page11.TabIndex = 1;
            // 
            // Frm_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 587);
            this.Controls.Add(this.uc_page31);
            this.Controls.Add(this.uc_page21);
            this.Controls.Add(this.uc_page11);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Frm_statistic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem page1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem page2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem page3ToolStripMenuItem;
        private uc_page1 uc_page11;
        private uc_page2 uc_page21;
        private uc_page3 uc_page31;
    }
}