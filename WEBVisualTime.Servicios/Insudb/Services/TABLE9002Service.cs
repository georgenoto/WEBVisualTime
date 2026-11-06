using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9002;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9002Service : CrudService<TABLE9002, TABLE9002Dto, CreateTABLE9002Dto, UpdateTABLE9002Dto, int>, ITABLE9002Service
{
    public TABLE9002Service(IRepository<TABLE9002> repository)
        : base(repository, TABLE9002MappingExtensions.ToDto, TABLE9002MappingExtensions.ToEntity, TABLE9002MappingExtensions.UpdateEntity) { }
}
