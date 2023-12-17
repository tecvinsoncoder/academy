using Academy.Core.Entities;
using Academy.Core.Interfaces;
using Academy.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace Academy.Repositories.Implementations
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private AcademyContext _academyContext;
        public InstitutionRepository(AcademyContext academyContext)
        {
            _academyContext = academyContext;
        }
        public async Task<Institution> Add(Institution institution)
        {
            _academyContext.Add(institution);
            _academyContext.SaveChanges();
            return await Task.FromResult(institution);
        }

        public async Task<bool> Delete(Guid institutionId)
        {
            var institution = await _academyContext
                            .Institutions
                            .Where(m => m.Id == institutionId)
                            .FirstOrDefaultAsync();
                            
            _academyContext
            .Institutions
            .Remove(institution ?? new Institution());

           return _academyContext.SaveChanges() > 0 ? true : false;
        }

        public async Task<List<Institution>> GetAll()
        {
            return await Task.FromResult( _academyContext
            .Institutions
            .ToList());
        }

        public async Task<Institution> GetById(Guid institutionId)
        {
            var institution = await _academyContext
                            .Institutions
                            .Where(m => m.Id == institutionId)
                            .FirstOrDefaultAsync();

            return institution ?? new Institution();
        }

        public async Task<Institution> Update(Institution institution)
        {
            var update = _academyContext.Institutions.Update(institution);
            _academyContext.SaveChanges();
            
            return await Task.FromResult(institution);
        }
    }
}