using RegistrationUser.Models;
using Microsoft.EntityFrameworkCore;

namespace RegistrationUser.Data;

public class ApplicationDbContext : DbContext
{
    // конструктор, для налаштування параметрів підключеня до БД
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    // UserModel - об'єкти, які зберігаються в БД
    public DbSet<UserModel> UserModels{ get; set; }
}