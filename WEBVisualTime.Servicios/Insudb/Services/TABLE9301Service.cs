using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9301;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9301Service : CrudService<TABLE9301, TABLE9301Dto, CreateTABLE9301Dto, UpdateTABLE9301Dto, int>, ITABLE9301Service
{
    public TABLE9301Service(IRepository<TABLE9301> repository)
        : base(repository, TABLE9301MappingExtensions.ToDto, TABLE9301MappingExtensions.ToEntity, TABLE9301MappingExtensions.UpdateEntity) { }
}
