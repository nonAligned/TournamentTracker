namespace TrackUI
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
            ApplicationConfiguration.Initialize();

            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.Sql);

            // Application.Run(new TournamentDashboardForm());
            Application.Run(new TournamentDashboardForm());
        }
    }
}