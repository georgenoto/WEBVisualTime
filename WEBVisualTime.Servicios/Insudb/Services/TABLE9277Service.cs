using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9277;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9277Service : CrudService<TABLE9277, TABLE9277Dto, CreateTABLE9277Dto, UpdateTABLE9277Dto, int>, ITABLE9277Service
{
    public TABLE9277Service(IRepository<TABLE9277> repository)
        : base(repository, TABLE9277MappingExtensions.ToDto, TABLE9277MappingExtensions.ToEntity, TABLE9277MappingExtensions.UpdateEntity) { }
}
