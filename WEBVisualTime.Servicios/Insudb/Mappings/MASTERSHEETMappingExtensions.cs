using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERSHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERSHEETMappingExtensions
{
    public static MASTERSHEETDto ToDto(this MASTERSHEET entity)
    {
        if (entity == null) return null!;
        return new MASTERSHEETDto
        {
            NSHEET = entity.NSHEET,
            MASTERSHEETParentSPROCESS = entity.MASTERSHEETParent?.SPROCESS,
            NINTERTYPE = entity.NINTERTYPE,
            SPROCESS = entity.SPROCESS,
            NFORMAT = entity.NFORMAT,
            DCOMPDATE = entity.DCOMPDATE,
            NSYSTEM = entity.NSYSTEM,
            SSELECT = entity.SSELECT,
            NPERIOD = entity.NPERIOD,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
            NUSEROPER = entity.NUSEROPER,
            SAUTOMATIC = entity.SAUTOMATIC,
            SSHORTDESC = entity.SSHORTDESC,
            SGROUPBY = entity.SGROUPBY,
            SSTATUSSHEET = entity.SSTATUSSHEET,
            NOPERTYPE = entity.NOPERTYPE,
            SONLINE = entity.SONLINE,
            NNOTENUM = entity.NNOTENUM,
            SPROCESS_END = entity.SPROCESS_END,
            SPREFIX_FNAME = entity.SPREFIX_FNAME,
            SHEADER = entity.SHEADER,
            STOTAL = entity.STOTAL,
            NPOSITION = entity.NPOSITION,
            SMASSIVE = entity.SMASSIVE,
            SSPACE = entity.SSPACE,
            NTYPE_ALIGN = entity.NTYPE_ALIGN,
            SPATH = entity.SPATH,
            SSEPARATOR = entity.SSEPARATOR,
            SROUTINE = entity.SROUTINE,
            SNOGRID = entity.SNOGRID,
            SVIEW_INTERFACE = entity.SVIEW_INTERFACE,
            SVIEW_REPORT = entity.SVIEW_REPORT,
            SREPORT = entity.SREPORT,
            SSHEET_FATHER = entity.SSHEET_FATHER,
            SFILE_UNIQUE = entity.SFILE_UNIQUE,
            SQUERY = entity.SQUERY,
            SXSL = entity.SXSL,
            SQUERY_XSL = entity.SQUERY_XSL,
            SNAME_ROUTINE = entity.SNAME_ROUTINE,
            SOUT_ROUTINE = entity.SOUT_ROUTINE,
            SWORKFLOWNAME = entity.SWORKFLOWNAME,
            SFOLDER = entity.SFOLDER,
            SQUEPROCESS = entity.SQUEPROCESS,
            SQUEQUERY = entity.SQUEQUERY,
            ST_INTERFACE = entity.ST_INTERFACE,
            NAVERAGERECORDS = entity.NAVERAGERECORDS,
            NTOTALCOLUMNS = entity.NTOTALCOLUMNS,
            SDATEFORMAT = entity.SDATEFORMAT,
            SDECIMAL = entity.SDECIMAL,
        };
    }

    public static MASTERSHEET ToEntity(this CreateMASTERSHEETDto dto)
    {
        if (dto == null) return null!;
        return new MASTERSHEET
        {
            NINTERTYPE = dto.NINTERTYPE,
            SPROCESS = dto.SPROCESS,
            NFORMAT = dto.NFORMAT,
            DCOMPDATE = dto.DCOMPDATE,
            NSYSTEM = dto.NSYSTEM,
            SSELECT = dto.SSELECT,
            NPERIOD = dto.NPERIOD,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
            NUSEROPER = dto.NUSEROPER,
            SAUTOMATIC = dto.SAUTOMATIC,
            SSHORTDESC = dto.SSHORTDESC,
            SGROUPBY = dto.SGROUPBY,
            SSTATUSSHEET = dto.SSTATUSSHEET,
            NOPERTYPE = dto.NOPERTYPE,
            SONLINE = dto.SONLINE,
            NNOTENUM = dto.NNOTENUM,
            SPROCESS_END = dto.SPROCESS_END,
            SPREFIX_FNAME = dto.SPREFIX_FNAME,
            SHEADER = dto.SHEADER,
            STOTAL = dto.STOTAL,
            NPOSITION = dto.NPOSITION,
            SMASSIVE = dto.SMASSIVE,
            SSPACE = dto.SSPACE,
            NTYPE_ALIGN = dto.NTYPE_ALIGN,
            SPATH = dto.SPATH,
            SSEPARATOR = dto.SSEPARATOR,
            SROUTINE = dto.SROUTINE,
            SNOGRID = dto.SNOGRID,
            SVIEW_INTERFACE = dto.SVIEW_INTERFACE,
            SVIEW_REPORT = dto.SVIEW_REPORT,
            SREPORT = dto.SREPORT,
            SSHEET_FATHER = dto.SSHEET_FATHER,
            SFILE_UNIQUE = dto.SFILE_UNIQUE,
            SQUERY = dto.SQUERY,
            SXSL = dto.SXSL,
            SQUERY_XSL = dto.SQUERY_XSL,
            SNAME_ROUTINE = dto.SNAME_ROUTINE,
            SOUT_ROUTINE = dto.SOUT_ROUTINE,
            SWORKFLOWNAME = dto.SWORKFLOWNAME,
            SFOLDER = dto.SFOLDER,
            SQUEPROCESS = dto.SQUEPROCESS,
            SQUEQUERY = dto.SQUEQUERY,
            ST_INTERFACE = dto.ST_INTERFACE,
            NAVERAGERECORDS = dto.NAVERAGERECORDS,
            NTOTALCOLUMNS = dto.NTOTALCOLUMNS,
            SDATEFORMAT = dto.SDATEFORMAT,
            SDECIMAL = dto.SDECIMAL,
        };
    }

    public static void UpdateEntity(this MASTERSHEET entity, UpdateMASTERSHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINTERTYPE = dto.NINTERTYPE;
        entity.SPROCESS = dto.SPROCESS;
        entity.NFORMAT = dto.NFORMAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NSYSTEM = dto.NSYSTEM;
        entity.SSELECT = dto.SSELECT;
        entity.NPERIOD = dto.NPERIOD;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSEROPER = dto.NUSEROPER;
        entity.SAUTOMATIC = dto.SAUTOMATIC;
        entity.SSHORTDESC = dto.SSHORTDESC;
        entity.SGROUPBY = dto.SGROUPBY;
        entity.SSTATUSSHEET = dto.SSTATUSSHEET;
        entity.NOPERTYPE = dto.NOPERTYPE;
        entity.SONLINE = dto.SONLINE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.SPROCESS_END = dto.SPROCESS_END;
        entity.SPREFIX_FNAME = dto.SPREFIX_FNAME;
        entity.SHEADER = dto.SHEADER;
        entity.STOTAL = dto.STOTAL;
        entity.NPOSITION = dto.NPOSITION;
        entity.SMASSIVE = dto.SMASSIVE;
        entity.SSPACE = dto.SSPACE;
        entity.NTYPE_ALIGN = dto.NTYPE_ALIGN;
        entity.SPATH = dto.SPATH;
        entity.SSEPARATOR = dto.SSEPARATOR;
        entity.SROUTINE = dto.SROUTINE;
        entity.SNOGRID = dto.SNOGRID;
        entity.SVIEW_INTERFACE = dto.SVIEW_INTERFACE;
        entity.SVIEW_REPORT = dto.SVIEW_REPORT;
        entity.SREPORT = dto.SREPORT;
        entity.SSHEET_FATHER = dto.SSHEET_FATHER;
        entity.SFILE_UNIQUE = dto.SFILE_UNIQUE;
        entity.SQUERY = dto.SQUERY;
        entity.SXSL = dto.SXSL;
        entity.SQUERY_XSL = dto.SQUERY_XSL;
        entity.SNAME_ROUTINE = dto.SNAME_ROUTINE;
        entity.SOUT_ROUTINE = dto.SOUT_ROUTINE;
        entity.SWORKFLOWNAME = dto.SWORKFLOWNAME;
        entity.SFOLDER = dto.SFOLDER;
        entity.SQUEPROCESS = dto.SQUEPROCESS;
        entity.SQUEQUERY = dto.SQUEQUERY;
        entity.ST_INTERFACE = dto.ST_INTERFACE;
        entity.NAVERAGERECORDS = dto.NAVERAGERECORDS;
        entity.NTOTALCOLUMNS = dto.NTOTALCOLUMNS;
        entity.SDATEFORMAT = dto.SDATEFORMAT;
        entity.SDECIMAL = dto.SDECIMAL;
    }
}
