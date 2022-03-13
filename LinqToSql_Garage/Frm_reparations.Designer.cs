
namespace LinqToSql_Garage
{
    partial class Frm_reparations
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
            this.combo_voitures = new System.Windows.Forms.ComboBox();
            this.lst_reparations = new System.Windows.Forms.ListBox();
            this.dgv_utilise = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prixReparation = new System.Windows.Forms.TextBox();
            this.txt_prixPieces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addReparation = new System.Windows.Forms.Button();
            this.btn_addPiece = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utilise)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_voitures
            // 
            this.combo_voitures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_voitures.FormattingEnabled = true;
            this.combo_voitures.Location = new System.Drawing.Point(12, 12);
            this.combo_voitures.Name = "combo_voitures";
            this.combo_voitures.Size = new System.Drawing.Size(315, 28);
            this.combo_voitures.TabIndex = 0;
            this.combo_voitures.SelectedValueChanged += new System.EventHandler(this.combo_voitures_SelectedValueChanged);
            // 
            // lst_reparations
            // 
            this.lst_reparations.FormattingEnabled = true;
            this.lst_reparations.ItemHeight = 20;
            this.lst_reparations.Location = new System.Drawing.Point(12, 60);
            this.lst_reparations.Name = "lst_reparations";
            this.lst_reparations.Size = new System.Drawing.Size(191, 464);
            this.lst_reparations.TabIndex = 1;
            this.lst_reparations.SelectedValueChanged += new System.EventHandler(this.lst_reparations_SelectedValueChanged);
            // 
            // dgv_utilise
            // 
            this.dgv_utilise.AllowUserToAddRows = false;
            this.dgv_utilise.AllowUserToDeleteRows = false;
            this.dgv_utilise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_utilise.Location = new System.Drawing.Point(234, 60);
            this.dgv_utilise.Name = "dgv_utilise";
            this.dgv_utilise.ReadOnly = true;
            this.dgv_utilise.Size = new System.Drawing.Size(676, 400);
            this.dgv_utilise.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prix de Reparation :";
            // 
            // txt_prixReparation
            // 
            this.txt_prixReparation.Location = new System.Drawing.Point(383, 475);
            this.txt_prixReparation.Name = "txt_prixReparation";
            this.txt_prixReparation.ReadOnly = true;
            this.txt_prixReparation.Size = new System.Drawing.Size(156, 26);
            this.txt_prixReparation.TabIndex = 4;
            // 
            // txt_prixPieces
            // 
            this.txt_prixPieces.Location = new System.Drawing.Point(757, 472);
            this.txt_prixPieces.Name = "txt_prixPieces";
            this.txt_prixPieces.ReadOnly = true;
            this.txt_prixPieces.Size = new System.Drawing.Size(156, 26);
            this.txt_prixPieces.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix des Pieces :";
            // 
            // btn_addReparation
            // 
            this.btn_addReparation.Location = new System.Drawing.Point(12, 530);
            this.btn_addReparation.Name = "btn_addReparation";
            this.btn_addReparation.Size = new System.Drawing.Size(191, 35);
            this.btn_addReparation.TabIndex = 7;
            this.btn_addReparation.Text = "Ajouter une reparation";
            this.btn_addReparation.UseVisualStyleBackColor = true;
            this.btn_addReparation.Click += new System.EventHandler(this.btn_addReparation_Click);
            // 
            // btn_addPiece
            // 
            this.btn_addPiece.Location = new System.Drawing.Point(757, 19);
            this.btn_addPiece.Name = "btn_addPiece";
            this.btn_addPiece.Size = new System.Drawing.Size(153, 35);
            this.btn_addPiece.TabIndex = 8;
            this.btn_addPiece.Text = "Ajouter une piece";
            this.btn_addPiece.UseVisualStyleBackColor = true;
            this.btn_addPiece.Click += new System.EventHandler(this.btn_addPiece_Click);
            // 
            // Frm_reparations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 587);
            this.Controls.Add(this.btn_addPiece);
            this.Controls.Add(this.btn_addReparation);
            this.Controls.Add(this.txt_prixPieces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_prixReparation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_utilise);
            this.Controls.Add(this.lst_reparations);
            this.Controls.Add(this.combo_voitures);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_reparations";
            this.Text = "Gestion des reparations";
            this.Load += new System.EventHandler(this.Frm_reparations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utilise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_voitures;
        private System.Windows.Forms.ListBox lst_reparations;
        private System.Windows.Forms.DataGridView dgv_utilise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prixReparation;
        private System.Windows.Forms.TextBox txt_prixPieces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addReparation;
        private System.Windows.Forms.Button btn_addPiece;
    }
}