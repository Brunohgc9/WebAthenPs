using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Data
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Projects> Projects { get; set; }
        public DbSet<GenericProfessional> GenericProfessionals { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Projects>()
    .HasMany(p => p.Professionals)
    .WithMany(gp => gp.Projects)
    .UsingEntity(j => j.ToTable("ProjectProfessionals"));

            // Configuração da exclusão em cascata
            modelBuilder.Entity<GenericProfessional>()
                .HasOne(gp => gp.Client)
                .WithMany(c => c.GenericProfessionals)
                .HasForeignKey(gp => gp.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração da relação entre GenericProfessional e ApplicationUser (User)
            modelBuilder.Entity<GenericProfessional>()
                .HasOne(gp => gp.User)
                .WithMany() // Sem coleção inversa em ApplicationUser
                .HasForeignKey(gp => gp.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Projects>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Houses)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Projects>()
    .HasMany(p => p.Professionals)
    .WithMany(gp => gp.Projects)
    .UsingEntity<Dictionary<string, object>>(
        "ProjectProfessionals",
        r => r.HasOne<GenericProfessional>().WithMany().HasForeignKey("GProfessionalId"),
        l => l.HasOne<Projects>().WithMany().HasForeignKey("ProjectId"),
        je =>
        {
            je.HasKey("ProjectId", "GProfessionalId");
            je.HasData(
                // Associações entre projetos e profissionais
                new { ProjectId = 1, GProfessionalId = 1 },
                new { ProjectId = 1, GProfessionalId = 2 },
                new { ProjectId = 2, GProfessionalId = 3 },
                new { ProjectId = 2, GProfessionalId = 4 },
                new { ProjectId = 3, GProfessionalId = 5 },
                new { ProjectId = 3, GProfessionalId = 6 },
                new { ProjectId = 4, GProfessionalId = 7 },
                new { ProjectId = 4, GProfessionalId = 8 },
                new { ProjectId = 5, GProfessionalId = 9 },
                new { ProjectId = 5, GProfessionalId = 10 },
                new { ProjectId = 6, GProfessionalId = 11 },
                new { ProjectId = 6, GProfessionalId = 12 },
                new { ProjectId = 7, GProfessionalId = 13 },
                new { ProjectId = 7, GProfessionalId = 14 },
                new { ProjectId = 8, GProfessionalId = 15 },
                new { ProjectId = 8, GProfessionalId = 1 },
                new { ProjectId = 9, GProfessionalId = 2 },
                new { ProjectId = 9, GProfessionalId = 3 },
                new { ProjectId = 10, GProfessionalId = 4 },
                new { ProjectId = 10, GProfessionalId = 5 },
                new { ProjectId = 11, GProfessionalId = 6 },
                new { ProjectId = 11, GProfessionalId = 7 },
                new { ProjectId = 12, GProfessionalId = 8 },
                new { ProjectId = 12, GProfessionalId = 9 },
                new { ProjectId = 13, GProfessionalId = 10 },
                new { ProjectId = 13, GProfessionalId = 11 },
                new { ProjectId = 14, GProfessionalId = 12 },
                new { ProjectId = 14, GProfessionalId = 13 },
                new { ProjectId = 15, GProfessionalId = 14 },
                new { ProjectId = 15, GProfessionalId = 15 }
                // Adicione outras associações de projetos e profissionais aqui, se necessário
            );
        });


            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = "user1", UserName = "John Doe", Email = "john.doe@example.com", Role = "Admin", UserType = "Residential", CPF = "12345678901", RG = "1234567", Gender = "M", Address = "123 Main St", City = "CityA", State = "StateA", PostalCode = "12345" },
                new ApplicationUser { Id = "user2", UserName = "Jane Smith", Email = "jane.smith@example.com", Role = "User", UserType = "Commercial", CPF = "23456789012", RG = "2345678", Gender = "F", Address = "456 Oak St", City = "CityB", State = "StateB", PostalCode = "23456" },
                new ApplicationUser { Id = "user3", UserName = "Michael Johnson", Email = "michael.johnson@example.com", Role = "Admin", UserType = "Residential", CPF = "34567890123", RG = "3456789", Gender = "M", Address = "789 Pine St", City = "CityC", State = "StateC", PostalCode = "34567" },
                new ApplicationUser { Id = "user4", UserName = "Emily Davis", Email = "emily.davis@example.com", Role = "User", UserType = "Commercial", CPF = "45678901234", RG = "4567890", Gender = "F", Address = "101 Maple St", City = "CityD", State = "StateD", PostalCode = "45678" },
                new ApplicationUser { Id = "user5", UserName = "David Wilson", Email = "david.wilson@example.com", Role = "Admin", UserType = "Residential", CPF = "56789012345", RG = "5678901", Gender = "M", Address = "202 Birch St", City = "CityE", State = "StateE", PostalCode = "56789" },
                new ApplicationUser { Id = "user6", UserName = "Sarah Miller", Email = "sarah.miller@example.com", Role = "User", UserType = "Commercial", CPF = "67890123456", RG = "6789012", Gender = "F", Address = "303 Cedar St", City = "CityF", State = "StateF", PostalCode = "67890" },
                new ApplicationUser { Id = "user7", UserName = "James Moore", Email = "james.moore@example.com", Role = "Admin", UserType = "Residential", CPF = "78901234567", RG = "7890123", Gender = "M", Address = "404 Fir St", City = "CityG", State = "StateG", PostalCode = "78901" },
                new ApplicationUser { Id = "user8", UserName = "Olivia Taylor", Email = "olivia.taylor@example.com", Role = "User", UserType = "Commercial", CPF = "89012345678", RG = "8901234", Gender = "F", Address = "505 Spruce St", City = "CityH", State = "StateH", PostalCode = "89012" },
                new ApplicationUser { Id = "user9", UserName = "Daniel Anderson", Email = "daniel.anderson@example.com", Role = "Admin", UserType = "Residential", CPF = "90123456789", RG = "9012345", Gender = "M", Address = "606 Hemlock St", City = "CityI", State = "StateI", PostalCode = "90123" },
                new ApplicationUser { Id = "user10", UserName = "Madison Lee", Email = "madison.lee@example.com", Role = "User", UserType = "Commercial", CPF = "01234567890", RG = "0123456", Gender = "F", Address = "707 Juniper St", City = "CityJ", State = "StateJ", PostalCode = "01234" },
                new ApplicationUser { Id = "user11", UserName = "Ethan Harris", Email = "ethan.harris@example.com", Role = "Admin", UserType = "Residential", CPF = "12345678901", RG = "1234568", Gender = "M", Address = "808 Willow St", City = "CityK", State = "StateK", PostalCode = "12346" },
                new ApplicationUser { Id = "user12", UserName = "Isabella Clark", Email = "isabella.clark@example.com", Role = "User", UserType = "Commercial", CPF = "23456789012", RG = "2345679", Gender = "F", Address = "909 Poplar St", City = "CityL", State = "StateL", PostalCode = "23457" },
                new ApplicationUser { Id = "user13", UserName = "Alexander Lewis", Email = "alexander.lewis@example.com", Role = "Admin", UserType = "Residential", CPF = "34567890123", RG = "3456790", Gender = "M", Address = "1010 Redwood St", City = "CityM", State = "StateM", PostalCode = "34568" },
                new ApplicationUser { Id = "user14", UserName = "Ava Walker", Email = "ava.walker@example.com", Role = "User", UserType = "Commercial", CPF = "45678901234", RG = "4567901", Gender = "F", Address = "1111 Fir St", City = "CityN", State = "StateN", PostalCode = "45679" },
                new ApplicationUser { Id = "user15", UserName = "Liam Young", Email = "liam.young@example.com", Role = "Admin", UserType = "Residential", CPF = "56789012345", RG = "5678912", Gender = "M", Address = "1212 Elm St", City = "CityO", State = "StateO", PostalCode = "56780" }
            );



            modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, UserId = "user1" },
                new Client { ClientId = 2, UserId = "user2" },
                new Client { ClientId = 3, UserId = "user3" },
                new Client { ClientId = 4, UserId = "user4" },
                new Client { ClientId = 5, UserId = "user5" },
                new Client { ClientId = 6, UserId = "user6" },
                new Client { ClientId = 7, UserId = "user7" },
                new Client { ClientId = 8, UserId = "user8" },
                new Client { ClientId = 9, UserId = "user9" },
                new Client { ClientId = 10, UserId = "user10" },
                new Client { ClientId = 11, UserId = "user11" },
                new Client { ClientId = 12, UserId = "user12" },
                new Client { ClientId = 13, UserId = "user13" },
                new Client { ClientId = 14, UserId = "user14" },
                new Client { ClientId = 15, UserId = "user15" }
            );

            modelBuilder.Entity<GenericProfessional>().HasData(
                new GenericProfessional { GProfessionalId = 1, UserId = "user1", ClientId = 1 },
                new GenericProfessional { GProfessionalId = 2, UserId = "user2", ClientId = 2 },
                new GenericProfessional { GProfessionalId = 3, UserId = "user3", ClientId = 3 },
                new GenericProfessional { GProfessionalId = 4, UserId = "user4", ClientId = 4 },
                new GenericProfessional { GProfessionalId = 5, UserId = "user5", ClientId = 5 },
                new GenericProfessional { GProfessionalId = 6, UserId = "user6", ClientId = 6 },
                new GenericProfessional { GProfessionalId = 7, UserId = "user7", ClientId = 7 },
                new GenericProfessional { GProfessionalId = 8, UserId = "user8", ClientId = 8 },
                new GenericProfessional { GProfessionalId = 9, UserId = "user9", ClientId = 9 },
                new GenericProfessional { GProfessionalId = 10, UserId = "user10", ClientId = 10 },
                new GenericProfessional { GProfessionalId = 11, UserId = "user11", ClientId = 11 },
                new GenericProfessional { GProfessionalId = 12, UserId = "user12", ClientId = 12 },
                new GenericProfessional { GProfessionalId = 13, UserId = "user13", ClientId = 13 },
                new GenericProfessional { GProfessionalId = 14, UserId = "user14", ClientId = 14 },
                new GenericProfessional { GProfessionalId = 15, UserId = "user15", ClientId = 15 }
            );

            modelBuilder.Entity<Projects>().HasData(
                new Projects { ProjectId = 1, ProjectName = "Project Alpha", ConstructionType = "Residential", Status = "In Progress", Budget = 500000, StartDate = new DateTime(2024, 1, 1), Description = "Residential building item", Address = "123 Main St", Neighborhood = "Downtown", City = "CityA", State = "StateA", PostalCode = "12345", Country = "CountryA", TotalArea = 250.5m, NumberOfRooms = 4, NumberOfBathrooms = 3, ClientId = 1 },
                new Projects { ProjectId = 2, ProjectName = "Project Beta", ConstructionType = "Commercial", Status = "Completed", Budget = 1000000, StartDate = new DateTime(2023, 6, 1), EndDate = new DateTime(2024, 1, 15), Description = "Commercial building item", Address = "456 Oak St", Neighborhood = "Business District", City = "CityB", State = "StateB", PostalCode = "23456", Country = "CountryB", TotalArea = 500.0m, NumberOfRooms = 10, NumberOfBathrooms = 5, ClientId = 2 },
                new Projects { ProjectId = 3, ProjectName = "Project Gamma", ConstructionType = "Residential", Status = "Planning", Budget = 250000, StartDate = new DateTime(2024, 3, 1), Description = "Planning phase", Address = "789 Pine St", Neighborhood = "Suburban", City = "CityC", State = "StateC", PostalCode = "34567", Country = "CountryC", TotalArea = 180.0m, NumberOfRooms = 3, NumberOfBathrooms = 2, ClientId = 3 },
                new Projects { ProjectId = 4, ProjectName = "Project Delta", ConstructionType = "Commercial", Status = "In Progress", Budget = 750000, StartDate = new DateTime(2024, 4, 1), Description = "Office building item", Address = "101 Maple St", Neighborhood = "Tech Park", City = "CityD", State = "StateD", PostalCode = "45678", Country = "CountryD", TotalArea = 350.0m, NumberOfRooms = 8, NumberOfBathrooms = 4, ClientId = 4 },
                new Projects { ProjectId = 5, ProjectName = "Project Epsilon", ConstructionType = "Residential", Status = "Completed", Budget = 300000, StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2024, 2, 1), Description = "Single-family home", Address = "202 Birch St", Neighborhood = "Quiet Street", City = "CityE", State = "StateE", PostalCode = "56789", Country = "CountryE", TotalArea = 220.0m, NumberOfRooms = 5, NumberOfBathrooms = 3, ClientId = 5 },
                new Projects { ProjectId = 6, ProjectName = "Project Zeta", ConstructionType = "Commercial", Status = "Planning", Budget = 1200000, StartDate = new DateTime(2024, 6, 1), Description = "Shopping mall", Address = "303 Cedar St", Neighborhood = "Retail Hub", City = "CityF", State = "StateF", PostalCode = "67890", Country = "CountryF", TotalArea = 800.0m, NumberOfRooms = 20, NumberOfBathrooms = 10, ClientId = 6 },
                new Projects { ProjectId = 7, ProjectName = "Project Eta", ConstructionType = "Residential", Status = "In Progress", Budget = 600000, StartDate = new DateTime(2024, 7, 1), Description = "Luxury apartments", Address = "404 Fir St", Neighborhood = "Uptown", City = "CityG", State = "StateG", PostalCode = "78901", Country = "CountryG", TotalArea = 350.0m, NumberOfRooms = 6, NumberOfBathrooms = 4, ClientId = 7 },
                new Projects { ProjectId = 8, ProjectName = "Project Theta", ConstructionType = "Commercial", Status = "Completed", Budget = 500000, StartDate = new DateTime(2023, 8, 1), EndDate = new DateTime(2024, 3, 1), Description = "Retail space", Address = "505 Spruce St", Neighborhood = "Main Street", City = "CityH", State = "StateH", PostalCode = "89012", Country = "CountryH", TotalArea = 150.0m, NumberOfRooms = 2, NumberOfBathrooms = 1, ClientId = 8 },
                new Projects { ProjectId = 9, ProjectName = "Project Iota", ConstructionType = "Residential", Status = "Planning", Budget = 400000, StartDate = new DateTime(2024, 8, 1), Description = "Vacation home", Address = "606 Hemlock St", Neighborhood = "Lakeside", City = "CityI", State = "StateI", PostalCode = "90123", Country = "CountryI", TotalArea = 300.0m, NumberOfRooms = 4, NumberOfBathrooms = 2, ClientId = 9 },
                new Projects { ProjectId = 10, ProjectName = "Project Kappa", ConstructionType = "Commercial", Status = "In Progress", Budget = 800000, StartDate = new DateTime(2024, 9, 1), Description = "Restaurant", Address = "707 Juniper St", Neighborhood = "Downtown", City = "CityJ", State = "StateJ", PostalCode = "01234", Country = "CountryJ", TotalArea = 250.0m, NumberOfRooms = 5, NumberOfBathrooms = 3, ClientId = 10 },
                new Projects { ProjectId = 11, ProjectName = "Project Lambda", ConstructionType = "Residential", Status = "Completed", Budget = 350000, StartDate = new DateTime(2023, 10, 1), EndDate = new DateTime(2024, 4, 1), Description = "Townhouse", Address = "808 Willow St", Neighborhood = "Historic District", City = "CityK", State = "StateK", PostalCode = "12346", Country = "CountryK", TotalArea = 200.0m, NumberOfRooms = 4, NumberOfBathrooms = 2, ClientId = 11 },
                new Projects { ProjectId = 12, ProjectName = "Project Mu", ConstructionType = "Commercial", Status = "Planning", Budget = 950000, StartDate = new DateTime(2024, 10, 1), Description = "Corporate office", Address = "909 Poplar St", Neighborhood = "Business District", City = "CityL", State = "StateL", PostalCode = "23457", Country = "CountryL", TotalArea = 400.0m, NumberOfRooms = 8, NumberOfBathrooms = 4, ClientId = 12 },
                new Projects { ProjectId = 13, ProjectName = "Project Nu", ConstructionType = "Residential", Status = "In Progress", Budget = 700000, StartDate = new DateTime(2024, 11, 1), Description = "Condo complex", Address = "1010 Redwood St", Neighborhood = "Urban Area", City = "CityM", State = "StateM", PostalCode = "34568", Country = "CountryM", TotalArea = 350.0m, NumberOfRooms = 6, NumberOfBathrooms = 4, ClientId = 13 },
                new Projects { ProjectId = 14, ProjectName = "Project Xi", ConstructionType = "Commercial", Status = "Completed", Budget = 1100000, StartDate = new DateTime(2023, 12, 1), EndDate = new DateTime(2024, 5, 1), Description = "Hotel", Address = "1111 Fir St", Neighborhood = "Resort Area", City = "CityN", State = "StateN", PostalCode = "45679", Country = "CountryN", TotalArea = 600.0m, NumberOfRooms = 50, NumberOfBathrooms = 30, ClientId = 14 },
                new Projects { ProjectId = 15, ProjectName = "Project Omicron", ConstructionType = "Residential", Status = "In Progress", Budget = 500000, StartDate = new DateTime(2024, 10, 1), Description = "Family home", Address = "1212 Elm St", Neighborhood = "Suburban", City = "CityO", State = "StateO", PostalCode = "56780", Country = "CountryO", TotalArea = 270.0m, NumberOfRooms = 5, NumberOfBathrooms = 3, ClientId = 15 }
            );



        }
    }
}
