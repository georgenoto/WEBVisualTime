using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE900;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE900Service : CrudService<TABLE900, TABLE900Dto, CreateTABLE900Dto, UpdateTABLE900Dto, long>, ITABLE900Service
{
    public TABLE900Service(IRepository<TABLE900> repository)
        : base(repository, TABLE900MappingExtensions.ToDto, TABLE900MappingExtensions.ToEntity, TABLE900MappingExtensions.UpdateEntity) { }
}
