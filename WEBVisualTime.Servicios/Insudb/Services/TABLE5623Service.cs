using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5623;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5623Service : CrudService<TABLE5623, TABLE5623Dto, CreateTABLE5623Dto, UpdateTABLE5623Dto, long>, ITABLE5623Service
{
    public TABLE5623Service(IRepository<TABLE5623> repository)
        : base(repository, TABLE5623MappingExtensions.ToDto, TABLE5623MappingExtensions.ToEntity, TABLE5623MappingExtensions.UpdateEntity) { }
}
