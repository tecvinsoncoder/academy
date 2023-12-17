using Academy.Core.Entities;
using Academy.Services.Contracts.Institutions;

namespace Academy.Services.Extension
{
    public static class InstitutionExtensions
    {
        public static Institution AsEntity(this InstitutionCreateReq req)
        {
            return new Institution 
            {
                City = req.City,
                Country = req.Country,
                CreatedBy = "Me",
                DateCreated = DateTime.UtcNow
            };
        }
    }
}