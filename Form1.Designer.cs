namespace Note_App
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
        private void InitializeComponent()
        {
            titleHeading = new Label();
            messsageHeading = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // titleHeading
            // 
            titleHeading.AutoSize = true;
            titleHeading.Location = new Point(12, 60);
            titleHeading.Name = "titleHeading";
            titleHeading.Size = new Size(38, 20);
            titleHeading.TabIndex = 0;
            titleHeading.Text = "Title";
            // 
            // messsageHeading
            // 
            messsageHeading.AutoSize = true;
            messsageHeading.Location = new Point(12, 125);
            messsageHeading.Name = "messsageHeading";
            messsageHeading.Size = new Size(67, 20);
            messsageHeading.TabIndex = 1;
            messsageHeading.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(85, 57);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(264, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(85, 122);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(264, 184);
            txtMessage.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(85, 355);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(238, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(433, 355);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 7;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(596, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.Size = new Size(300, 249);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

           


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(messsageHeading);
            Controls.Add(titleHeading);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleHeading;
        private Label messsageHeading;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private Button btnNew;
        private Button btnSave;
        private Button btnRead;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}
