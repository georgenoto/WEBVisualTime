using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5562;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5562Service : CrudService<TABLE5562, TABLE5562Dto, CreateTABLE5562Dto, UpdateTABLE5562Dto, int>, ITABLE5562Service
{
    public TABLE5562Service(IRepository<TABLE5562> repository)
        : base(repository, TABLE5562MappingExtensions.ToDto, TABLE5562MappingExtensions.ToEntity, TABLE5562MappingExtensions.UpdateEntity) { }
}
