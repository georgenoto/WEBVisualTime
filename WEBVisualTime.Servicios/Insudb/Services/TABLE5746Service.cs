using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5746;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5746Service : CrudService<TABLE5746, TABLE5746Dto, CreateTABLE5746Dto, UpdateTABLE5746Dto, int>, ITABLE5746Service
{
    public TABLE5746Service(IRepository<TABLE5746> repository)
        : base(repository, TABLE5746MappingExtensions.ToDto, TABLE5746MappingExtensions.ToEntity, TABLE5746MappingExtensions.UpdateEntity) { }
}
