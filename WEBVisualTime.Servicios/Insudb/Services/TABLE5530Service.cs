using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5530;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5530Service : CrudService<TABLE5530, TABLE5530Dto, CreateTABLE5530Dto, UpdateTABLE5530Dto, int>, ITABLE5530Service
{
    public TABLE5530Service(IRepository<TABLE5530> repository)
        : base(repository, TABLE5530MappingExtensions.ToDto, TABLE5530MappingExtensions.ToEntity, TABLE5530MappingExtensions.UpdateEntity) { }
}
