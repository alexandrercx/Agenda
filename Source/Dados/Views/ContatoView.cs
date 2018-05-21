using System.Collections.Generic;

namespace Dados.Views
{
    public class ContatoView
    {
        public int IdContato { get; set; }

        public string NomeContato { get; set; }

        public List<string> Numeros { get; set; }

        public List<string> Emails { get; set; }

    }
}
