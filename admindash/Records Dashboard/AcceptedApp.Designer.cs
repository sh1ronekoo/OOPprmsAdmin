namespace admindash.Records_Dashboard
{
    partial class AcceptedApp
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
            listViewAccepted = new ListView();
            btnCompleteBook = new Button();
            btnCancelBook = new Button();
            SuspendLayout();
            // 
            // listViewAccepted
            // 
            listViewAccepted.Location = new Point(0, 0);
            listViewAccepted.Name = "listViewAccepted";
            listViewAccepted.Size = new Size(578, 427);
            listViewAccepted.TabIndex = 0;
            listViewAccepted.UseCompatibleStateImageBehavior = false;
            listViewAccepted.SelectedIndexChanged += listViewAccepted_SelectedIndexChanged;
            // 
            // btnCompleteBook
            // 
            btnCompleteBook.Location = new Point(584, 387);
            btnCompleteBook.Name = "btnCompleteBook";
            btnCompleteBook.Size = new Size(75, 23);
            btnCompleteBook.TabIndex = 2;
            btnCompleteBook.Text = "Complete";
            btnCompleteBook.UseVisualStyleBackColor = true;
            btnCompleteBook.Click += btnCompleteBook_Click;
            // 
            // btnCancelBook
            // 
            btnCancelBook.Location = new Point(584, 358);
            btnCancelBook.Name = "btnCancelBook";
            btnCancelBook.Size = new Size(75, 23);
            btnCancelBook.TabIndex = 3;
            btnCancelBook.Text = "Cancel";
            btnCancelBook.UseVisualStyleBackColor = true;
            btnCancelBook.Click += btnCancelBook_Click;
            // 
            // AcceptedApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 427);
            Controls.Add(btnCompleteBook);
            Controls.Add(btnCancelBook);
            Controls.Add(listViewAccepted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcceptedApp";
            Text = "AcceptedApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAccepted;
        private Button btnCompleteBook;
        private Button btnCancelBook;
    }
}