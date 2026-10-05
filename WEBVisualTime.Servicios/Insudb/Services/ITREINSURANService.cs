using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITREINSURANService : IService<TREINSURANDto, CreateTREINSURANDto, UpdateTREINSURANDto, string>
{
    Task<IEnumerable<TREINSURANDto>> FindAsync(Expression<Func<TREINSURAN, bool>> predicate);
}
