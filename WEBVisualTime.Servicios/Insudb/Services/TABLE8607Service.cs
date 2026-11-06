using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8607;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8607Service : CrudService<TABLE8607, TABLE8607Dto, CreateTABLE8607Dto, UpdateTABLE8607Dto, int>, ITABLE8607Service
{
    public TABLE8607Service(IRepository<TABLE8607> repository)
        : base(repository, TABLE8607MappingExtensions.ToDto, TABLE8607MappingExtensions.ToEntity, TABLE8607MappingExtensions.UpdateEntity) { }
}
