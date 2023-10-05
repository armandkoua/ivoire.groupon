using ivoire.groupon.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ivoire.groupon.Data
{
    public class GrouponContext: DbContext
    {
        public DbSet<Produit> Produits { get; set; }
    }
}
