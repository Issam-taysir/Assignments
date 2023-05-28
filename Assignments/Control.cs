using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            string controlType = controltype.Text;

            if (int.TryParse(txtnumofcontrols.Text, out int numberOfControls))
            {
                for (int i = 0; i < numberOfControls; i++)
                {
                    if (controlType == "button")
                    {
                        Button newButton = new Button();
                        newButton.Name = "Button " + (i + 1);
                        newButton.Text = "Button " + (i + 1);
                        newButton.Size = new Size(120, 40);
                        newButton.Location = new Point(0, (i * 50));

                        panel.Controls.Add(newButton);
                    }
                    else if (controlType == "textbox")
                    {
                        TextBox newTextBox = new TextBox();
                        newTextBox.Name = "TextBox " + (i + 1);
                        newTextBox.Text = "TextBox " + (i + 1);
                        newTextBox.Size = new Size(120, 40);
                        newTextBox.Location = new Point(0, (i * 50));

                        panel.Controls.Add(newTextBox);
                    }
                    else if (controlType == "label")
                    {
                        Label newLabel = new Label();
                        newLabel.Name = "Label " + (i + 1);
                        newLabel.Text = "Label " + (i + 1);
                        newLabel.Size = new Size(120, 40);
                        newLabel.Location = new Point(0, (i * 50));

                        panel.Controls.Add(newLabel);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid number of controls. Please enter a valid integer.");
            }
        }

    }
}
