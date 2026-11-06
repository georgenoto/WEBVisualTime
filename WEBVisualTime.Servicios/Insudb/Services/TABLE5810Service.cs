using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5810;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5810Service : CrudService<TABLE5810, TABLE5810Dto, CreateTABLE5810Dto, UpdateTABLE5810Dto, int>, ITABLE5810Service
{
    public TABLE5810Service(IRepository<TABLE5810> repository)
        : base(repository, TABLE5810MappingExtensions.ToDto, TABLE5810MappingExtensions.ToEntity, TABLE5810MappingExtensions.UpdateEntity) { }
}
