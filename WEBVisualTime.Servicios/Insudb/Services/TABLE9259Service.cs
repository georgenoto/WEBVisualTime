using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9259;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9259Service : CrudService<TABLE9259, TABLE9259Dto, CreateTABLE9259Dto, UpdateTABLE9259Dto, int>, ITABLE9259Service
{
    public TABLE9259Service(IRepository<TABLE9259> repository)
        : base(repository, TABLE9259MappingExtensions.ToDto, TABLE9259MappingExtensions.ToEntity, TABLE9259MappingExtensions.UpdateEntity) { }
}
