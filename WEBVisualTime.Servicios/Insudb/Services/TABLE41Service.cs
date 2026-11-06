using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE41;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE41Service : CrudService<TABLE41, TABLE41Dto, CreateTABLE41Dto, UpdateTABLE41Dto, long>, ITABLE41Service
{
    public TABLE41Service(IRepository<TABLE41> repository)
        : base(repository, TABLE41MappingExtensions.ToDto, TABLE41MappingExtensions.ToEntity, TABLE41MappingExtensions.UpdateEntity) { }
}
