using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE532;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE532Service : CrudService<TABLE532, TABLE532Dto, CreateTABLE532Dto, UpdateTABLE532Dto, int>, ITABLE532Service
{
    public TABLE532Service(IRepository<TABLE532> repository)
        : base(repository, TABLE532MappingExtensions.ToDto, TABLE532MappingExtensions.ToEntity, TABLE532MappingExtensions.UpdateEntity) { }
}
