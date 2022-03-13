
namespace LinqToSql_Garage
{
    partial class uc_page1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nbTotalVoitures = new System.Windows.Forms.TextBox();
            this.txt_nbTotalReparations = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le nombre total des voitures : ";
            // 
            // txt_nbTotalVoitures
            // 
            this.txt_nbTotalVoitures.Location = new System.Drawing.Point(442, 54);
            this.txt_nbTotalVoitures.Name = "txt_nbTotalVoitures";
            this.txt_nbTotalVoitures.ReadOnly = true;
            this.txt_nbTotalVoitures.Size = new System.Drawing.Size(200, 38);
            this.txt_nbTotalVoitures.TabIndex = 1;
            // 
            // txt_nbTotalReparations
            // 
            this.txt_nbTotalReparations.Location = new System.Drawing.Point(442, 122);
            this.txt_nbTotalReparations.Name = "txt_nbTotalReparations";
            this.txt_nbTotalReparations.ReadOnly = true;
            this.txt_nbTotalReparations.Size = new System.Drawing.Size(200, 38);
            this.txt_nbTotalReparations.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Le nombre total des réparations :";
            // 
            // uc_page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_nbTotalReparations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nbTotalVoitures);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "uc_page1";
            this.Size = new System.Drawing.Size(679, 217);
            this.Load += new System.EventHandler(this.uc_page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nbTotalVoitures;
        private System.Windows.Forms.TextBox txt_nbTotalReparations;
        private System.Windows.Forms.Label label2;
    }
}
