using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9005Service : CrudService<TABLE9005, TABLE9005Dto, CreateTABLE9005Dto, UpdateTABLE9005Dto, int>, ITABLE9005Service
{
    public TABLE9005Service(IRepository<TABLE9005> repository)
        : base(repository, TABLE9005MappingExtensions.ToDto, TABLE9005MappingExtensions.ToEntity, TABLE9005MappingExtensions.UpdateEntity) { }
}
