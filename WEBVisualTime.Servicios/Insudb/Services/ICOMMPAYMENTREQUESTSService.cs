using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMPAYMENTREQUESTSService : IService<COMMPAYMENTREQUESTSDto, CreateCOMMPAYMENTREQUESTSDto, UpdateCOMMPAYMENTREQUESTSDto, long>
{
    Task<IEnumerable<COMMPAYMENTREQUESTSDto>> FindAsync(Expression<Func<COMMPAYMENTREQUESTS, bool>> predicate);
}
