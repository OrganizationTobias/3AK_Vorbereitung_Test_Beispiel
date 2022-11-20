using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3AK_Vorbereitung_Test_Beispiel
{
    public partial class Frm_Eingabe_ToDo : Form
    {
        public ToDo todo = null;
        public bool hinzufuegen = false;


        public Frm_Eingabe_ToDo()
        {
            InitializeComponent();
        }

        private void Frm_Eingabe_ToDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            hinzufuegen = false;
            Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //ToDo (todo) aus Zeile 15 erzeugen (ID Soll automatisch vergeben werden durch die Anzahl der ListBox Items + 1)

            todo = new ToDo(Form1.items_in_listbox, txt_beschreibung.Text, checkBx_erledigt.Checked);

            //hinzufuegen auf true setzen
            hinzufuegen = true;

            //Verstecke das Form
            Hide();
        }

        private void Frm_Eingabe_ToDo_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;

                    if (textBox.Name != "txtBx_id")
                    {
                        textBox.Text = String.Empty;

                    }
                }

                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }

            //Bei ID neue fortlaufende Nummer anzeigen
            txtBx_id.Text = Convert.ToString(Form1.items_in_listbox);
        }
    }
}
