using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7028;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7028Service : CrudService<TABLE7028, TABLE7028Dto, CreateTABLE7028Dto, UpdateTABLE7028Dto, long>, ITABLE7028Service
{
    public TABLE7028Service(IRepository<TABLE7028> repository)
        : base(repository, TABLE7028MappingExtensions.ToDto, TABLE7028MappingExtensions.ToEntity, TABLE7028MappingExtensions.UpdateEntity) { }
}
