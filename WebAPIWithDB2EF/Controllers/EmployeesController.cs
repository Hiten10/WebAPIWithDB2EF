using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIWithDB2EF.Models;

namespace WebAPIWithDB2EF.Controllers
{
    public class EmployeesController : ApiController
    {
        private SAMPLEEntities db = new SAMPLEEntities();

        // GET: api/Employees
        public IQueryable<EMPLOYEE> GetEMPLOYEEs()
        {
            return db.EMPLOYEEs.ToList().AsQueryable();
        }

        // GET: api/Employees/5
        [ResponseType(typeof(EMPLOYEE))]
        public async Task<IHttpActionResult> GetEMPLOYEE(string id)
        {
            EMPLOYEE eMPLOYEE = await db.EMPLOYEEs.Where(e=>e.EMPNO.Equals(id)).FirstOrDefaultAsync();
            if (eMPLOYEE == null)
            {
                return NotFound();
            }

            return Ok(eMPLOYEE);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEMPLOYEE(string id, EMPLOYEE eMPLOYEE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMPLOYEE.EMPNO)
            {
                return BadRequest();
            }

            db.Entry(eMPLOYEE).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMPLOYEEExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(EMPLOYEE))]
        public async Task<IHttpActionResult> PostEMPLOYEE(EMPLOYEE eMPLOYEE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMPLOYEEs.Add(eMPLOYEE);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EMPLOYEEExists(eMPLOYEE.EMPNO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eMPLOYEE.EMPNO }, eMPLOYEE);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(EMPLOYEE))]
        public async Task<IHttpActionResult> DeleteEMPLOYEE(string id)
        {
            EMPLOYEE eMPLOYEE = await db.EMPLOYEEs.FindAsync(id);
            if (eMPLOYEE == null)
            {
                return NotFound();
            }

            db.EMPLOYEEs.Remove(eMPLOYEE);
            await db.SaveChangesAsync();

            return Ok(eMPLOYEE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMPLOYEEExists(string id)
        {
            return db.EMPLOYEEs.Count(e => e.EMPNO == id) > 0;
        }
    }
}