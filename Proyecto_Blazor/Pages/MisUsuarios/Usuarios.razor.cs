using Microsoft.AspNetCore.Components;
using Modelos;
using Proyecto_Blazor.Interfaces;
using System.Threading.Tasks.Sources;

namespace Proyecto_Blazor.Pages.MisUsuarios
{
    public partial class Usuarios
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }

        private IEnumerable<Usuario> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista= await usuarioServicio.GetLista();

        }
       
    }
}
