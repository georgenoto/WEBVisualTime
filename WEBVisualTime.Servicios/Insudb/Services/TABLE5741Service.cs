using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5741;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5741Service : CrudService<TABLE5741, TABLE5741Dto, CreateTABLE5741Dto, UpdateTABLE5741Dto, int>, ITABLE5741Service
{
    public TABLE5741Service(IRepository<TABLE5741> repository)
        : base(repository, TABLE5741MappingExtensions.ToDto, TABLE5741MappingExtensions.ToEntity, TABLE5741MappingExtensions.UpdateEntity) { }
}
