using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class BENEFITS_CATEGORYService : CrudService<BENEFITS_CATEGORY, BENEFITS_CATEGORYDto, CreateBENEFITS_CATEGORYDto, UpdateBENEFITS_CATEGORYDto, int>, IBENEFITS_CATEGORYService
{
    public BENEFITS_CATEGORYService(IRepository<BENEFITS_CATEGORY> repository)
        : base(repository, BENEFITS_CATEGORYMappingExtensions.ToDto, BENEFITS_CATEGORYMappingExtensions.ToEntity, BENEFITS_CATEGORYMappingExtensions.UpdateEntity) { }
}
