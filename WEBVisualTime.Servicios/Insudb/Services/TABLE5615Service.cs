using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5615;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5615Service : CrudService<TABLE5615, TABLE5615Dto, CreateTABLE5615Dto, UpdateTABLE5615Dto, long>, ITABLE5615Service
{
    public TABLE5615Service(IRepository<TABLE5615> repository)
        : base(repository, TABLE5615MappingExtensions.ToDto, TABLE5615MappingExtensions.ToEntity, TABLE5615MappingExtensions.UpdateEntity) { }
}
