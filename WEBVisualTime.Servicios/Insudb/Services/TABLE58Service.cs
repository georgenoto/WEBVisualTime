using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE58;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE58Service : CrudService<TABLE58, TABLE58Dto, CreateTABLE58Dto, UpdateTABLE58Dto, int>, ITABLE58Service
{
    public TABLE58Service(IRepository<TABLE58> repository)
        : base(repository, TABLE58MappingExtensions.ToDto, TABLE58MappingExtensions.ToEntity, TABLE58MappingExtensions.UpdateEntity) { }
}
