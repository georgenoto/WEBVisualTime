using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TIMEGLOBALSService : CrudService<TIMEGLOBALS, TIMEGLOBALSDto, CreateTIMEGLOBALSDto, UpdateTIMEGLOBALSDto, string>, ITIMEGLOBALSService
{
    public TIMEGLOBALSService(IRepository<TIMEGLOBALS> repository)
        : base(repository, TIMEGLOBALSMappingExtensions.ToDto, TIMEGLOBALSMappingExtensions.ToEntity, TIMEGLOBALSMappingExtensions.UpdateEntity) { }
}
