using Microsoft.AspNetCore.Components;
using Modelos;
using Proyecto_Blazor.Interfaces;

namespace Proyecto_Blazor.Pages.MisUsuarios
{
    public partial class NuevoUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }

        [Inject] private NavigationManager navigationManager { get; set; }
        private Usuario user = new Usuario();

        protected async void Guardar()
        {
            if (string.IsNullOrEmpty(user.Codigo) || string.IsNullOrEmpty(user.Nombre) || string.IsNullOrEmpty(user.Clave) || string.IsNullOrEmpty(user.Rol) || user.Rol =="Seleccionar")
            {
                return;
            }

            bool inserto = await usuarioServicio.Nuevo(user);

            navigationManager.NavigateTo("/Usuarios");
        }

        protected void Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }

    }
}
enum Roles
{
    Seleccionar,
    Administrador,
    Usuario
}
