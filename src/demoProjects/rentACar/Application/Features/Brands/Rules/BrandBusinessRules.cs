using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Features.Brands.Rules
{
    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;
        
        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCannotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(x => x.Name == name);
            if (result.Items.Any()) throw new BusinessException("Brand name already exist");
            //Error messages could be const variables for multilanguage  support

        }
        public void BrandShouldExistWhenRequested(Brand brand)
        {
            if (brand == null) throw new BusinessException("Requested brand does not exist");

        }
    }
}
