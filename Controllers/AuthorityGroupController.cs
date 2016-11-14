using DotNetExampleApi.Domain;
using DotNetExampleApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetExampleApi.Controllers
{
    [Route("api/authority-groups")]
    public class AuthorityGroupController : Controller
    {
        private readonly IAuthorityGroupService AuthorityGroupService;

        public AuthorityGroupController(IAuthorityGroupService AuthorityGroupService)
        {
            this.AuthorityGroupService = AuthorityGroupService;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns>All Authority Groups</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(AuthorityGroupService.FindAll());
        }

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="Id">Authority Group Id</param>
        /// <returns>An Authority Group</returns>
        [HttpGet("{Id}")]
        public IActionResult GetById(long Id)
        {
            return Ok(AuthorityGroupService.FindById(Id));
        }

        /// <summary>
        /// Create an Authority Group
        /// </summary>
        /// <param name="AuthorityGroup">An Authority Group</param>
        /// <returns>An Authority Group</returns>
        [HttpPost]
        public IActionResult Insert([FromBody] AuthorityGroup AuthorityGroup)
        {
            return Ok(AuthorityGroupService.Insert(AuthorityGroup));
        }

        /// <summary>
        /// Update an Authority Group
        /// </summary>
        /// <param name="AuthorityGroup">An Authority Group</param>
        /// <returns>An Authority Group</returns>
        [HttpPut]
        public IActionResult Update([FromBody] AuthorityGroup AuthorityGroup)
        {
            return Ok(AuthorityGroupService.Update(AuthorityGroup));
        }

        /// <summary>
        /// Delete an Authority Group
        /// </summary>
        /// <param name="Id">An Authority Group Id</param>
        [HttpDelete("{Id}")]
        public IActionResult Delete(long Id)
        {
            return Ok(AuthorityGroupService.Delete(Id));
        }
    }
}
