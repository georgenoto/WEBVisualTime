using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE511;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE511Service : CrudService<TABLE511, TABLE511Dto, CreateTABLE511Dto, UpdateTABLE511Dto, string>, ITABLE511Service
{
    public TABLE511Service(IRepository<TABLE511> repository)
        : base(repository, TABLE511MappingExtensions.ToDto, TABLE511MappingExtensions.ToEntity, TABLE511MappingExtensions.UpdateEntity) { }
}
