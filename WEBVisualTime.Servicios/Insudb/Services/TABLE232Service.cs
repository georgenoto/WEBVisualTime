using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE232;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE232Service : CrudService<TABLE232, TABLE232Dto, CreateTABLE232Dto, UpdateTABLE232Dto, int>, ITABLE232Service
{
    public TABLE232Service(IRepository<TABLE232> repository)
        : base(repository, TABLE232MappingExtensions.ToDto, TABLE232MappingExtensions.ToEntity, TABLE232MappingExtensions.UpdateEntity) { }
}
