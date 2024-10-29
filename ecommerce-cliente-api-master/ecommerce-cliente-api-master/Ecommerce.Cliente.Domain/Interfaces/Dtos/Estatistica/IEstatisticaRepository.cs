using Ecommerce.Estatistica.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.Estatistica.Domain.Interfaces
{
    public interface IEstatisticaRepository
    {
        IEnumerable<EstatisticaEntity> ObterTodos();
        EstatisticaEntity ObterPorId(string id);
        EstatisticaEntity Adicionar(EstatisticaEntity estatistica);
        EstatisticaEntity Editar(EstatisticaEntity estatistica);
        EstatisticaEntity Remover(string id);
    }
}
