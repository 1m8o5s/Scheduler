using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ZoomScheduler
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private List<Button> homeworkButtons;
        private int pageNumber;
        public Form1()
        {
            InitializeComponent();
            homeworkButtons = new List<Button>();
            pageNumber = 0;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            CreateAndEditSchedule form2 = new CreateAndEditSchedule();
            form2.ShowDialog();
        }


        private void changeTabTextWithTextOfLineField(object sender, EventArgs e)
        {
            TextBoxBase lineWhereTextWasChanged = (TextBoxBase)sender;
            tabControl1.SelectedTab.Text = lineWhereTextWasChanged.Text;
        }

        private MaterialRaisedButton configureButton(MaterialRaisedButton bt)
        {
            var button = bt;
            button.Depth = 0;
            button.Location = new System.Drawing.Point(612, 3);
            button.MouseState = MaterialSkin.MouseState.HOVER;
            button.Primary = true;
            button.Size = new System.Drawing.Size(160, 23);
            button.TabIndex = 2;
            button.Text = "Зберегти";
            button.UseVisualStyleBackColor = true;
            return button;
        }

        private MaterialSingleLineTextField configureTextLine(MaterialSingleLineTextField l)
        {
            var line = l;
            line.Depth = 0;
            line.Hint = "Назва завдання";
            line.Location = new System.Drawing.Point(6, 3);
            line.MouseState = MaterialSkin.MouseState.HOVER;
            line.PasswordChar = '\0';
            line.SelectedText = "";
            line.SelectionLength = 0;
            line.SelectionStart = 0;
            line.Size = new System.Drawing.Size(199, 23);
            line.TabIndex = 0;
            line.UseSystemPasswordChar = false;
            line.TextChanged += new System.EventHandler(this.changeTabTextWithTextOfLineField);
            return line;
        }

        private RichTextBox configureRichTextBox(RichTextBox r)
        {
            var textBox = r;
            textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox.Location = new System.Drawing.Point(3, 29);
            textBox.Size = new System.Drawing.Size(772, 296);
            textBox.TabIndex = 1;
            textBox.Text = "";
            return textBox;
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                tabControl1.SelectedTab.Text = "";
                tabControl1.TabPages.Add("Нове завдання");
                tabControl1.SelectedTab.BackColor = Color.White;
                var selectedTab = tabControl1.SelectedTab;
                selectedTab.Controls.Add(configureButton(new MaterialRaisedButton()));
                selectedTab.Controls.Add(configureTextLine(new MaterialSingleLineTextField()));
                selectedTab.Controls.Add(configureRichTextBox(new RichTextBox()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            --pageNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++pageNumber;
        }
    }
}
