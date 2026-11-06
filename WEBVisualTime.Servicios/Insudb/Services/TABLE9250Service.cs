using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9250Service : CrudService<TABLE9250, TABLE9250Dto, CreateTABLE9250Dto, UpdateTABLE9250Dto, int>, ITABLE9250Service
{
    public TABLE9250Service(IRepository<TABLE9250> repository)
        : base(repository, TABLE9250MappingExtensions.ToDto, TABLE9250MappingExtensions.ToEntity, TABLE9250MappingExtensions.UpdateEntity) { }
}
