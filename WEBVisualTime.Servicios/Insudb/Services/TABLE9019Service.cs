using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9019;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9019Service : CrudService<TABLE9019, TABLE9019Dto, CreateTABLE9019Dto, UpdateTABLE9019Dto, int>, ITABLE9019Service
{
    public TABLE9019Service(IRepository<TABLE9019> repository)
        : base(repository, TABLE9019MappingExtensions.ToDto, TABLE9019MappingExtensions.ToEntity, TABLE9019MappingExtensions.UpdateEntity) { }
}
