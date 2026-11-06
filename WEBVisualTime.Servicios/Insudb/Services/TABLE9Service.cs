using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9Service : CrudService<TABLE9, TABLE9Dto, CreateTABLE9Dto, UpdateTABLE9Dto, int>, ITABLE9Service
{
    public TABLE9Service(IRepository<TABLE9> repository)
        : base(repository, TABLE9MappingExtensions.ToDto, TABLE9MappingExtensions.ToEntity, TABLE9MappingExtensions.UpdateEntity) { }
}
