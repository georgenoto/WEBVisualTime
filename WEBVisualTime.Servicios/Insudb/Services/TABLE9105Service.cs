using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9105Service : CrudService<TABLE9105, TABLE9105Dto, CreateTABLE9105Dto, UpdateTABLE9105Dto, int>, ITABLE9105Service
{
    public TABLE9105Service(IRepository<TABLE9105> repository)
        : base(repository, TABLE9105MappingExtensions.ToDto, TABLE9105MappingExtensions.ToEntity, TABLE9105MappingExtensions.UpdateEntity) { }
}
