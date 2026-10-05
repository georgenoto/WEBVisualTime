using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_DET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ASCII_I_DETMappingExtensions
{
    public static ASCII_I_DETDto ToDto(this ASCII_I_DET entity)
    {
        if (entity == null) return null!;
        return new ASCII_I_DETDto
        {
            SASCII_NAME = entity.SASCII_NAME,
            ASCII_I_HEADSACC_NUMBER = entity.ASCII_I_HEAD?.SACC_NUMBER,
            NID = entity.NID,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            SCLIENAME = entity.SCLIENAME,
            NREQUEST_NEW = entity.NREQUEST_NEW,
            NAMOUNT = entity.NAMOUNT,
            SDESCRIPT = entity.SDESCRIPT,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NOFF_DEST_ID = entity.NOFF_DEST_ID,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NPAY_ID = entity.NPAY_ID,
            TABLE9229SDESCRIPT = entity.TABLE9229?.SDESCRIPT,
            DDATE_PAY = entity.DDATE_PAY,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static ASCII_I_DET ToEntity(this CreateASCII_I_DETDto dto)
    {
        if (dto == null) return null!;
        return new ASCII_I_DET
        {
            SCLIENT = dto.SCLIENT,
            SCLIENAME = dto.SCLIENAME,
            NREQUEST_NEW = dto.NREQUEST_NEW,
            NAMOUNT = dto.NAMOUNT,
            SDESCRIPT = dto.SDESCRIPT,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            NBANKEXT = dto.NBANKEXT,
            NOFF_DEST_ID = dto.NOFF_DEST_ID,
            DDATE_PAY = dto.DDATE_PAY,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this ASCII_I_DET entity, UpdateASCII_I_DETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.NREQUEST_NEW = dto.NREQUEST_NEW;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.NOFF_DEST_ID = dto.NOFF_DEST_ID;
        entity.DDATE_PAY = dto.DDATE_PAY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
