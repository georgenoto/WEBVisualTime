using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5594;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5594Service : CrudService<TABLE5594, TABLE5594Dto, CreateTABLE5594Dto, UpdateTABLE5594Dto, int>, ITABLE5594Service
{
    public TABLE5594Service(IRepository<TABLE5594> repository)
        : base(repository, TABLE5594MappingExtensions.ToDto, TABLE5594MappingExtensions.ToEntity, TABLE5594MappingExtensions.UpdateEntity) { }
}
