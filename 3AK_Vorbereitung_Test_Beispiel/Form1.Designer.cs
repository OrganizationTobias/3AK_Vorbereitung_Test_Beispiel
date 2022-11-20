namespace _3AK_Vorbereitung_Test_Beispiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBx_todos = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_beschreibung = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_erledigt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_anzahl_erledigt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_anzahl_offen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBx_todos
            // 
            this.lstBx_todos.FormattingEnabled = true;
            this.lstBx_todos.ItemHeight = 22;
            this.lstBx_todos.Location = new System.Drawing.Point(15, 16);
            this.lstBx_todos.Margin = new System.Windows.Forms.Padding(4);
            this.lstBx_todos.Name = "lstBx_todos";
            this.lstBx_todos.Size = new System.Drawing.Size(353, 466);
            this.lstBx_todos.TabIndex = 0;
            this.lstBx_todos.SelectedIndexChanged += new System.EventHandler(this.lstBx_todos_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(35, 514);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 56);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(209, 514);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 56);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(675, 176);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 27);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "-";
            // 
            // lbl_beschreibung
            // 
            this.lbl_beschreibung.AutoSize = true;
            this.lbl_beschreibung.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_beschreibung.Location = new System.Drawing.Point(675, 253);
            this.lbl_beschreibung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_beschreibung.Name = "lbl_beschreibung";
            this.lbl_beschreibung.Size = new System.Drawing.Size(21, 27);
            this.lbl_beschreibung.TabIndex = 7;
            this.lbl_beschreibung.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beschreibung:";
            // 
            // lbl_erledigt
            // 
            this.lbl_erledigt.AutoSize = true;
            this.lbl_erledigt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erledigt.Location = new System.Drawing.Point(675, 345);
            this.lbl_erledigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_erledigt.Name = "lbl_erledigt";
            this.lbl_erledigt.Size = new System.Drawing.Size(21, 27);
            this.lbl_erledigt.TabIndex = 9;
            this.lbl_erledigt.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Erledigt?";
            // 
            // lbl_anzahl_erledigt
            // 
            this.lbl_anzahl_erledigt.AutoSize = true;
            this.lbl_anzahl_erledigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anzahl_erledigt.Location = new System.Drawing.Point(1050, 584);
            this.lbl_anzahl_erledigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_anzahl_erledigt.Name = "lbl_anzahl_erledigt";
            this.lbl_anzahl_erledigt.Size = new System.Drawing.Size(16, 22);
            this.lbl_anzahl_erledigt.TabIndex = 10;
            this.lbl_anzahl_erledigt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(911, 584);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Anzahl erledigt :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 584);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Anzahl offen :";
            // 
            // lbl_anzahl_offen
            // 
            this.lbl_anzahl_offen.AutoSize = true;
            this.lbl_anzahl_offen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anzahl_offen.Location = new System.Drawing.Point(826, 584);
            this.lbl_anzahl_offen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_anzahl_offen.Name = "lbl_anzahl_offen";
            this.lbl_anzahl_offen.Size = new System.Drawing.Size(16, 22);
            this.lbl_anzahl_offen.TabIndex = 12;
            this.lbl_anzahl_offen.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 619);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_anzahl_offen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_anzahl_erledigt);
            this.Controls.Add(this.lbl_erledigt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_beschreibung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lstBx_todos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Meine ToDos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_beschreibung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_erledigt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_anzahl_erledigt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_anzahl_offen;
        public System.Windows.Forms.ListBox lstBx_todos;
    }
}

