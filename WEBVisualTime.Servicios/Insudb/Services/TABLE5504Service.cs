using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5504Service : CrudService<TABLE5504, TABLE5504Dto, CreateTABLE5504Dto, UpdateTABLE5504Dto, int>, ITABLE5504Service
{
    public TABLE5504Service(IRepository<TABLE5504> repository)
        : base(repository, TABLE5504MappingExtensions.ToDto, TABLE5504MappingExtensions.ToEntity, TABLE5504MappingExtensions.UpdateEntity) { }
}
