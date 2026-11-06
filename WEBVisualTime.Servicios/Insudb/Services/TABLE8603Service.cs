using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8603Service : CrudService<TABLE8603, TABLE8603Dto, CreateTABLE8603Dto, UpdateTABLE8603Dto, string>, ITABLE8603Service
{
    public TABLE8603Service(IRepository<TABLE8603> repository)
        : base(repository, TABLE8603MappingExtensions.ToDto, TABLE8603MappingExtensions.ToEntity, TABLE8603MappingExtensions.UpdateEntity) { }
}
