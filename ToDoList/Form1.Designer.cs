namespace ToDoList
{
    partial class ToDoList
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
        private void InitializeComponent()
        {
            Title = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(46, 24);
            Title.Name = "Title";
            Title.Size = new Size(1343, 99);
            Title.TabIndex = 0;
            Title.Text = "To Do List";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1418, 733);
            Controls.Add(Title);
            Name = "ToDoList";
            Text = "ToDoList";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
    }
}