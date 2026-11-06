using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5750;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5750Service : CrudService<TABLE5750, TABLE5750Dto, CreateTABLE5750Dto, UpdateTABLE5750Dto, string>, ITABLE5750Service
{
    public TABLE5750Service(IRepository<TABLE5750> repository)
        : base(repository, TABLE5750MappingExtensions.ToDto, TABLE5750MappingExtensions.ToEntity, TABLE5750MappingExtensions.UpdateEntity) { }
}
