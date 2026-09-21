namespace Grafisch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Form f1 = new Form();
            f1.Text = "Hello";

            
            Button btn1 = new Button();
            btn1.Text = "Click Me!!!";
            btn1.Location = new Point(100, 100);
            btn1.Height = 80;
            btn1.Width = 160;
            btn1.Click += DoeIets;

            f1.Controls.Add(btn1);

            f1.ShowDialog();

        }

        static void DoeIets(object? sender, EventArgs e)
        {
            (sender as Button)?.BackColor = Color.Green;
        }
    }
}