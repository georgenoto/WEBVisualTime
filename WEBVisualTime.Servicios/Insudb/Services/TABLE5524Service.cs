using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5524Service : CrudService<TABLE5524, TABLE5524Dto, CreateTABLE5524Dto, UpdateTABLE5524Dto, int>, ITABLE5524Service
{
    public TABLE5524Service(IRepository<TABLE5524> repository)
        : base(repository, TABLE5524MappingExtensions.ToDto, TABLE5524MappingExtensions.ToEntity, TABLE5524MappingExtensions.UpdateEntity) { }
}
