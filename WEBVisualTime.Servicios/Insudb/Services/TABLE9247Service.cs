using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9247;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9247Service : CrudService<TABLE9247, TABLE9247Dto, CreateTABLE9247Dto, UpdateTABLE9247Dto, int>, ITABLE9247Service
{
    public TABLE9247Service(IRepository<TABLE9247> repository)
        : base(repository, TABLE9247MappingExtensions.ToDto, TABLE9247MappingExtensions.ToEntity, TABLE9247MappingExtensions.UpdateEntity) { }
}
