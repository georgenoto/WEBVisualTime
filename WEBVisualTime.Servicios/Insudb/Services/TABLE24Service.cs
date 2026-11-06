using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE24Service : CrudService<TABLE24, TABLE24Dto, CreateTABLE24Dto, UpdateTABLE24Dto, int>, ITABLE24Service
{
    public TABLE24Service(IRepository<TABLE24> repository)
        : base(repository, TABLE24MappingExtensions.ToDto, TABLE24MappingExtensions.ToEntity, TABLE24MappingExtensions.UpdateEntity) { }
}
