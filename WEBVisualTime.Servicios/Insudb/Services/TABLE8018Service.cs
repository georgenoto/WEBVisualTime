using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8018;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8018Service : CrudService<TABLE8018, TABLE8018Dto, CreateTABLE8018Dto, UpdateTABLE8018Dto, int>, ITABLE8018Service
{
    public TABLE8018Service(IRepository<TABLE8018> repository)
        : base(repository, TABLE8018MappingExtensions.ToDto, TABLE8018MappingExtensions.ToEntity, TABLE8018MappingExtensions.UpdateEntity) { }
}
