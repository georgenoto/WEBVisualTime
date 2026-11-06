using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5577;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5577Service : CrudService<TABLE5577, TABLE5577Dto, CreateTABLE5577Dto, UpdateTABLE5577Dto, int>, ITABLE5577Service
{
    public TABLE5577Service(IRepository<TABLE5577> repository)
        : base(repository, TABLE5577MappingExtensions.ToDto, TABLE5577MappingExtensions.ToEntity, TABLE5577MappingExtensions.UpdateEntity) { }
}
