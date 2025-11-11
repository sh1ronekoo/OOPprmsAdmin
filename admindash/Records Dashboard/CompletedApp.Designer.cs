namespace admindash.Records_Dashboard
{
    partial class CompletedApp
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
            listViewCompleted = new ListView();
            SuspendLayout();
            // 
            // listViewCompleted
            // 
            listViewCompleted.Location = new Point(0, 0);
            listViewCompleted.Name = "listViewCompleted";
            listViewCompleted.Size = new Size(668, 427);
            listViewCompleted.TabIndex = 0;
            listViewCompleted.UseCompatibleStateImageBehavior = false;
            // 
            // CompletedApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 427);
            Controls.Add(listViewCompleted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompletedApp";
            Text = "CompletedApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewCompleted;
    }
}