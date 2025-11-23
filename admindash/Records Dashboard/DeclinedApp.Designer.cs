namespace admindash.Records_Dashboard
{
    partial class DeclinedApp
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
            listViewDeclined = new ListView();
            SuspendLayout();
            // 
            // listViewDeclined
            // 
            listViewDeclined.BorderStyle = BorderStyle.FixedSingle;
            listViewDeclined.Location = new Point(0, 0);
            listViewDeclined.Name = "listViewDeclined";
            listViewDeclined.Size = new Size(798, 427);
            listViewDeclined.TabIndex = 0;
            listViewDeclined.UseCompatibleStateImageBehavior = false;
            // 
            // DeclinedApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 427);
            Controls.Add(listViewDeclined);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeclinedApp";
            Text = "DeclinedApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDeclined;
    }
}