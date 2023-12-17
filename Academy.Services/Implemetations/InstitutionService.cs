using Academy.Services.Contracts.Institutions;
using Academy.Services.Interfaces;
using Academy.Core.Interfaces;
using Academy.Services.Extension;

namespace Academy.Services.Implemetations
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IInstitutionRepository _repository;
        public InstitutionService(IInstitutionRepository repository)
        {
            _repository = repository;  
        }
        public InstitutionRsp<InstitutionDto> CreateInstitution(InstitutionCreateReq req)
        {
            var newInstituion = req.AsEntity();
            _repository.Add(newInstituion);

            return new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Messgae = string.Empty
            };
        }

        public InstitutionRsp<List<InstitutionDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public InstitutionRsp<InstitutionDto> GetById(Guid instiutionId)
        {
            throw new NotImplementedException();
        }

        InstitutionRsp<InstitutionDto> UpdateInstitution(InstitutionUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}