namespace WinFormsApp1
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
            // ApplicationConfiguration.Initialize();

            var f1 = new Form1();
            f1.MouseMove += F1_MouseMove;
            //Application.Run(f1);
            Console.WriteLine("Start");
            f1.ShowDialog();

            Console.ReadLine();
        }

        private static void F1_MouseMove(object? sender, MouseEventArgs e)
        {
            (sender as Form).Text = $"({e.X}, {e.Y})";
            //Console.WriteLine($"({e.X}, {e.Y})");
        }
    }
}