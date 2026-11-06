using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5632;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5632Service : CrudService<TABLE5632, TABLE5632Dto, CreateTABLE5632Dto, UpdateTABLE5632Dto, string>, ITABLE5632Service
{
    public TABLE5632Service(IRepository<TABLE5632> repository)
        : base(repository, TABLE5632MappingExtensions.ToDto, TABLE5632MappingExtensions.ToEntity, TABLE5632MappingExtensions.UpdateEntity) { }
}
