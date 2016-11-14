using System.Collections.Generic;
using DotNetExampleApi.Domain;

namespace DotNetExampleApi.Repositories
{
    public interface IAuthorityGroupRepository
    {
        List<AuthorityGroup> FindAll();
        AuthorityGroup FindById(long Id);
        AuthorityGroup Insert(AuthorityGroup AuthorityGroup);
        AuthorityGroup Update(AuthorityGroup AuthorityGroup);
        int Delete(long Id);
    }
}