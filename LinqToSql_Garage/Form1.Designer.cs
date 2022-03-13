
namespace LinqToSql_Garage
{
    partial class Frm_voitures
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
            this.txt_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_modele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_lst = new System.Windows.Forms.Panel();
            this.pnl_details = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_lst.SuspendLayout();
            this.pnl_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des voitures";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(5, 16);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(304, 26);
            this.txt_find.TabIndex = 1;
            this.txt_find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_find_KeyUp);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(316, 16);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(74, 26);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 48);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(382, 423);
            this.dgv.TabIndex = 3;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(5, 475);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(53, 43);
            this.btn_first.TabIndex = 4;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(274, 475);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(53, 43);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(333, 475);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(53, 43);
            this.btn_last.TabIndex = 6;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(64, 475);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(53, 43);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(145, 25);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(327, 26);
            this.txt_matricule.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Immatriculation : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marque : ";
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(145, 81);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(327, 26);
            this.txt_marque.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Modele : ";
            // 
            // txt_modele
            // 
            this.txt_modele.Location = new System.Drawing.Point(145, 136);
            this.txt_modele.Name = "txt_modele";
            this.txt_modele.Size = new System.Drawing.Size(327, 26);
            this.txt_modele.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telephone : ";
            // 
            // txt_tele
            // 
            this.txt_tele.Location = new System.Drawing.Point(145, 194);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(327, 26);
            this.txt_tele.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(432, 405);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(145, 33);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(765, 405);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 33);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(598, 405);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 33);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(692, 461);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 33);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(518, 461);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 33);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Valider";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_lst
            // 
            this.pnl_lst.Controls.Add(this.btn_prev);
            this.pnl_lst.Controls.Add(this.btn_last);
            this.pnl_lst.Controls.Add(this.btn_next);
            this.pnl_lst.Controls.Add(this.btn_first);
            this.pnl_lst.Controls.Add(this.dgv);
            this.pnl_lst.Controls.Add(this.btn_find);
            this.pnl_lst.Controls.Add(this.txt_find);
            this.pnl_lst.Location = new System.Drawing.Point(7, 59);
            this.pnl_lst.Name = "pnl_lst";
            this.pnl_lst.Size = new System.Drawing.Size(410, 530);
            this.pnl_lst.TabIndex = 21;
            // 
            // pnl_details
            // 
            this.pnl_details.Controls.Add(this.label5);
            this.pnl_details.Controls.Add(this.txt_tele);
            this.pnl_details.Controls.Add(this.label4);
            this.pnl_details.Controls.Add(this.txt_modele);
            this.pnl_details.Controls.Add(this.label3);
            this.pnl_details.Controls.Add(this.txt_marque);
            this.pnl_details.Controls.Add(this.label2);
            this.pnl_details.Controls.Add(this.txt_matricule);
            this.pnl_details.Location = new System.Drawing.Point(437, 116);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(483, 249);
            this.pnl_details.TabIndex = 22;
            // 
            // Frm_voitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(925, 589);
            this.Controls.Add(this.pnl_details);
            this.Controls.Add(this.pnl_lst);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_voitures";
            this.Text = "Gestion des voitures";
            this.Load += new System.EventHandler(this.Frm_voitures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_lst.ResumeLayout(false);
            this.pnl_lst.PerformLayout();
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_modele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_lst;
        private System.Windows.Forms.Panel pnl_details;
    }
}

