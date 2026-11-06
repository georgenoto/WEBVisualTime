using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE52Service : CrudService<TABLE52, TABLE52Dto, CreateTABLE52Dto, UpdateTABLE52Dto, string>, ITABLE52Service
{
    public TABLE52Service(IRepository<TABLE52> repository)
        : base(repository, TABLE52MappingExtensions.ToDto, TABLE52MappingExtensions.ToEntity, TABLE52MappingExtensions.UpdateEntity) { }
}
