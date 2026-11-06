using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5552;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5552Service : CrudService<TABLE5552, TABLE5552Dto, CreateTABLE5552Dto, UpdateTABLE5552Dto, int>, ITABLE5552Service
{
    public TABLE5552Service(IRepository<TABLE5552> repository)
        : base(repository, TABLE5552MappingExtensions.ToDto, TABLE5552MappingExtensions.ToEntity, TABLE5552MappingExtensions.UpdateEntity) { }
}
