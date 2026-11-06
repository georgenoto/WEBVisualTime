using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE289;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE289Service : CrudService<TABLE289, TABLE289Dto, CreateTABLE289Dto, UpdateTABLE289Dto, long>, ITABLE289Service
{
    public TABLE289Service(IRepository<TABLE289> repository)
        : base(repository, TABLE289MappingExtensions.ToDto, TABLE289MappingExtensions.ToEntity, TABLE289MappingExtensions.UpdateEntity) { }
}
