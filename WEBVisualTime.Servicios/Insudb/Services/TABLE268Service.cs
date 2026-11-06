using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE268;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE268Service : CrudService<TABLE268, TABLE268Dto, CreateTABLE268Dto, UpdateTABLE268Dto, int>, ITABLE268Service
{
    public TABLE268Service(IRepository<TABLE268> repository)
        : base(repository, TABLE268MappingExtensions.ToDto, TABLE268MappingExtensions.ToEntity, TABLE268MappingExtensions.UpdateEntity) { }
}
