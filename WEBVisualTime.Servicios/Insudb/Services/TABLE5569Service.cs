using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5569;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5569Service : CrudService<TABLE5569, TABLE5569Dto, CreateTABLE5569Dto, UpdateTABLE5569Dto, int>, ITABLE5569Service
{
    public TABLE5569Service(IRepository<TABLE5569> repository)
        : base(repository, TABLE5569MappingExtensions.ToDto, TABLE5569MappingExtensions.ToEntity, TABLE5569MappingExtensions.UpdateEntity) { }
}
