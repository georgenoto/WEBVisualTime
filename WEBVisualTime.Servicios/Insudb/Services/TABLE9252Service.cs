using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9252Service : CrudService<TABLE9252, TABLE9252Dto, CreateTABLE9252Dto, UpdateTABLE9252Dto, int>, ITABLE9252Service
{
    public TABLE9252Service(IRepository<TABLE9252> repository)
        : base(repository, TABLE9252MappingExtensions.ToDto, TABLE9252MappingExtensions.ToEntity, TABLE9252MappingExtensions.UpdateEntity) { }
}
