using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using System.Diagnostics;

namespace _3AK_Vorbereitung_Test_Beispiel
{
    public partial class Form1 : Form
    {
        BindingList<ToDo> toDos = new BindingList<ToDo>();
        Frm_Eingabe_ToDo eingabe_todo = new Frm_Eingabe_ToDo();
        ITodoService todoService = (XMLToDoService)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["todoService"]));
        public static int items_in_listbox = 0;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ToDos aus File laden
            toDos = todoService.LadeToDos();


            //DataSource der ListBox festlegen
            lstBx_todos.DataSource = toDos;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            items_in_listbox = lstBx_todos.Items.Count + 1;
            eingabe_todo.ShowDialog();

            if (eingabe_todo.hinzufuegen == true)
            {
                //Kunde aus Frm_Eingabe_ToDo in Liste einfügen
                ToDo todo = eingabe_todo.todo;
                toDos.Add(todo);

                Count();
            }
        }

        private void Count()
        {
            int offen = 0, erledigt = 0;

            foreach (ToDo toDo in toDos)
            {
                if (toDo.Erledigt) { erledigt++; }

                else { offen++; }
            }

            lbl_anzahl_erledigt.Text = erledigt.ToString();
            lbl_anzahl_offen.Text = offen.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Speichere ToDos in File
            todoService.SpeichereToDos(toDos);
        }

        private void lstBx_todos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDo todo = (ToDo)lstBx_todos.SelectedItem;

            if (todo != null)
            {
                lbl_ID.Text = todo.ID.ToString();
                lbl_beschreibung.Text = todo.Beschreibung;
                lbl_erledigt.Text = todo.Erledigt.ToString();
            }

            else
            {
                lbl_ID.Text = "-";
                lbl_beschreibung.Text = "-";
                lbl_erledigt.Text = "-";
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lstBx_todos.SelectedItem != null)
            {
                ToDo todo = (ToDo)lstBx_todos.SelectedItem;
                toDos.Remove(todo);
                Count();

                neue_nummerierung();
            }
        }

        private void neue_nummerierung()
        {
            for (int i = 0; i < toDos.Count; i++)
            {
                toDos[i].ID = i + 1;
                Debug.WriteLine(toDos[i].ID);
            }

            lstBx_todos.DataSource = null;
            lstBx_todos.DataSource = toDos;
        }
    }
}
