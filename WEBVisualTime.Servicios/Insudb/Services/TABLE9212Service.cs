using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9212Service : CrudService<TABLE9212, TABLE9212Dto, CreateTABLE9212Dto, UpdateTABLE9212Dto, int>, ITABLE9212Service
{
    public TABLE9212Service(IRepository<TABLE9212> repository)
        : base(repository, TABLE9212MappingExtensions.ToDto, TABLE9212MappingExtensions.ToEntity, TABLE9212MappingExtensions.UpdateEntity) { }
}
