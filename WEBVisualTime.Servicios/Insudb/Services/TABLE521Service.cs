using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE521;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE521Service : CrudService<TABLE521, TABLE521Dto, CreateTABLE521Dto, UpdateTABLE521Dto, int>, ITABLE521Service
{
    public TABLE521Service(IRepository<TABLE521> repository)
        : base(repository, TABLE521MappingExtensions.ToDto, TABLE521MappingExtensions.ToEntity, TABLE521MappingExtensions.UpdateEntity) { }
}
