using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8505;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8505Service : CrudService<TABLE8505, TABLE8505Dto, CreateTABLE8505Dto, UpdateTABLE8505Dto, int>, ITABLE8505Service
{
    public TABLE8505Service(IRepository<TABLE8505> repository)
        : base(repository, TABLE8505MappingExtensions.ToDto, TABLE8505MappingExtensions.ToEntity, TABLE8505MappingExtensions.UpdateEntity) { }
}
