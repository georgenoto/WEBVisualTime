using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_OFFICE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IUSER_OFFICEService : IService<USER_OFFICEDto, CreateUSER_OFFICEDto, UpdateUSER_OFFICEDto, int>
{
    Task<IEnumerable<USER_OFFICEDto>> FindAsync(Expression<Func<USER_OFFICE, bool>> predicate);
}
