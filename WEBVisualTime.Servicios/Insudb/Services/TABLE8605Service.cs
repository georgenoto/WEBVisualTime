using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8605Service : CrudService<TABLE8605, TABLE8605Dto, CreateTABLE8605Dto, UpdateTABLE8605Dto, string>, ITABLE8605Service
{
    public TABLE8605Service(IRepository<TABLE8605> repository)
        : base(repository, TABLE8605MappingExtensions.ToDto, TABLE8605MappingExtensions.ToEntity, TABLE8605MappingExtensions.UpdateEntity) { }
}
