using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7042;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7042Service : CrudService<TABLE7042, TABLE7042Dto, CreateTABLE7042Dto, UpdateTABLE7042Dto, int>, ITABLE7042Service
{
    public TABLE7042Service(IRepository<TABLE7042> repository)
        : base(repository, TABLE7042MappingExtensions.ToDto, TABLE7042MappingExtensions.ToEntity, TABLE7042MappingExtensions.UpdateEntity) { }
}
