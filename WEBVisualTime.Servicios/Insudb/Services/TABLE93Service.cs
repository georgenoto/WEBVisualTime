using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE93;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE93Service : CrudService<TABLE93, TABLE93Dto, CreateTABLE93Dto, UpdateTABLE93Dto, int>, ITABLE93Service
{
    public TABLE93Service(IRepository<TABLE93> repository)
        : base(repository, TABLE93MappingExtensions.ToDto, TABLE93MappingExtensions.ToEntity, TABLE93MappingExtensions.UpdateEntity) { }
}
