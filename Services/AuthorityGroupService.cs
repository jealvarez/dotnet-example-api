using System.Collections.Generic;
using DotNetExampleApi.Domain;
using DotNetExampleApi.Repositories;

namespace DotNetExampleApi.Services
{
    public class AuthorityGroupService : IAuthorityGroupService
    {
        private readonly IAuthorityGroupRepository AuthorityGroupRepository;

        public AuthorityGroupService(IAuthorityGroupRepository AuthorityGroupRepository)
        {
            this.AuthorityGroupRepository = AuthorityGroupRepository;
        }

        public List<AuthorityGroup> FindAll()
        {
            return this.AuthorityGroupRepository.FindAll();
        }

        public AuthorityGroup FindById(long Id)
        {
            return this.AuthorityGroupRepository.FindById(Id);
        }

        public AuthorityGroup Insert(AuthorityGroup AuthorityGroup)
        {
            return this.AuthorityGroupRepository.Insert(AuthorityGroup);
        }

        public AuthorityGroup Update(AuthorityGroup AuthorityGroup)
        {
            return this.AuthorityGroupRepository.Update(AuthorityGroup);
        }

        public int Delete(long Id)
        {
            return this.AuthorityGroupRepository.Delete(Id);
        }
    }
}