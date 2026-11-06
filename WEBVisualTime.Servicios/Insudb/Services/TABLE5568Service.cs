using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5568;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5568Service : CrudService<TABLE5568, TABLE5568Dto, CreateTABLE5568Dto, UpdateTABLE5568Dto, int>, ITABLE5568Service
{
    public TABLE5568Service(IRepository<TABLE5568> repository)
        : base(repository, TABLE5568MappingExtensions.ToDto, TABLE5568MappingExtensions.ToEntity, TABLE5568MappingExtensions.UpdateEntity) { }
}
