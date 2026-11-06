using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8060Service : CrudService<TABLE8060, TABLE8060Dto, CreateTABLE8060Dto, UpdateTABLE8060Dto, long>, ITABLE8060Service
{
    public TABLE8060Service(IRepository<TABLE8060> repository)
        : base(repository, TABLE8060MappingExtensions.ToDto, TABLE8060MappingExtensions.ToEntity, TABLE8060MappingExtensions.UpdateEntity) { }
}
