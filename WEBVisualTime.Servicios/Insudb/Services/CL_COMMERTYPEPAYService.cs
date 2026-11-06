using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CL_COMMERTYPEPAYService : CrudService<CL_COMMERTYPEPAY, CL_COMMERTYPEPAYDto, CreateCL_COMMERTYPEPAYDto, UpdateCL_COMMERTYPEPAYDto, int>, ICL_COMMERTYPEPAYService
{
    public CL_COMMERTYPEPAYService(IRepository<CL_COMMERTYPEPAY> repository)
        : base(repository, CL_COMMERTYPEPAYMappingExtensions.ToDto, CL_COMMERTYPEPAYMappingExtensions.ToEntity, CL_COMMERTYPEPAYMappingExtensions.UpdateEntity) { }
}
