using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE197;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE197Service : CrudService<TABLE197, TABLE197Dto, CreateTABLE197Dto, UpdateTABLE197Dto, int>, ITABLE197Service
{
    public TABLE197Service(IRepository<TABLE197> repository)
        : base(repository, TABLE197MappingExtensions.ToDto, TABLE197MappingExtensions.ToEntity, TABLE197MappingExtensions.UpdateEntity) { }
}
