using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9279Service : CrudService<TABLE9279, TABLE9279Dto, CreateTABLE9279Dto, UpdateTABLE9279Dto, int>, ITABLE9279Service
{
    public TABLE9279Service(IRepository<TABLE9279> repository)
        : base(repository, TABLE9279MappingExtensions.ToDto, TABLE9279MappingExtensions.ToEntity, TABLE9279MappingExtensions.UpdateEntity) { }
}
