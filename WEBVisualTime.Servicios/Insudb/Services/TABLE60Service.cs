using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE60;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE60Service : CrudService<TABLE60, TABLE60Dto, CreateTABLE60Dto, UpdateTABLE60Dto, long>, ITABLE60Service
{
    public TABLE60Service(IRepository<TABLE60> repository)
        : base(repository, TABLE60MappingExtensions.ToDto, TABLE60MappingExtensions.ToEntity, TABLE60MappingExtensions.UpdateEntity) { }
}
