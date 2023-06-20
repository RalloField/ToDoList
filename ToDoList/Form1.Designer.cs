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
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            newToDo = new Button();
            saveToDo = new Button();
            editToDo = new Button();
            deleteToDo = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(46, 24);
            Title.Name = "Title";
            Title.Size = new Size(2208, 99);
            Title.TabIndex = 0;
            Title.Text = "To Do List";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(46, 171);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1198, 39);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(46, 281);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1198, 39);
            descriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 229);
            label1.Name = "label1";
            label1.Size = new Size(1198, 36);
            label1.TabIndex = 3;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 123);
            label2.Name = "label2";
            label2.Size = new Size(1198, 36);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // newToDo
            // 
            newToDo.Location = new Point(46, 354);
            newToDo.Name = "newToDo";
            newToDo.Size = new Size(278, 46);
            newToDo.TabIndex = 5;
            newToDo.Text = "New";
            newToDo.UseVisualStyleBackColor = true;
            newToDo.Click += newToDo_Click;
            // 
            // saveToDo
            // 
            saveToDo.Location = new Point(357, 354);
            saveToDo.Name = "saveToDo";
            saveToDo.Size = new Size(278, 46);
            saveToDo.TabIndex = 6;
            saveToDo.Text = "Save";
            saveToDo.UseVisualStyleBackColor = true;
            saveToDo.Click += saveToDo_Click;
            // 
            // editToDo
            // 
            editToDo.Location = new Point(660, 354);
            editToDo.Name = "editToDo";
            editToDo.Size = new Size(278, 46);
            editToDo.TabIndex = 7;
            editToDo.Text = "Edit";
            editToDo.UseVisualStyleBackColor = true;
            editToDo.Click += editToDo_Click;
            // 
            // deleteToDo
            // 
            deleteToDo.Location = new Point(966, 354);
            deleteToDo.Name = "deleteToDo";
            deleteToDo.Size = new Size(278, 46);
            deleteToDo.TabIndex = 8;
            deleteToDo.Text = "Delete";
            deleteToDo.UseVisualStyleBackColor = true;
            deleteToDo.Click += deleteToDo_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.FromArgb(255, 192, 192);
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(1322, 171);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 82;
            toDoListView.RowTemplate.Height = 41;
            toDoListView.Size = new Size(917, 628);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(2266, 850);
            Controls.Add(toDoListView);
            Controls.Add(deleteToDo);
            Controls.Add(editToDo);
            Controls.Add(saveToDo);
            Controls.Add(newToDo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(Title);
            Name = "ToDoList";
            Text = "ToDoList";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label1;
        private Label label2;
        private Button newToDo;
        private Button saveToDo;
        private Button editToDo;
        private Button deleteToDo;
        private DataGridView toDoListView;
    }
}