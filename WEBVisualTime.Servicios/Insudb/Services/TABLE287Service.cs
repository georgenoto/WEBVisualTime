using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE287;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE287Service : CrudService<TABLE287, TABLE287Dto, CreateTABLE287Dto, UpdateTABLE287Dto, long>, ITABLE287Service
{
    public TABLE287Service(IRepository<TABLE287> repository)
        : base(repository, TABLE287MappingExtensions.ToDto, TABLE287MappingExtensions.ToEntity, TABLE287MappingExtensions.UpdateEntity) { }
}
