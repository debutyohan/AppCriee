using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    class HiddenObject
    {
        public static void Hide(List<Control> listeobjet)
        {
            foreach (Control element in listeobjet)
            {
                element.Hide();
            }
        }
    }
}
