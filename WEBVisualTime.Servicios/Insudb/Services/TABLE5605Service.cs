using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5605;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5605Service : CrudService<TABLE5605, TABLE5605Dto, CreateTABLE5605Dto, UpdateTABLE5605Dto, int>, ITABLE5605Service
{
    public TABLE5605Service(IRepository<TABLE5605> repository)
        : base(repository, TABLE5605MappingExtensions.ToDto, TABLE5605MappingExtensions.ToEntity, TABLE5605MappingExtensions.UpdateEntity) { }
}
