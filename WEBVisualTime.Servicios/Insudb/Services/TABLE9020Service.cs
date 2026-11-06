using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9020;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9020Service : CrudService<TABLE9020, TABLE9020Dto, CreateTABLE9020Dto, UpdateTABLE9020Dto, int>, ITABLE9020Service
{
    public TABLE9020Service(IRepository<TABLE9020> repository)
        : base(repository, TABLE9020MappingExtensions.ToDto, TABLE9020MappingExtensions.ToEntity, TABLE9020MappingExtensions.UpdateEntity) { }
}
