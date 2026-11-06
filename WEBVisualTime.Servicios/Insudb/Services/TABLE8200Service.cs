using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8200Service : CrudService<TABLE8200, TABLE8200Dto, CreateTABLE8200Dto, UpdateTABLE8200Dto, int>, ITABLE8200Service
{
    public TABLE8200Service(IRepository<TABLE8200> repository)
        : base(repository, TABLE8200MappingExtensions.ToDto, TABLE8200MappingExtensions.ToEntity, TABLE8200MappingExtensions.UpdateEntity) { }
}
