using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE75Service : CrudService<TABLE75, TABLE75Dto, CreateTABLE75Dto, UpdateTABLE75Dto, int>, ITABLE75Service
{
    public TABLE75Service(IRepository<TABLE75> repository)
        : base(repository, TABLE75MappingExtensions.ToDto, TABLE75MappingExtensions.ToEntity, TABLE75MappingExtensions.UpdateEntity) { }
}
