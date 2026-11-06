using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE258;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE258Service : CrudService<TABLE258, TABLE258Dto, CreateTABLE258Dto, UpdateTABLE258Dto, long>, ITABLE258Service
{
    public TABLE258Service(IRepository<TABLE258> repository)
        : base(repository, TABLE258MappingExtensions.ToDto, TABLE258MappingExtensions.ToEntity, TABLE258MappingExtensions.UpdateEntity) { }
}
