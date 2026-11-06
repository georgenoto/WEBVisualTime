using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE181Service : CrudService<TABLE181, TABLE181Dto, CreateTABLE181Dto, UpdateTABLE181Dto, string>, ITABLE181Service
{
    public TABLE181Service(IRepository<TABLE181> repository)
        : base(repository, TABLE181MappingExtensions.ToDto, TABLE181MappingExtensions.ToEntity, TABLE181MappingExtensions.UpdateEntity) { }
}
