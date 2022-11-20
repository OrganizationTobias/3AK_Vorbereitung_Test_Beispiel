using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AK_Vorbereitung_Test_Beispiel
{
    public interface ITodoService
    {
        BindingList<ToDo> LadeToDos();
        void SpeichereToDos(BindingList<ToDo> todos);
    }
}
