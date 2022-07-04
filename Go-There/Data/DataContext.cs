
using Microsoft.EntityFrameworkCore;

namespace Go_There.Data;
public  class DataContext :DbContext{


public DataContext(DbContextOptions<DataContext> options):base(options) {}

public DbSet<Models.Users> MyProperty { get; set; }





}