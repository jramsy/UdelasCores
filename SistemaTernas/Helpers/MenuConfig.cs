namespace SistemaTernas.Helpers
{
    public static class MenuConfig
    {
        public static List<MenuItem> ObtenerMenus()
        {
            return new List<MenuItem>()
            {
                new MenuItem
                {
                    Titulo = "Inicio",
                    Icon = "home",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> { "Rectora", "Creador" }
                },
                new MenuItem
                {
                    Titulo = "Informe",
                    Icon = "home",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Revision",
                    Icon = "home",
                    AspController = "Terna",
                    AspAction = "Index",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Historial",
                    Icon = "home",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Registro",
                    Icon = "home",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> {"Creador" }
                },
                new MenuItem
                {
                    Titulo = "Historial",
                    Icon = "home",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> {"Creador" }
                },
            };
        }
    }
}
