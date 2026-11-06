using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8600Service : CrudService<TABLE8600, TABLE8600Dto, CreateTABLE8600Dto, UpdateTABLE8600Dto, string>, ITABLE8600Service
{
    public TABLE8600Service(IRepository<TABLE8600> repository)
        : base(repository, TABLE8600MappingExtensions.ToDto, TABLE8600MappingExtensions.ToEntity, TABLE8600MappingExtensions.UpdateEntity) { }
}
