using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ZoomScheduler
{
    public class ContestsEventArgs : EventArgs
    {
        public ContestsEventArgs(MaterialRaisedButton component)
        {
            Message = component;
        }

        public Button Message { get; set; }
    }
}
