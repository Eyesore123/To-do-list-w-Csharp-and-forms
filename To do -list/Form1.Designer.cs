namespace To_do__list
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 


        // Here we use list data type to ensure that the tasks can change dynamically
        private List<string> tasks = new List<string>();

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            // Custom properties for drawing the listbox items!!!

            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 43);
            label1.Name = "label1";
            label1.Size = new Size(185, 50);
            label1.TabIndex = 0;
            label1.Text = "To do -list";
            // 
            // button1
            // 
            button1.Location = new Point(770, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 1;
            button1.Text = "Add a task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(770, 376);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 2;
            button2.Text = "Delete a task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += deleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 174);
            textBox1.MinimumSize = new Size(100, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 100);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(336, 291);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(400, 274);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 690);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "To do -list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;

        // Custom function for drawing listbox1 comes here and is still missing. It's used to improve the styles since listbox doesn't support text-aligned drawing and such.

        // Function for adding event handlers to the buttons:

        private void addButton_Click(object sender, EventArgs e)
        { // Note: text inside the textbox is always a string and doesn't need any conversions, but when you extract data from the selected item (listbox),
          // you need to use ToString() method first, because the list uses string values and we need to make sure we are both adding and deleting strings
            string newTask = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newTask)) {
                tasks.Add(newTask);
                listBox1.Items.Add(newTask);
                textBox1.Clear();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                string task = listBox1.SelectedItem.ToString();
                tasks.Remove(task);
                listBox1.Items.Remove(task);
            }
        }

    } 
}