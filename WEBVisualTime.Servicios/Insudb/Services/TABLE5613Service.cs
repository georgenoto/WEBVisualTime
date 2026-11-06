using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5613;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5613Service : CrudService<TABLE5613, TABLE5613Dto, CreateTABLE5613Dto, UpdateTABLE5613Dto, int>, ITABLE5613Service
{
    public TABLE5613Service(IRepository<TABLE5613> repository)
        : base(repository, TABLE5613MappingExtensions.ToDto, TABLE5613MappingExtensions.ToEntity, TABLE5613MappingExtensions.UpdateEntity) { }
}
