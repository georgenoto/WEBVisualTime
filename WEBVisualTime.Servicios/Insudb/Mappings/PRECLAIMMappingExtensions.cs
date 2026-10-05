using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PRECLAIMMappingExtensions
{
    public static PRECLAIMDto ToDto(this PRECLAIM entity)
    {
        if (entity == null) return null!;
        return new PRECLAIMDto
        {
            NIDPRECLAIM = entity.NIDPRECLAIM,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            DOCCURDATE = entity.DOCCURDATE,
            DREPDATE = entity.DREPDATE,
            SADDRESS = entity.SADDRESS,
            NDAMAGES = entity.NDAMAGES,
            NCURRENCY = entity.NCURRENCY,
            NIDSTATPRECLAIM = entity.NIDSTATPRECLAIM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NPRECLAIM = entity.NPRECLAIM,
            SNAMECLIENT = entity.SNAMECLIENT,
            NNOTENUM = entity.NNOTENUM,
            SCLIENT_AFFECT = entity.SCLIENT_AFFECT,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NATTENTCHANNEL = entity.NATTENTCHANNEL,
            TABLE9237SDESCRIPT = entity.TABLE9237?.SDESCRIPT,
            SCLINUMDOCU = entity.SCLINUMDOCU,
            NCOUNTRY = entity.NCOUNTRY,
            SLOCALOCCUR = entity.SLOCALOCCUR,
            SACCIDENT = entity.SACCIDENT,
            SPREAUTHORIZATION = entity.SPREAUTHORIZATION,
            NORDERTYPE = entity.NORDERTYPE,
            TABLE9238SDESCRIPT = entity.TABLE9238?.SDESCRIPT,
            DSTATUS = entity.DSTATUS,
            DREJECTION = entity.DREJECTION,
            DREJECTNOTICE = entity.DREJECTNOTICE,
            NREJECTUSER = entity.NREJECTUSER,
            NMASTERORDER = entity.NMASTERORDER,
            MASTERCL_ORDERSNAMECLIENT = entity.MASTERCL_ORDER?.SNAMECLIENT,
            NPROVIDER = entity.NPROVIDER,
            NPHYSICIAN = entity.NPHYSICIAN,
            NMEDICALINSTITUTE = entity.NMEDICALINSTITUTE,
            SCALLCENTER = entity.SCALLCENTER,
            DLEDGERDAT = entity.DLEDGERDAT,
            NCLA_LI_TYP = entity.NCLA_LI_TYP,
            TABLE210SDESCRIPT = entity.TABLE210?.SDESCRIPT,
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            DREOPENCL = entity.DREOPENCL,
            NREOPENUSER = entity.NREOPENUSER,
            DCONFREJECTION = entity.DCONFREJECTION,
            DCONFREJECTNOTICE = entity.DCONFREJECTNOTICE,
            NCONFREJECTUSER = entity.NCONFREJECTUSER,
            DNULLDATE = entity.DNULLDATE,
            NNULLCODE = entity.NNULLCODE,
            SHISTORICAL_CLAIM = entity.SHISTORICAL_CLAIM,
        };
    }

    public static PRECLAIM ToEntity(this CreatePRECLAIMDto dto)
    {
        if (dto == null) return null!;
        return new PRECLAIM
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            DOCCURDATE = dto.DOCCURDATE,
            DREPDATE = dto.DREPDATE,
            SADDRESS = dto.SADDRESS,
            NDAMAGES = dto.NDAMAGES,
            NCURRENCY = dto.NCURRENCY,
            NIDSTATPRECLAIM = dto.NIDSTATPRECLAIM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NPRECLAIM = dto.NPRECLAIM,
            SNAMECLIENT = dto.SNAMECLIENT,
            NNOTENUM = dto.NNOTENUM,
            SCLIENT_AFFECT = dto.SCLIENT_AFFECT,
            NOFFICE = dto.NOFFICE,
            NATTENTCHANNEL = dto.NATTENTCHANNEL,
            SCLINUMDOCU = dto.SCLINUMDOCU,
            NCOUNTRY = dto.NCOUNTRY,
            SLOCALOCCUR = dto.SLOCALOCCUR,
            SACCIDENT = dto.SACCIDENT,
            SPREAUTHORIZATION = dto.SPREAUTHORIZATION,
            NORDERTYPE = dto.NORDERTYPE,
            DSTATUS = dto.DSTATUS,
            DREJECTION = dto.DREJECTION,
            DREJECTNOTICE = dto.DREJECTNOTICE,
            NREJECTUSER = dto.NREJECTUSER,
            NMASTERORDER = dto.NMASTERORDER,
            NPROVIDER = dto.NPROVIDER,
            NPHYSICIAN = dto.NPHYSICIAN,
            NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE,
            SCALLCENTER = dto.SCALLCENTER,
            DLEDGERDAT = dto.DLEDGERDAT,
            NCLA_LI_TYP = dto.NCLA_LI_TYP,
            NCAUSEREOPENCL = dto.NCAUSEREOPENCL,
            NTYPE_COMMPAY = dto.NTYPE_COMMPAY,
            DREOPENCL = dto.DREOPENCL,
            NREOPENUSER = dto.NREOPENUSER,
            DCONFREJECTION = dto.DCONFREJECTION,
            DCONFREJECTNOTICE = dto.DCONFREJECTNOTICE,
            NCONFREJECTUSER = dto.NCONFREJECTUSER,
            DNULLDATE = dto.DNULLDATE,
            NNULLCODE = dto.NNULLCODE,
            SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM,
        };
    }

    public static void UpdateEntity(this PRECLAIM entity, UpdatePRECLAIMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.DOCCURDATE = dto.DOCCURDATE;
        entity.DREPDATE = dto.DREPDATE;
        entity.SADDRESS = dto.SADDRESS;
        entity.NDAMAGES = dto.NDAMAGES;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NIDSTATPRECLAIM = dto.NIDSTATPRECLAIM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPRECLAIM = dto.NPRECLAIM;
        entity.SNAMECLIENT = dto.SNAMECLIENT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SCLIENT_AFFECT = dto.SCLIENT_AFFECT;
        entity.NOFFICE = dto.NOFFICE;
        entity.NATTENTCHANNEL = dto.NATTENTCHANNEL;
        entity.SCLINUMDOCU = dto.SCLINUMDOCU;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.SLOCALOCCUR = dto.SLOCALOCCUR;
        entity.SACCIDENT = dto.SACCIDENT;
        entity.SPREAUTHORIZATION = dto.SPREAUTHORIZATION;
        entity.NORDERTYPE = dto.NORDERTYPE;
        entity.DSTATUS = dto.DSTATUS;
        entity.DREJECTION = dto.DREJECTION;
        entity.DREJECTNOTICE = dto.DREJECTNOTICE;
        entity.NREJECTUSER = dto.NREJECTUSER;
        entity.NMASTERORDER = dto.NMASTERORDER;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NPHYSICIAN = dto.NPHYSICIAN;
        entity.NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE;
        entity.SCALLCENTER = dto.SCALLCENTER;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NCLA_LI_TYP = dto.NCLA_LI_TYP;
        entity.NCAUSEREOPENCL = dto.NCAUSEREOPENCL;
        entity.NTYPE_COMMPAY = dto.NTYPE_COMMPAY;
        entity.DREOPENCL = dto.DREOPENCL;
        entity.NREOPENUSER = dto.NREOPENUSER;
        entity.DCONFREJECTION = dto.DCONFREJECTION;
        entity.DCONFREJECTNOTICE = dto.DCONFREJECTNOTICE;
        entity.NCONFREJECTUSER = dto.NCONFREJECTUSER;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM;
    }
}
