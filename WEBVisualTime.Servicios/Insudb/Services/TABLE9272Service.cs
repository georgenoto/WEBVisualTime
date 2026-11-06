using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9272;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9272Service : CrudService<TABLE9272, TABLE9272Dto, CreateTABLE9272Dto, UpdateTABLE9272Dto, int>, ITABLE9272Service
{
    public TABLE9272Service(IRepository<TABLE9272> repository)
        : base(repository, TABLE9272MappingExtensions.ToDto, TABLE9272MappingExtensions.ToEntity, TABLE9272MappingExtensions.UpdateEntity) { }
}
