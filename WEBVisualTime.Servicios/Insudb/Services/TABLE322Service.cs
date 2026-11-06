using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE322;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE322Service : CrudService<TABLE322, TABLE322Dto, CreateTABLE322Dto, UpdateTABLE322Dto, int>, ITABLE322Service
{
    public TABLE322Service(IRepository<TABLE322> repository)
        : base(repository, TABLE322MappingExtensions.ToDto, TABLE322MappingExtensions.ToEntity, TABLE322MappingExtensions.UpdateEntity) { }
}
