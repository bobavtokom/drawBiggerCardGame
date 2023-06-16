using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class DbFirstTest {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarNumber { get; set; }
    }
    public class DbFirstTestcontext : DbContext {
        public DbSet<DbFirstTest> DbFirstTests {get; set;}
    }
}
