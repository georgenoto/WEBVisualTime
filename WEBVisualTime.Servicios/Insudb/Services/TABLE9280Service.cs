using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9280;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9280Service : CrudService<TABLE9280, TABLE9280Dto, CreateTABLE9280Dto, UpdateTABLE9280Dto, int>, ITABLE9280Service
{
    public TABLE9280Service(IRepository<TABLE9280> repository)
        : base(repository, TABLE9280MappingExtensions.ToDto, TABLE9280MappingExtensions.ToEntity, TABLE9280MappingExtensions.UpdateEntity) { }
}
