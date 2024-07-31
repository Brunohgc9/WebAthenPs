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

            modelBuilder.Entity<GenericProfessional>()
                .HasOne(gp => gp.Client)
                .WithMany(c => c.GenericProfessionals)
                .HasForeignKey(gp => gp.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GenericProfessional>()
                .HasOne(gp => gp.User)
                .WithMany()
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
                    r => r.HasOne<GenericProfessional>().WithMany().HasForeignKey("Id"),
                    l => l.HasOne<Projects>().WithMany().HasForeignKey("ProjectId"),
                    je =>
                    {
                        je.HasKey("ProjectId", "Id");
                        je.HasData(
                            // Associações entre projetos e profissionais
                            new { ProjectId = 1, Id = 1 },
                            new { ProjectId = 1, Id = 2 },
                            new { ProjectId = 2, Id = 3 },
                            new { ProjectId = 2, Id = 4 },
                            new { ProjectId = 3, Id = 5 },
                            new { ProjectId = 3, Id = 6 },
                            new { ProjectId = 4, Id = 7 },
                            new { ProjectId = 4, Id = 8 },
                            new { ProjectId = 5, Id = 9 },
                            new { ProjectId = 5, Id = 10 },
                            new { ProjectId = 6, Id = 11 },
                            new { ProjectId = 6, Id = 12 },
                            new { ProjectId = 7, Id = 13 },
                            new { ProjectId = 7, Id = 14 },
                            new { ProjectId = 8, Id = 15 },
                            new { ProjectId = 8, Id = 1 },
                            new { ProjectId = 9, Id = 2 },
                            new { ProjectId = 9, Id = 3 },
                            new { ProjectId = 10, Id = 4 },
                            new { ProjectId = 10, Id = 5 },
                            new { ProjectId = 11, Id = 6 },
                            new { ProjectId = 11, Id = 7 },
                            new { ProjectId = 12, Id = 8 },
                            new { ProjectId = 12, Id = 9 },
                            new { ProjectId = 13, Id = 10 },
                            new { ProjectId = 13, Id = 11 },
                            new { ProjectId = 14, Id = 12 },
                            new { ProjectId = 14, Id = 13 },
                            new { ProjectId = 15, Id = 14 },
                            new { ProjectId = 15, Id = 15 }
                        );
                    });


            modelBuilder.Entity<ApplicationUser>().HasData(
                // 15 Clients
                new ApplicationUser { Id = "user1", UserName = "Carlos Silva", Email = "carlos.silva@example.com", UserType = "Client", CPF = "12345678901", RG = "1234567", Gender = "M", Address = "Rua A, 123", City = "São Paulo", State = "SP", PostalCode = "01000-000" },
                new ApplicationUser { Id = "user2", UserName = "Ana Souza", Email = "ana.souza@example.com", UserType = "Client", CPF = "23456789012", RG = "2345678", Gender = "F", Address = "Rua B, 456", City = "Rio de Janeiro", State = "RJ", PostalCode = "20000-000" },
                new ApplicationUser { Id = "user3", UserName = "João Oliveira", Email = "joao.oliveira@example.com", UserType = "Client", CPF = "34567890123", RG = "3456789", Gender = "M", Address = "Rua C, 789", City = "Belo Horizonte", State = "MG", PostalCode = "30000-000" },
                new ApplicationUser { Id = "user4", UserName = "Maria Santos", Email = "maria.santos@example.com", UserType = "Client", CPF = "45678901234", RG = "4567890", Gender = "F", Address = "Rua D, 101", City = "Salvador", State = "BA", PostalCode = "40000-000" },
                new ApplicationUser { Id = "user5", UserName = "Pedro Almeida", Email = "pedro.almeida@example.com", UserType = "Client", CPF = "56789012345", RG = "5678901", Gender = "M", Address = "Rua E, 202", City = "Fortaleza", State = "CE", PostalCode = "60000-000" },
                new ApplicationUser { Id = "user6", UserName = "Juliana Costa", Email = "juliana.costa@example.com", UserType = "Client", CPF = "67890123456", RG = "6789012", Gender = "F", Address = "Rua F, 303", City = "Curitiba", State = "PR", PostalCode = "80000-000" },
                new ApplicationUser { Id = "user7", UserName = "Roberto Lima", Email = "roberto.lima@example.com", UserType = "Client", CPF = "78901234567", RG = "7890123", Gender = "M", Address = "Rua G, 404", City = "Porto Alegre", State = "RS", PostalCode = "90000-000" },
                new ApplicationUser { Id = "user8", UserName = "Patricia Martins", Email = "patricia.martins@example.com", UserType = "Client", CPF = "89012345678", RG = "8901234", Gender = "F", Address = "Rua H, 505", City = "Recife", State = "PE", PostalCode = "50000-000" },
                new ApplicationUser { Id = "user9", UserName = "Ricardo Fernandes", Email = "ricardo.fernandes@example.com", UserType = "Client", CPF = "90123456789", RG = "9012345", Gender = "M", Address = "Rua I, 606", City = "Belém", State = "PA", PostalCode = "66000-000" },
                new ApplicationUser { Id = "user10", UserName = "Claudia Rodrigues", Email = "claudia.rodrigues@example.com", UserType = "Client", CPF = "01234567890", RG = "0123456", Gender = "F", Address = "Rua J, 707", City = "Manaus", State = "AM", PostalCode = "69000-000" },
                new ApplicationUser { Id = "user11", UserName = "Fernando Oliveira", Email = "fernando.oliveira@example.com", UserType = "Client", CPF = "12345678901", RG = "1234567", Gender = "M", Address = "Rua K, 808", City = "São Luís", State = "MA", PostalCode = "65000-000" },
                new ApplicationUser { Id = "user12", UserName = "Luciana Pereira", Email = "luciana.pereira@example.com", UserType = "Client", CPF = "23456789012", RG = "2345678", Gender = "F", Address = "Rua L, 909", City = "São José de Ribamar", State = "MA", PostalCode = "65100-000" },
                new ApplicationUser { Id = "user13", UserName = "Eduardo Costa", Email = "eduardo.costa@example.com", UserType = "Client", CPF = "34567890123", RG = "3456789", Gender = "M", Address = "Rua M, 1010", City = "Teresina", State = "PI", PostalCode = "64000-000" },
                new ApplicationUser { Id = "user14", UserName = "Renata Almeida", Email = "renata.almeida@example.com", UserType = "Client", CPF = "45678901234", RG = "4567890", Gender = "F", Address = "Rua N, 1111", City = "Maceió", State = "AL", PostalCode = "57000-000" },
                new ApplicationUser { Id = "user15", UserName = "Carlos Eduardo", Email = "carlos.eduardo@example.com", UserType = "Client", CPF = "56789012345", RG = "5678901", Gender = "M", Address = "Rua O, 1212", City = "João Pessoa", State = "PB", PostalCode = "58000-000" },

                // 15 Professionals
                new ApplicationUser { Id = "user16", UserName = "Lucas Oliveira", Email = "lucas.oliveira@example.com", UserType = "Professional", CPF = "67890123456", RG = "6789012", Gender = "M", Address = "Rua P, 1313", City = "São Paulo", State = "SP", PostalCode = "01001-000" },
                new ApplicationUser { Id = "user17", UserName = "Mariana Silva", Email = "mariana.silva@example.com", UserType = "Professional", CPF = "78901234567", RG = "7890123", Gender = "F", Address = "Rua Q, 1414", City = "Rio de Janeiro", State = "RJ", PostalCode = "20001-000" },
                new ApplicationUser { Id = "user18", UserName = "Gabriel Santos", Email = "gabriel.santos@example.com", UserType = "Professional", CPF = "89012345678", RG = "8901234", Gender = "M", Address = "Rua R, 1515", City = "Belo Horizonte", State = "MG", PostalCode = "30001-000" },
                new ApplicationUser { Id = "user19", UserName = "Juliana Costa", Email = "juliana.costa@example.com", UserType = "Professional", CPF = "90123456789", RG = "9012345", Gender = "F", Address = "Rua S, 1616", City = "Salvador", State = "BA", PostalCode = "40001-000" },
                new ApplicationUser { Id = "user20", UserName = "Roberto Almeida", Email = "roberto.almeida@example.com", UserType = "Professional", CPF = "01234567890", RG = "0123456", Gender = "M", Address = "Rua T, 1717", City = "Fortaleza", State = "CE", PostalCode = "60001-000" },
                new ApplicationUser { Id = "user21", UserName = "Patricia Martins", Email = "patricia.martins@example.com", UserType = "Professional", CPF = "12345678901", RG = "1234567", Gender = "F", Address = "Rua U, 1818", City = "Curitiba", State = "PR", PostalCode = "80001-000" },
                new ApplicationUser { Id = "user22", UserName = "Ricardo Lima", Email = "ricardo.lima@example.com", UserType = "Professional", CPF = "23456789012", RG = "2345678", Gender = "M", Address = "Rua V, 1919", City = "Porto Alegre", State = "RS", PostalCode = "90001-000" },
                new ApplicationUser { Id = "user23", UserName = "Claudia Souza", Email = "claudia.souza@example.com", UserType = "Professional", CPF = "34567890123", RG = "3456789", Gender = "F", Address = "Rua W, 2020", City = "São Luís", State = "MA", PostalCode = "65001-000" },
                new ApplicationUser { Id = "user24", UserName = "Fernando Santos", Email = "fernando.santos@example.com", UserType = "Professional", CPF = "45678901234", RG = "4567890", Gender = "M", Address = "Rua X, 2121", City = "Teresina", State = "PI", PostalCode = "64001-000" },
                new ApplicationUser { Id = "user25", UserName = "Juliana Lima", Email = "juliana.lima@example.com", UserType = "Professional", CPF = "56789012345", RG = "5678901", Gender = "F", Address = "Rua Y, 2222", City = "Maceió", State = "AL", PostalCode = "57001-000" },
                new ApplicationUser { Id = "user26", UserName = "Ricardo Costa", Email = "ricardo.costa@example.com", UserType = "Professional", CPF = "67890123456", RG = "6789012", Gender = "M", Address = "Rua Z, 2323", City = "João Pessoa", State = "PB", PostalCode = "58001-000" },
                new ApplicationUser { Id = "user27", UserName = "Mariana Almeida", Email = "mariana.almeida@example.com", UserType = "Professional", CPF = "78901234567", RG = "7890123", Gender = "F", Address = "Rua AA, 2424", City = "São Paulo", State = "SP", PostalCode = "01002-000" },
                new ApplicationUser { Id = "user28", UserName = "Gabriel Souza", Email = "gabriel.souza@example.com", UserType = "Professional", CPF = "89012345678", RG = "8901234", Gender = "M", Address = "Rua BB, 2525", City = "Rio de Janeiro", State = "RJ", PostalCode = "20002-000" },
                new ApplicationUser { Id = "user29", UserName = "Juliana Rodrigues", Email = "juliana.rodrigues@example.com", UserType = "Professional", CPF = "90123456789", RG = "9012345", Gender = "F", Address = "Rua CC, 2626", City = "Belo Horizonte", State = "MG", PostalCode = "30002-000" },
                new ApplicationUser { Id = "user30", UserName = "Roberto Fernandes", Email = "roberto.fernandes@example.com", UserType = "Professional", CPF = "01234567890", RG = "0123456", Gender = "M", Address = "Rua DD, 2727", City = "Salvador", State = "BA", PostalCode = "40002-000" }
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
                new GenericProfessional { Id = 1, UserId = "user16", ClientId = 1, ProfessionalType = "Arquiteto" },
                new GenericProfessional { Id = 2, UserId = "user17", ClientId = 2, ProfessionalType = "Eletricista" },
                new GenericProfessional { Id = 3, UserId = "user18", ClientId = 3, ProfessionalType = "Engenheiro" },
                new GenericProfessional { Id = 4, UserId = "user19", ClientId = 4, ProfessionalType = "Pedreiro" },
                new GenericProfessional { Id = 5, UserId = "user20", ClientId = 5, ProfessionalType = "Encanador" },
                new GenericProfessional { Id = 6, UserId = "user21", ClientId = 6, ProfessionalType = "Arquiteto" },
                new GenericProfessional { Id = 7, UserId = "user22", ClientId = 7, ProfessionalType = "Eletricista" },
                new GenericProfessional { Id = 8, UserId = "user23", ClientId = 8, ProfessionalType = "Engenheiro" },
                new GenericProfessional { Id = 9, UserId = "user24", ClientId = 9, ProfessionalType = "Pedreiro" },
                new GenericProfessional { Id = 10, UserId = "user25", ClientId = 10, ProfessionalType = "Encanador" },
                new GenericProfessional { Id = 11, UserId = "user26", ClientId = 11, ProfessionalType = "Arquiteto" },
                new GenericProfessional { Id = 12, UserId = "user27", ClientId = 12, ProfessionalType = "Eletricista" },
                new GenericProfessional { Id = 13, UserId = "user28", ClientId = 13, ProfessionalType = "Engenheiro" },
                new GenericProfessional { Id = 14, UserId = "user29", ClientId = 14, ProfessionalType = "Pedreiro" },
                new GenericProfessional { Id = 15, UserId = "user30", ClientId = 15, ProfessionalType = "Encanador" }
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
