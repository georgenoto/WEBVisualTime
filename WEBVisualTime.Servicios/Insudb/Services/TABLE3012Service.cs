using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3012;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE3012Service : CrudService<TABLE3012, TABLE3012Dto, CreateTABLE3012Dto, UpdateTABLE3012Dto, int>, ITABLE3012Service
{
    public TABLE3012Service(IRepository<TABLE3012> repository)
        : base(repository, TABLE3012MappingExtensions.ToDto, TABLE3012MappingExtensions.ToEntity, TABLE3012MappingExtensions.UpdateEntity) { }
}
