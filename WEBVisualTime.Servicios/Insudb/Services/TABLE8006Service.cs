using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8006Service : CrudService<TABLE8006, TABLE8006Dto, CreateTABLE8006Dto, UpdateTABLE8006Dto, int>, ITABLE8006Service
{
    public TABLE8006Service(IRepository<TABLE8006> repository)
        : base(repository, TABLE8006MappingExtensions.ToDto, TABLE8006MappingExtensions.ToEntity, TABLE8006MappingExtensions.UpdateEntity) { }
}
