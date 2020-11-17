using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ZoomScheduler
{
    public class ContestsEventPublisher
    {

        public event EventHandler<ContestsEventArgs> ContestsEventEvent;
        ContestsEventPublisher(MaterialRaisedButton component)
        {
            OnRaiseCustomEvent(new ContestsEventArgs(component));
        }

        protected virtual void OnRaiseCustomEvent(ContestsEventArgs e)
        {
            ContestsEventEvent?.Invoke(this, e);
        }
    }
}
