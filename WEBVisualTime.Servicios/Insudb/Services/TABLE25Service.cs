using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE25Service : CrudService<TABLE25, TABLE25Dto, CreateTABLE25Dto, UpdateTABLE25Dto, string>, ITABLE25Service
{
    public TABLE25Service(IRepository<TABLE25> repository)
        : base(repository, TABLE25MappingExtensions.ToDto, TABLE25MappingExtensions.ToEntity, TABLE25MappingExtensions.UpdateEntity) { }
}
