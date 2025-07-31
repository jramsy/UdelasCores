namespace UdelasCore.SistemaDeTernas.Helpers
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
                    Icon = "fa-solid fa-house",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> { "Rectora", "Creador" }
                },
                new MenuItem
                {
                    Titulo = "Informe",
                    Icon = "fa-solid fa-file-contract",
                    AspController = "Home",
                    AspAction = "Index",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Revision",
                    Icon = "fa-solid fa-list-check",
                    AspController = "Terna",
                    AspAction = "Index",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Historial",
                    Icon = "fa-solid fa-clock-rotate-left",
                    AspController = "Terna",
                    AspAction = "Historial",
                    Roles = new List<string> {"Rectora" }
                },
                new MenuItem
                {
                    Titulo = "Registro",
                    Icon = "fa-solid fa-file",
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
