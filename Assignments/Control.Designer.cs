namespace Assignments
{
    partial class Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.txtnumofcontrols = new System.Windows.Forms.TextBox();
            this.controltype = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(72, 148);
            this.Add.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(173, 67);
            this.Add.TabIndex = 11;
            this.Add.Text = "Create controls";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtnumofcontrols
            // 
            this.txtnumofcontrols.Location = new System.Drawing.Point(153, 83);
            this.txtnumofcontrols.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtnumofcontrols.Name = "txtnumofcontrols";
            this.txtnumofcontrols.Size = new System.Drawing.Size(173, 24);
            this.txtnumofcontrols.TabIndex = 10;
            // 
            // controltype
            // 
            this.controltype.FormattingEnabled = true;
            this.controltype.Items.AddRange(new object[] {
            "button",
            "textbox",
            "lable"});
            this.controltype.Location = new System.Drawing.Point(115, 30);
            this.controltype.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.controltype.Name = "controltype";
            this.controltype.Size = new System.Drawing.Size(173, 24);
            this.controltype.TabIndex = 9;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(15, 223);
            this.panel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(298, 273);
            this.panel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control Type";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 509);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtnumofcontrols);
            this.Controls.Add(this.controltype);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Control";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtnumofcontrols;
        private System.Windows.Forms.ComboBox controltype;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

