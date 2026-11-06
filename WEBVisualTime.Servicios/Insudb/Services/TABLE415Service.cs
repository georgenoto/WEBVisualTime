using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE415;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE415Service : CrudService<TABLE415, TABLE415Dto, CreateTABLE415Dto, UpdateTABLE415Dto, int>, ITABLE415Service
{
    public TABLE415Service(IRepository<TABLE415> repository)
        : base(repository, TABLE415MappingExtensions.ToDto, TABLE415MappingExtensions.ToEntity, TABLE415MappingExtensions.UpdateEntity) { }
}
