using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE295;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE295Service : CrudService<TABLE295, TABLE295Dto, CreateTABLE295Dto, UpdateTABLE295Dto, int>, ITABLE295Service
{
    public TABLE295Service(IRepository<TABLE295> repository)
        : base(repository, TABLE295MappingExtensions.ToDto, TABLE295MappingExtensions.ToEntity, TABLE295MappingExtensions.UpdateEntity) { }
}
