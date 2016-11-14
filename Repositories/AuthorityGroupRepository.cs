using System.Collections.Generic;
using System.Linq;
using Dapper;
using DotNetExampleApi.Configuration;
using DotNetExampleApi.Domain;

namespace DotNetExampleApi.Repositories
{
    public class AuthorityGroupRepository : AbstractRepository, IAuthorityGroupRepository
    {
        public AuthorityGroupRepository(IMySqlDataSourceConfiguration MySqlDataSourceConfiguration) : base(MySqlDataSourceConfiguration)
        {
        }

        public List<AuthorityGroup> FindAll()
        {
            return GetDbConnection().Query<AuthorityGroup>("SELECT * FROM authority_group").AsList();
        }

        public AuthorityGroup FindById(long Id)
        {
            return GetDbConnection().Query<AuthorityGroup>("SELECT * FROM authority_group WHERE id = @Id", new { Id = Id }).SingleOrDefault<AuthorityGroup>();
        }

        public AuthorityGroup Insert(AuthorityGroup AuthorityGroup)
        {
            int AffectedRows = GetDbConnection().Execute("INSERT INTO authority_group (name, description, enabled) "
                                                            + "VALUES (@Name, @Description, @Enabled)",
                                                                new
                                                                {
                                                                    Name = AuthorityGroup.Name,
                                                                    AuthorityGroup.Description,
                                                                    AuthorityGroup.Enabled
                                                                });
            if (AffectedRows > 0)
            {
                long Id = GetDbConnection().Query<long>("SELECT LAST_INSERT_ID()").Single();
                return FindById(Id);
            }

            return null;
        }

        public AuthorityGroup Update(AuthorityGroup AuthorityGroup)
        {
            GetDbConnection().Query<AuthorityGroup>("UPDATE authority_group "
                                                    + "SET "
                                                        + "name = @Name, "
                                                        + "description = @Description, "
                                                        + "enabled = @Enabled "
                                                        + "WHERE id = @Id",
                                                        new
                                                        {
                                                            Id = AuthorityGroup.Id,
                                                            Name = AuthorityGroup.Name,
                                                            AuthorityGroup.Description,
                                                            AuthorityGroup.Enabled
                                                        });
            return FindById(AuthorityGroup.Id);
        }

        public int Delete(long Id)
        {
            int AffectedRows = GetDbConnection().Execute("DELETE FROM authority_group WHERE id = @Id", new { Id = Id });
            return AffectedRows;
        }
    }
}