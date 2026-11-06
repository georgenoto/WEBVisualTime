using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE296;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE296Service : CrudService<TABLE296, TABLE296Dto, CreateTABLE296Dto, UpdateTABLE296Dto, int>, ITABLE296Service
{
    public TABLE296Service(IRepository<TABLE296> repository)
        : base(repository, TABLE296MappingExtensions.ToDto, TABLE296MappingExtensions.ToEntity, TABLE296MappingExtensions.UpdateEntity) { }
}
