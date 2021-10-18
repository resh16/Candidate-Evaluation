using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candidate_Evaluation.Authentication
{
    public class CandidateEvaluationContext : IdentityDbContext<ApplicationUser>
    {
        public CandidateEvaluationContext(DbContextOptions<CandidateEvaluationContext> Options) : base(Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
