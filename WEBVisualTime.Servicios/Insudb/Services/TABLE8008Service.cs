using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8008;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8008Service : CrudService<TABLE8008, TABLE8008Dto, CreateTABLE8008Dto, UpdateTABLE8008Dto, int>, ITABLE8008Service
{
    public TABLE8008Service(IRepository<TABLE8008> repository)
        : base(repository, TABLE8008MappingExtensions.ToDto, TABLE8008MappingExtensions.ToEntity, TABLE8008MappingExtensions.UpdateEntity) { }
}
