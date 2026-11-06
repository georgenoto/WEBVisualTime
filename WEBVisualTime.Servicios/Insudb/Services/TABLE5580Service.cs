using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5580Service : CrudService<TABLE5580, TABLE5580Dto, CreateTABLE5580Dto, UpdateTABLE5580Dto, int>, ITABLE5580Service
{
    public TABLE5580Service(IRepository<TABLE5580> repository)
        : base(repository, TABLE5580MappingExtensions.ToDto, TABLE5580MappingExtensions.ToEntity, TABLE5580MappingExtensions.UpdateEntity) { }
}
