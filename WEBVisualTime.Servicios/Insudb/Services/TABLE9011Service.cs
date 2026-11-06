using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9011;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9011Service : CrudService<TABLE9011, TABLE9011Dto, CreateTABLE9011Dto, UpdateTABLE9011Dto, int>, ITABLE9011Service
{
    public TABLE9011Service(IRepository<TABLE9011> repository)
        : base(repository, TABLE9011MappingExtensions.ToDto, TABLE9011MappingExtensions.ToEntity, TABLE9011MappingExtensions.UpdateEntity) { }
}
