using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7037;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7037Service : CrudService<TABLE7037, TABLE7037Dto, CreateTABLE7037Dto, UpdateTABLE7037Dto, int>, ITABLE7037Service
{
    public TABLE7037Service(IRepository<TABLE7037> repository)
        : base(repository, TABLE7037MappingExtensions.ToDto, TABLE7037MappingExtensions.ToEntity, TABLE7037MappingExtensions.UpdateEntity) { }
}
