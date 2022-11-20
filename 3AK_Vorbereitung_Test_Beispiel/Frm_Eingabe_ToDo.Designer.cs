namespace _3AK_Vorbereitung_Test_Beispiel
{
    partial class Frm_Eingabe_ToDo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_id = new System.Windows.Forms.TextBox();
            this.txt_beschreibung = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.erledigt = new System.Windows.Forms.Label();
            this.checkBx_erledigt = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eingabe ToDo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // txtBx_id
            // 
            this.txtBx_id.Enabled = false;
            this.txtBx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_id.Location = new System.Drawing.Point(20, 119);
            this.txtBx_id.Multiline = true;
            this.txtBx_id.Name = "txtBx_id";
            this.txtBx_id.Size = new System.Drawing.Size(215, 29);
            this.txtBx_id.TabIndex = 6;
            // 
            // txt_beschreibung
            // 
            this.txt_beschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_beschreibung.Location = new System.Drawing.Point(20, 209);
            this.txt_beschreibung.Multiline = true;
            this.txt_beschreibung.Name = "txt_beschreibung";
            this.txt_beschreibung.Size = new System.Drawing.Size(578, 153);
            this.txt_beschreibung.TabIndex = 8;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(16, 179);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(141, 27);
            this.label99.TabIndex = 7;
            this.label99.Text = "Beschreibung";
            // 
            // erledigt
            // 
            this.erledigt.AutoSize = true;
            this.erledigt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erledigt.Location = new System.Drawing.Point(16, 399);
            this.erledigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.erledigt.Name = "erledigt";
            this.erledigt.Size = new System.Drawing.Size(101, 27);
            this.erledigt.TabIndex = 9;
            this.erledigt.Text = "Erledigt ?";
            // 
            // checkBx_erledigt
            // 
            this.checkBx_erledigt.AutoSize = true;
            this.checkBx_erledigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBx_erledigt.Location = new System.Drawing.Point(21, 429);
            this.checkBx_erledigt.Name = "checkBx_erledigt";
            this.checkBx_erledigt.Size = new System.Drawing.Size(46, 26);
            this.checkBx_erledigt.TabIndex = 11;
            this.checkBx_erledigt.Text = "ja";
            this.checkBx_erledigt.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 524);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 56);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(153, 524);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 56);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Frm_Eingabe_ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 629);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.checkBx_erledigt);
            this.Controls.Add(this.erledigt);
            this.Controls.Add(this.txt_beschreibung);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.txtBx_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Eingabe_ToDo";
            this.Text = "Eingabe_ToDo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Eingabe_ToDo_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Eingabe_ToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_id;
        private System.Windows.Forms.TextBox txt_beschreibung;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label erledigt;
        private System.Windows.Forms.CheckBox checkBx_erledigt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}