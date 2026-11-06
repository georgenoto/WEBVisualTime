using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5712;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5712Service : CrudService<TABLE5712, TABLE5712Dto, CreateTABLE5712Dto, UpdateTABLE5712Dto, int>, ITABLE5712Service
{
    public TABLE5712Service(IRepository<TABLE5712> repository)
        : base(repository, TABLE5712MappingExtensions.ToDto, TABLE5712MappingExtensions.ToEntity, TABLE5712MappingExtensions.UpdateEntity) { }
}
