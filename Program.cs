namespace ProjetGestionD_AgenceImmobilière
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadingForm loadingForm = new LoadingForm();
            Application.Run(loadingForm);
        }
    }
}