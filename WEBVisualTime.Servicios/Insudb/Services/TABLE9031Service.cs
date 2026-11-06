using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9031;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9031Service : CrudService<TABLE9031, TABLE9031Dto, CreateTABLE9031Dto, UpdateTABLE9031Dto, int>, ITABLE9031Service
{
    public TABLE9031Service(IRepository<TABLE9031> repository)
        : base(repository, TABLE9031MappingExtensions.ToDto, TABLE9031MappingExtensions.ToEntity, TABLE9031MappingExtensions.UpdateEntity) { }
}
