using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5586;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5586Service : CrudService<TABLE5586, TABLE5586Dto, CreateTABLE5586Dto, UpdateTABLE5586Dto, int>, ITABLE5586Service
{
    public TABLE5586Service(IRepository<TABLE5586> repository)
        : base(repository, TABLE5586MappingExtensions.ToDto, TABLE5586MappingExtensions.ToEntity, TABLE5586MappingExtensions.UpdateEntity) { }
}
