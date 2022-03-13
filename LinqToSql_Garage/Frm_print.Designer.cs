
namespace LinqToSql_Garage
{
    partial class Frm_print
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_voitures = new System.Windows.Forms.ComboBox();
            this.cmb_reparations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voitures : ";
            // 
            // cmb_voitures
            // 
            this.cmb_voitures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_voitures.FormattingEnabled = true;
            this.cmb_voitures.Location = new System.Drawing.Point(150, 22);
            this.cmb_voitures.Name = "cmb_voitures";
            this.cmb_voitures.Size = new System.Drawing.Size(338, 32);
            this.cmb_voitures.TabIndex = 1;
            this.cmb_voitures.SelectedValueChanged += new System.EventHandler(this.cmb_voitures_SelectedValueChanged);
            // 
            // cmb_reparations
            // 
            this.cmb_reparations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reparations.FormattingEnabled = true;
            this.cmb_reparations.Location = new System.Drawing.Point(150, 77);
            this.cmb_reparations.Name = "cmb_reparations";
            this.cmb_reparations.Size = new System.Drawing.Size(338, 32);
            this.cmb_reparations.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reparations : ";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(517, 22);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(110, 84);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Imprimer";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Frm_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 136);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.cmb_reparations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_voitures);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_print";
            this.Text = "Imprimer";
            this.Load += new System.EventHandler(this.Frm_print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_voitures;
        private System.Windows.Forms.ComboBox cmb_reparations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_print;
    }
}