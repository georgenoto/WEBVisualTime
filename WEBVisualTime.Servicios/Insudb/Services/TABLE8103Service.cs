using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8103;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8103Service : CrudService<TABLE8103, TABLE8103Dto, CreateTABLE8103Dto, UpdateTABLE8103Dto, int>, ITABLE8103Service
{
    public TABLE8103Service(IRepository<TABLE8103> repository)
        : base(repository, TABLE8103MappingExtensions.ToDto, TABLE8103MappingExtensions.ToEntity, TABLE8103MappingExtensions.UpdateEntity) { }
}
