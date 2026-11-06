using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9223Service : CrudService<TABLE9223, TABLE9223Dto, CreateTABLE9223Dto, UpdateTABLE9223Dto, int>, ITABLE9223Service
{
    public TABLE9223Service(IRepository<TABLE9223> repository)
        : base(repository, TABLE9223MappingExtensions.ToDto, TABLE9223MappingExtensions.ToEntity, TABLE9223MappingExtensions.UpdateEntity) { }
}
