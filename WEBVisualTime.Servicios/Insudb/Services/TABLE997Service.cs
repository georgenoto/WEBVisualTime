using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE997;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE997Service : CrudService<TABLE997, TABLE997Dto, CreateTABLE997Dto, UpdateTABLE997Dto, int>, ITABLE997Service
{
    public TABLE997Service(IRepository<TABLE997> repository)
        : base(repository, TABLE997MappingExtensions.ToDto, TABLE997MappingExtensions.ToEntity, TABLE997MappingExtensions.UpdateEntity) { }
}
