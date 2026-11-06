using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5543;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5543Service : CrudService<TABLE5543, TABLE5543Dto, CreateTABLE5543Dto, UpdateTABLE5543Dto, int>, ITABLE5543Service
{
    public TABLE5543Service(IRepository<TABLE5543> repository)
        : base(repository, TABLE5543MappingExtensions.ToDto, TABLE5543MappingExtensions.ToEntity, TABLE5543MappingExtensions.UpdateEntity) { }
}
