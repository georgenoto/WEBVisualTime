using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9229;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9229Service : CrudService<TABLE9229, TABLE9229Dto, CreateTABLE9229Dto, UpdateTABLE9229Dto, int>, ITABLE9229Service
{
    public TABLE9229Service(IRepository<TABLE9229> repository)
        : base(repository, TABLE9229MappingExtensions.ToDto, TABLE9229MappingExtensions.ToEntity, TABLE9229MappingExtensions.UpdateEntity) { }
}
