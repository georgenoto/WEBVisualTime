using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE132Service : CrudService<TABLE132, TABLE132Dto, CreateTABLE132Dto, UpdateTABLE132Dto, string>, ITABLE132Service
{
    public TABLE132Service(IRepository<TABLE132> repository)
        : base(repository, TABLE132MappingExtensions.ToDto, TABLE132MappingExtensions.ToEntity, TABLE132MappingExtensions.UpdateEntity) { }
}
