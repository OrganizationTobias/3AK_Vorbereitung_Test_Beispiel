using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3AK_Vorbereitung_Test_Beispiel
{
    public class XMLToDoService : ITodoService
    {
        private static string fileName = ConfigurationManager.AppSettings["fileName"];

        XmlTextWriter writer = null;
        XmlTextReader reader = null;

        public BindingList<ToDo> LadeToDos()
        {
            BindingList<ToDo> todos = new BindingList<ToDo>();

            if (System.IO.File.Exists(fileName))
            {
                reader = new XmlTextReader(fileName);

                while (reader.Read())
                {
                    if(reader.Name == "ToDo" && reader.NodeType == XmlNodeType.Element)
                    {
                        todos.Add(ReadToDo());
                    }
                }

                reader.Close();
            }

            return todos;
        }

        private ToDo ReadToDo()
        {
            ToDo todo = new ToDo();

            while(reader.Read() && reader.Name != "ToDo")
            {
                if(reader.Name == "ID")
                {
                    todo.ID = Convert.ToInt32(reader.ReadElementContentAsString());
                }

                if (reader.Name == "Beschreibung")
                {
                    todo.Beschreibung = reader.ReadElementContentAsString();
                }

                if (reader.Name == "Erledigt")
                {
                    todo.Erledigt = Boolean.Parse(reader.ReadElementContentAsString().ToLower());
                }
            }

            return todo;
        }

        public void SpeichereToDos(BindingList<ToDo> todos)
        {
            writer = new XmlTextWriter(fileName, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            writer.WriteStartElement("ToDos");
            
            foreach(ToDo todo in todos)
            {
                SpeichereToDo(todo);
            }

            writer.Flush();
            writer.Close();
        }

        private void SpeichereToDo(ToDo todo)
        {
            writer.WriteStartElement("ToDo");
            writer.WriteElementString("ID", todo.ID.ToString());
            writer.WriteElementString("Beschreibung", todo.Beschreibung);
            writer.WriteElementString("Erledigt", todo.Erledigt.ToString());
            writer.WriteEndElement();
        }
    }
}
