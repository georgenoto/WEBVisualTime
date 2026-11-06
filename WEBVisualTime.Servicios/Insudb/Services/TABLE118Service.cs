using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE118;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE118Service : CrudService<TABLE118, TABLE118Dto, CreateTABLE118Dto, UpdateTABLE118Dto, int>, ITABLE118Service
{
    public TABLE118Service(IRepository<TABLE118> repository)
        : base(repository, TABLE118MappingExtensions.ToDto, TABLE118MappingExtensions.ToEntity, TABLE118MappingExtensions.UpdateEntity) { }
}
