using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomScheduler
{
    public partial class CreateAndEditSchedule : MaterialSkin.Controls.MaterialForm
    {
        private int diferenceBetweenPanels;
        private Point firstDayPanelLocation;
        private List<Panel> dayPanels;
        private List<List<Component> > componentsInPanels;
        private List<ComboBox> dayNames;
        private List<ComboBox> lessonNumbers;
        private List<ComboBox> lessonNames;
        private List<ComboBox> lessonTypes;
        
        public CreateAndEditSchedule()
        {
            InitializeComponent();
            diferenceBetweenPanels = 20;
            firstDayPanelLocation = new Point(35, 86);
            dayPanels = new List<Panel>();
            dayNames = new List<ComboBox>();
            lessonNumbers = new List<ComboBox>();
            lessonNames = new List<ComboBox>();
            lessonTypes = new List<ComboBox>();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Point locationOfPanel = new Point(35, 0);
            if (dayPanels.Count == 0)
            {
                locationOfPanel.Y = 86;
            }
            else
            {
                Panel lastPanel = dayPanels.Last();
                locationOfPanel.Y = lastPanel.Location.Y + lastPanel.Size.Height + diferenceBetweenPanels;
            }

            Panel newPanel = new Panel();
            newPanel.Location = locationOfPanel;
            newPanel.Size = new Size(648, 265);
            newPanel.Visible = true;
            //newPanel.Click += new EventHandler<int>(reactOnClick, 2);
            dayPanels.Add(newPanel);
            this.Controls.Add(dayPanels[0]);
        }

        private void reactOnClick(object sender, EventArgs e, int a)
        {
            
        }
    }
}
