namespace EjNotaEscolares
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
            Application.Run(new formNotas());
        }

        //public static class planilla
        //{
            public static string[,] datos = new string[10, 4];
            // 10 filas para cargar hasta 10 notas
            // columna 0: nombre
            //columna 1: materia
            // columna 2: nota
            // columna 3: tipo de nota
       // }
    }
}