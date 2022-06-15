using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SferaWinFormsApp.Cenniki_Forms;
using SferaWinFormsApp;

namespace SferaWinFormsApp.Klasy
{

    /// <summary>
    /// Obecnie nie używane
    /// </summary>
    class Counter
    {
        public delegate void ActivePanelEventHamdler(object o, EventArgs e);
        public event ActivePanelEventHamdler ActivePanelE;

        protected virtual void OnActivePanel()
        {
            ActivePanelE?.Invoke(this, EventArgs.Empty);
        }

    }
}
