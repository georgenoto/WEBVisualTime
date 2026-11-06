using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7212;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7212Service : CrudService<TABLE7212, TABLE7212Dto, CreateTABLE7212Dto, UpdateTABLE7212Dto, int>, ITABLE7212Service
{
    public TABLE7212Service(IRepository<TABLE7212> repository)
        : base(repository, TABLE7212MappingExtensions.ToDto, TABLE7212MappingExtensions.ToEntity, TABLE7212MappingExtensions.UpdateEntity) { }
}
