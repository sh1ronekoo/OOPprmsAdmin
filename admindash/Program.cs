using System;
using System.Windows.Forms;

namespace admindash
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Check if any accounts exist in DB
            bool hasAccount = DatabaseHelper.HasAnyAccount(); // You will create this method

            if (!hasAccount)
            {
                // Open CreateAccount Form
                using (var createAcc = new CreateAccount())
                {
                    var result = createAcc.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // After creating account → go to LoginForm
                        using (var login = new Login())
                        {
                            if (login.ShowDialog() == DialogResult.OK)
                            {
                                Application.Run(new dashboard()); // your main form
                            }
                        }
                    }
                }
            }
            else
            {
                // Normal login flow
                using (var login = new Login())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new dashboard());
                    }
                }
            }
        }
    }
}
