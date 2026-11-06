using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9242Service : CrudService<TABLE9242, TABLE9242Dto, CreateTABLE9242Dto, UpdateTABLE9242Dto, int>, ITABLE9242Service
{
    public TABLE9242Service(IRepository<TABLE9242> repository)
        : base(repository, TABLE9242MappingExtensions.ToDto, TABLE9242MappingExtensions.ToEntity, TABLE9242MappingExtensions.UpdateEntity) { }
}
