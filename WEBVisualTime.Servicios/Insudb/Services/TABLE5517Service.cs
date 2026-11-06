using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5517;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5517Service : CrudService<TABLE5517, TABLE5517Dto, CreateTABLE5517Dto, UpdateTABLE5517Dto, int>, ITABLE5517Service
{
    public TABLE5517Service(IRepository<TABLE5517> repository)
        : base(repository, TABLE5517MappingExtensions.ToDto, TABLE5517MappingExtensions.ToEntity, TABLE5517MappingExtensions.UpdateEntity) { }
}
