using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE255;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE255Service : CrudService<TABLE255, TABLE255Dto, CreateTABLE255Dto, UpdateTABLE255Dto, long>, ITABLE255Service
{
    public TABLE255Service(IRepository<TABLE255> repository)
        : base(repository, TABLE255MappingExtensions.ToDto, TABLE255MappingExtensions.ToEntity, TABLE255MappingExtensions.UpdateEntity) { }
}
