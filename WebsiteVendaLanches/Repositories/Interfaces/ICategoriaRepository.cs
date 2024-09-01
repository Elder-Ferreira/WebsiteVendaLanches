using WebsiteVendaLanches.Models;

namespace WebsiteVendaLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
