using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class NOTIFICA_ERPService : CrudService<NOTIFICA_ERP, NOTIFICA_ERPDto, CreateNOTIFICA_ERPDto, UpdateNOTIFICA_ERPDto, string>, INOTIFICA_ERPService
{
    public NOTIFICA_ERPService(IRepository<NOTIFICA_ERP> repository)
        : base(repository, NOTIFICA_ERPMappingExtensions.ToDto, NOTIFICA_ERPMappingExtensions.ToEntity, NOTIFICA_ERPMappingExtensions.UpdateEntity) { }
}
