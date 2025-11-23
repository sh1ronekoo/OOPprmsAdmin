namespace admindash.Records_Dashboard
{
    partial class CancelledApp
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
            listViewCancelled = new ListView();
            SuspendLayout();
            // 
            // listViewCancelled
            // 
            listViewCancelled.Location = new Point(0, 0);
            listViewCancelled.Name = "listViewCancelled";
            listViewCancelled.Size = new Size(798, 427);
            listViewCancelled.TabIndex = 0;
            listViewCancelled.UseCompatibleStateImageBehavior = false;
            // 
            // CancelledApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 427);
            Controls.Add(listViewCancelled);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelledApp";
            Text = "CancelledApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewCancelled;
    }
}