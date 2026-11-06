using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE157;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE157Service : CrudService<TABLE157, TABLE157Dto, CreateTABLE157Dto, UpdateTABLE157Dto, long>, ITABLE157Service
{
    public TABLE157Service(IRepository<TABLE157> repository)
        : base(repository, TABLE157MappingExtensions.ToDto, TABLE157MappingExtensions.ToEntity, TABLE157MappingExtensions.UpdateEntity) { }
}
