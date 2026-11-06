using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE45;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE45Service : CrudService<TABLE45, TABLE45Dto, CreateTABLE45Dto, UpdateTABLE45Dto, string>, ITABLE45Service
{
    public TABLE45Service(IRepository<TABLE45> repository)
        : base(repository, TABLE45MappingExtensions.ToDto, TABLE45MappingExtensions.ToEntity, TABLE45MappingExtensions.UpdateEntity) { }
}
