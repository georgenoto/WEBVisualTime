using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE196;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE196Service : CrudService<TABLE196, TABLE196Dto, CreateTABLE196Dto, UpdateTABLE196Dto, long>, ITABLE196Service
{
    public TABLE196Service(IRepository<TABLE196> repository)
        : base(repository, TABLE196MappingExtensions.ToDto, TABLE196MappingExtensions.ToEntity, TABLE196MappingExtensions.UpdateEntity) { }
}
