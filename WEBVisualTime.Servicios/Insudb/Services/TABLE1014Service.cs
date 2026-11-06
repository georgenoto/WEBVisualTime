using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1014;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1014Service : CrudService<TABLE1014, TABLE1014Dto, CreateTABLE1014Dto, UpdateTABLE1014Dto, int>, ITABLE1014Service
{
    public TABLE1014Service(IRepository<TABLE1014> repository)
        : base(repository, TABLE1014MappingExtensions.ToDto, TABLE1014MappingExtensions.ToEntity, TABLE1014MappingExtensions.UpdateEntity) { }
}
