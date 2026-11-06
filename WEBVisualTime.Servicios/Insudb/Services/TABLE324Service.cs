using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE324;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE324Service : CrudService<TABLE324, TABLE324Dto, CreateTABLE324Dto, UpdateTABLE324Dto, int>, ITABLE324Service
{
    public TABLE324Service(IRepository<TABLE324> repository)
        : base(repository, TABLE324MappingExtensions.ToDto, TABLE324MappingExtensions.ToEntity, TABLE324MappingExtensions.UpdateEntity) { }
}
