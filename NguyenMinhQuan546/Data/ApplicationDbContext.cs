using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenMinhQuan546.Models;

namespace NguyenMinhQuan546.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenMinhQuan546.Models.SinhVien> SinhVien { get; set; } = default!;
        public DbSet<NguyenMinhQuan546.Models.LopHoc> LopHoc { get; set; } = default!;
    }
}
