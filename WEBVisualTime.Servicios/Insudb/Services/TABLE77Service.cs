using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE77;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE77Service : CrudService<TABLE77, TABLE77Dto, CreateTABLE77Dto, UpdateTABLE77Dto, int>, ITABLE77Service
{
    public TABLE77Service(IRepository<TABLE77> repository)
        : base(repository, TABLE77MappingExtensions.ToDto, TABLE77MappingExtensions.ToEntity, TABLE77MappingExtensions.UpdateEntity) { }
}
