using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE239;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE239Service : CrudService<TABLE239, TABLE239Dto, CreateTABLE239Dto, UpdateTABLE239Dto, int>, ITABLE239Service
{
    public TABLE239Service(IRepository<TABLE239> repository)
        : base(repository, TABLE239MappingExtensions.ToDto, TABLE239MappingExtensions.ToEntity, TABLE239MappingExtensions.UpdateEntity) { }
}
