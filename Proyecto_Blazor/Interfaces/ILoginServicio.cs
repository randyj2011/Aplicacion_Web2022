using Modelos;

namespace Proyecto_Blazor.Interfaces
{
    public interface ILoginServicio
    {
        Task<bool> ValidarUsuario(Login login);
    }
}
