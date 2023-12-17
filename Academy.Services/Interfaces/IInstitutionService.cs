using Academy.Services.Contracts.Institutions;

namespace Academy.Services.Interfaces
{
    public interface IInstitutionService
    {
        InstitutionRsp<InstitutionDto> CreateInstitution(InstitutionCreateReq req);
        InstitutionRsp<InstitutionDto> GetById(Guid instiutionId);
        InstitutionRsp<List<InstitutionDto>> GetAll();
    }
}