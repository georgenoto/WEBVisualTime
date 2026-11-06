using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE636;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE636Service : CrudService<TABLE636, TABLE636Dto, CreateTABLE636Dto, UpdateTABLE636Dto, long>, ITABLE636Service
{
    public TABLE636Service(IRepository<TABLE636> repository)
        : base(repository, TABLE636MappingExtensions.ToDto, TABLE636MappingExtensions.ToEntity, TABLE636MappingExtensions.UpdateEntity) { }
}
