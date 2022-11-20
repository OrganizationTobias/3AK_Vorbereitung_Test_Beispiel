namespace _3AK_Vorbereitung_Test_Beispiel
{
    public class ToDo
    {
        public ToDo(int id, string beschreibung, bool erledigt)
        {
            ID = id;
            Beschreibung = beschreibung;
            Erledigt = erledigt;
        }

        public ToDo() { }



        public int ID { get; set; }

        public string Beschreibung { get; set;}

        public bool Erledigt { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} - {Beschreibung}";
        }
    }
}