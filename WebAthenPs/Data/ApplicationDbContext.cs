using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;
using WebAthenPs.API.Entities.Project;

namespace WebAthenPs.API.Data
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Projecty> Projects { get; set; }
        public DbSet<GenericProfessional> GenericProfessionals { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Architect> Architects { get; set; }
        public DbSet<ProjectProfessional> ProjectProfessionals { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Chats> Chats { get; set; }
        public DbSet<ChatAndUsers> ChatAndUsers { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ChatAndUsers>()
            //    .HasOne(c => c.Chat)
            //    .WithMany(c => c.ChatAndUsers)
            //    .HasForeignKey(c => c.ChatId);            

            //modelBuilder.Entity<ChatAndUsers>()
            //    .HasOne(c => c.User)
            //    .WithMany(c => c.ChatAndUsers)
            //    .HasForeignKey(c => c.UserId);

            //modelBuilder.Entity<Chats>()
            //    .HasMany(c => c.ChatMessages)
            //    .WithOne(c => c.Chats)
            //    .HasForeignKey(c => c.ChatId);

            //modelBuilder.Entity<Chats>()
            //    .HasMany(c => c.ChatAndUsers)
            //    .WithOne(c => c.Chat)
            //    .HasForeignKey(c => c.UserId);

            //modelBuilder.Entity<ChatMessage>()
            //    .HasOne(c => c.User)
            //    .WithMany()
            //    .HasForeignKey(c => c.UserId);

            //modelBuilder.Entity<ChatMessage>()
            //    .HasOne(c => c.Chats)
            //    .WithMany(c => c.ChatMessages)
            //    .HasForeignKey(c => c.ChatId);


            modelBuilder.Entity<Projecty>()
           .HasMany(p => p.ProjectProfessionals)
           .WithOne(pp => pp.Project)
           .HasForeignKey(pp => pp.ProjectId);

            modelBuilder.Entity<GenericProfessional>()
                .HasMany(gp => gp.ProjectProfessionals)
                .WithOne(pp => pp.Professional)
                .HasForeignKey(pp => pp.ProfessionalId);


            modelBuilder.Entity<ProjectProfessional>()
                .HasKey(pp => pp.Id);

            modelBuilder.Entity<ProjectProfessional>()
                .HasOne(pp => pp.Professional)
                .WithMany(p => p.ProjectProfessionals)
                .HasForeignKey(pp => pp.ProfessionalId);

            modelBuilder.Entity<ProjectProfessional>()
                .HasOne(pp => pp.Project)
                .WithMany(p => p.ProjectProfessionals)
                .HasForeignKey(pp => pp.ProjectId);




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

            modelBuilder.Entity<Projecty>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Houses)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)               // Um Post tem um ApplicationUser
                .WithMany()                        // ApplicationUser pode ter muitos Posts
                .HasForeignKey(p => p.UserId)      // A chave estrangeira está no Post
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão se houver posts associados

            // Relacionamento entre Comment e ApplicationUser
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)               // Um Comment tem um ApplicationUser
                .WithMany()                        // ApplicationUser pode ter muitos Comments
                .HasForeignKey(c => c.UserId)      // A chave estrangeira está no Comment
                .OnDelete(DeleteBehavior.Restrict); // Restringir exclusão se houver comentários associados

            // Relacionamento entre Comment e Post
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)               // Um Comment tem um Post
                .WithMany(p => p.Comments)         // Post pode ter muitos Comments
                .HasForeignKey(c => c.PostId)      // A chave estrangeira está no Comment
                .OnDelete(DeleteBehavior.Cascade); // Excluir os comentários quando o post é excluído

            // Configuração da chave primária composta em ProjectProfessional
            modelBuilder.Entity<Post>()
                .HasKey(p => p.Id); // Chave primária única para Post

            modelBuilder.Entity<Comment>()
                .HasKey(c => c.Id); // Chave primária única para Comment

            modelBuilder.Entity<Proposal>()
                .HasKey(p => p.ProposalId); // Chave primária

            modelBuilder.Entity<Proposal>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Proposals)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade); // Excluir propostas ao excluir o cliente

            modelBuilder.Entity<Proposal>()
                .HasOne(p => p.Professional)
                .WithMany(gp => gp.Proposals)
                .HasForeignKey(p => p.ProfessionalId)
                .OnDelete(DeleteBehavior.Restrict); // Propostas não são excluídas ao excluir o profissional

            modelBuilder.Entity<Proposal>()
                .HasOne(p => p.Project)
                .WithMany(prop => prop.ProjectProposals)
                .HasForeignKey(prop => prop.ProjectId)
                .OnDelete(DeleteBehavior.Cascade); // Exclui propostas ao excluir o projeto



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


            //modelBuilder.Entity<Architect>().HasData(

            //    new Architect { Id = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"), ProfessionalTypeId = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1") },
            //    new Architect { Id = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), ProfessionalTypeId = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8") },
            //    new Architect { Id = Guid.Parse("76e63219-25e6-40f1-9a75-9486d4d478a9"), ProfessionalTypeId = Guid.Parse("76e63219-25e6-40f1-9a75-9486d4d478a9") },
            //    new Architect { Id = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), ProfessionalTypeId = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") },
            //    new Architect { Id = Guid.Parse("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"), ProfessionalTypeId = Guid.Parse("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e") }
            //    );

            //modelBuilder.Entity<CivilEngineer>().HasData(
            //    new CivilEngineer { Id = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"), ProfessionalTypeId = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1") },
            //    new CivilEngineer { Id = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8"), ProfessionalTypeId = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8") },
            //    new CivilEngineer { Id = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"), ProfessionalTypeId = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") },
            //    new CivilEngineer { Id = Guid.Parse("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"), ProfessionalTypeId = Guid.Parse("84e9327f-9c8a-41b3-84e6-2c548c29b8e3") },
            //    new CivilEngineer { Id = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851"), ProfessionalTypeId = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851") }
            //    );

            //modelBuilder.Entity<Electrician>().HasData(

            //    new Electrician { Id = Guid.Parse("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"), ProfessionalTypeId = Guid.Parse("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648") },
            //    new Electrician { Id = Guid.Parse("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"), ProfessionalTypeId = Guid.Parse("b8a7e539-8f3c-40d3-8a29-19edca7d65b4") },
            //    new Electrician { Id = Guid.Parse("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"), ProfessionalTypeId = Guid.Parse("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84") },
            //    new Electrician { Id = Guid.Parse("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6"), ProfessionalTypeId = Guid.Parse("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6") },
            //    new Electrician { Id = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851"), ProfessionalTypeId = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851") }

            //    );


            modelBuilder.Entity<GenericProfessionalProfessionalType>().HasData(
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"),
                   genericId = 1,
                   //ArchitectId = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1"),
                   //CivilEngineerId = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"),
                   genericId = 2,
                   //ElectricianId = Guid.Parse("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648"),
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8"),
                   genericId = 3,
                   //ArchitectId = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8"),
                   //CivilEngineerId = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("93bd828b-2b6e-42a6-92e3-248f01438d34"),
                   genericId = 4
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("b8a7e539-8f3c-40d3-8a29-19edca7d65b4"),
                   genericId = 5,
                   //ElectricianId = Guid.Parse("b8a7e539-8f3c-40d3-8a29-19edca7d65b4")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("76e63219-25e6-40f1-9a75-9486d4d478a9"),
                   genericId = 6,
                   //ArchitectId = Guid.Parse("76e63219-25e6-40f1-9a75-9486d4d478a9")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84"),
                   genericId = 7,
                   //ElectricianId  = Guid.Parse("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27"),
                   genericId = 8
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("36f41695-bc6e-4a3f-a7e9-d41643b81245"),
                   genericId = 9
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("eea39b7d-8f13-49bc-8c45-c8e293d64829"),
                   genericId = 10
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"),
                   genericId = 11,
                   //ArchitectId = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"),
                   //CivilEngineerId = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2"),
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6"),
                   genericId = 12,
                   //ElectricianId = Guid.Parse("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"),
                   genericId = 13,
                   //CivilEngineerId = Guid.Parse("84e9327f-9c8a-41b3-84e6-2c548c29b8e3"),
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e"),
                   genericId = 14,
                   //ArchitectId = Guid.Parse("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e")
               },
               new GenericProfessionalProfessionalType
               {
                   Id = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851"),
                   genericId = 15,
                   //CivilEngineerId = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851"),
                   //ElectricianId = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851")
               }
           );


            modelBuilder.Entity<GenericProfessional>().HasData(
                            new GenericProfessional { Id = 1, UserId = "user16", ClientId = 1, ProfessionalTypes = new List<string> { "Arquiteto", "Engenheiro" }, EspecializationsId = Guid.Parse("c9d2a9f8-1f7a-4b47-b550-84e73c3b72b1") },
                            new GenericProfessional { Id = 2, UserId = "user17", ClientId = 2, ProfessionalTypes = new List<string> { "Eletricista", "Pedreiro" }, EspecializationsId = Guid.Parse("a1f3b7e4-d3c2-4596-b5c3-620fc2c41648") },
                            new GenericProfessional { Id = 3, UserId = "user18", ClientId = 3, ProfessionalTypes = new List<string> { "Engenheiro", "Arquiteto", "Encanador" }, EspecializationsId = Guid.Parse("f13423a1-8b12-4d58-bcc1-2b29f41148c8") },
                            new GenericProfessional { Id = 4, UserId = "user19", ClientId = 4, ProfessionalTypes = new List<string> { "Pedreiro", "Marceneiro" }, EspecializationsId = Guid.Parse("93bd828b-2b6e-42a6-92e3-248f01438d34") },
                            new GenericProfessional { Id = 5, UserId = "user20", ClientId = 5, ProfessionalTypes = new List<string> { "Encanador", "Eletricista" }, EspecializationsId = Guid.Parse("b8a7e539-8f3c-40d3-8a29-19edca7d65b4") },
                            new GenericProfessional { Id = 6, UserId = "user21", ClientId = 6, ProfessionalTypes = new List<string> { "Arquiteto", "Pintor" }, EspecializationsId = Guid.Parse("76e63219-25e6-40f1-9a75-9486d4d478a9") },
                            new GenericProfessional { Id = 7, UserId = "user22", ClientId = 7, ProfessionalTypes = new List<string> { "Eletricista", "Pintor", "Vidraceiro" }, EspecializationsId = Guid.Parse("239bcae5-0c39-4bb2-8a9e-eebf92e4cd84") },
                            new GenericProfessional { Id = 8, UserId = "user23", ClientId = 8, ProfessionalTypes = new List<string> { "Engenheiro", "Serralheiro" }, EspecializationsId = Guid.Parse("5b6e1f3d-5d8a-4143-9e18-748cb5c06d27") },
                            new GenericProfessional { Id = 9, UserId = "user24", ClientId = 9, ProfessionalTypes = new List<string> { "Pedreiro", "Vidraceiro", "Carpinteiro" }, EspecializationsId = Guid.Parse("36f41695-bc6e-4a3f-a7e9-d41643b81245") },
                            new GenericProfessional { Id = 10, UserId = "user25", ClientId = 10, ProfessionalTypes = new List<string> { "Encanador", "Marceneiro" }, EspecializationsId = Guid.Parse("eea39b7d-8f13-49bc-8c45-c8e293d64829") },
                            new GenericProfessional { Id = 11, UserId = "user26", ClientId = 11, ProfessionalTypes = new List<string> { "Arquiteto", "Pintor", "Engenheiro" }, EspecializationsId = Guid.Parse("7f3b2d86-4d3c-498b-928c-5f8c3b7425d2") },
                            new GenericProfessional { Id = 12, UserId = "user27", ClientId = 12, ProfessionalTypes = new List<string> { "Eletricista" }, EspecializationsId = Guid.Parse("23d8a69f-bf42-4518-bcd9-e75a29e5c4d6") },
                            new GenericProfessional { Id = 13, UserId = "user28", ClientId = 13, ProfessionalTypes = new List<string> { "Engenheiro", "Pedreiro" }, EspecializationsId = Guid.Parse("84e9327f-9c8a-41b3-84e6-2c548c29b8e3") },
                            new GenericProfessional { Id = 14, UserId = "user29", ClientId = 14, ProfessionalTypes = new List<string> { "Arquiteto", "Decorador" }, EspecializationsId = Guid.Parse("3b948d76-b45e-4f9c-a37b-4d2b3e5c9a8e") },
                            new GenericProfessional { Id = 15, UserId = "user30", ClientId = 15, ProfessionalTypes = new List<string> { "Eletricista", "Engenheiro", "Pedreiro" }, EspecializationsId = Guid.Parse("d59c8723-c8a6-44b8-85d4-b72e93c24851") }
                        );



           





            modelBuilder.Entity<Projecty>().HasData(
               new Projecty { ProjectId = 1, ProjectName = "Project Alpha", ConstructionType = "Residential", Status = "In Progress", Budget = 500000, StartDate = new DateTime(2024, 1, 1), Description = "Residential building item", Address = "123 Main St", Neighborhood = "Downtown", City = "CityA", State = "StateA", PostalCode = "12345", Country = "CountryA", TotalArea = 250.5m, NumberOfRooms = 4, NumberOfBathrooms = 3, ClientId = 1, ActStep = "Phase 1" },
               new Projecty { ProjectId = 2, ProjectName = "Project Beta", ConstructionType = "Commercial", Status = "Completed", Budget = 1000000, StartDate = new DateTime(2023, 6, 1), EndDate = new DateTime(2024, 1, 15), Description = "Commercial building item", Address = "456 Oak St", Neighborhood = "Business District", City = "CityB", State = "StateB", PostalCode = "23456", Country = "CountryB", TotalArea = 500.0m, NumberOfRooms = 10, NumberOfBathrooms = 5, ClientId = 2, ActStep = "Phase 2" },
               new Projecty { ProjectId = 3, ProjectName = "Project Gamma", ConstructionType = "Residential", Status = "Planning", Budget = 250000, StartDate = new DateTime(2024, 3, 1), Description = "Planning phase", Address = "789 Pine St", Neighborhood = "Suburban", City = "CityC", State = "StateC", PostalCode = "34567", Country = "CountryC", TotalArea = 180.0m, NumberOfRooms = 3, NumberOfBathrooms = 2, ClientId = 3, ActStep = "Initial Planning" },
               new Projecty { ProjectId = 4, ProjectName = "Project Delta", ConstructionType = "Commercial", Status = "In Progress", Budget = 750000, StartDate = new DateTime(2024, 4, 1), Description = "Office building item", Address = "101 Maple St", Neighborhood = "Tech Park", City = "CityD", State = "StateD", PostalCode = "45678", Country = "CountryD", TotalArea = 350.0m, NumberOfRooms = 8, NumberOfBathrooms = 4, ClientId = 4, ActStep = "Construction" },
               new Projecty { ProjectId = 5, ProjectName = "Project Epsilon", ConstructionType = "Residential", Status = "Completed", Budget = 300000, StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2024, 2, 1), Description = "Single-family home", Address = "202 Birch St", Neighborhood = "Quiet Street", City = "CityE", State = "StateE", PostalCode = "56789", Country = "CountryE", TotalArea = 220.0m, NumberOfRooms = 5, NumberOfBathrooms = 3, ClientId = 5, ActStep = "Final Touches" },
               new Projecty { ProjectId = 6, ProjectName = "Project Zeta", ConstructionType = "Commercial", Status = "Planning", Budget = 1200000, StartDate = new DateTime(2024, 6, 1), Description = "Shopping mall", Address = "303 Cedar St", Neighborhood = "Retail Hub", City = "CityF", State = "StateF", PostalCode = "67890", Country = "CountryF", TotalArea = 800.0m, NumberOfRooms = 20, NumberOfBathrooms = 10, ClientId = 6, ActStep = "Site Selection" },
               new Projecty { ProjectId = 7, ProjectName = "Project Eta", ConstructionType = "Residential", Status = "In Progress", Budget = 600000, StartDate = new DateTime(2024, 7, 1), Description = "Luxury apartments", Address = "404 Fir St", Neighborhood = "Uptown", City = "CityG", State = "StateG", PostalCode = "78901", Country = "CountryG", TotalArea = 350.0m, NumberOfRooms = 6, NumberOfBathrooms = 4, ClientId = 7, ActStep = "Structural Work" },
               new Projecty { ProjectId = 8, ProjectName = "Project Theta", ConstructionType = "Commercial", Status = "Completed", Budget = 500000, StartDate = new DateTime(2023, 8, 1), EndDate = new DateTime(2024, 3, 1), Description = "Retail space", Address = "505 Spruce St", Neighborhood = "Main Street", City = "CityH", State = "StateH", PostalCode = "89012", Country = "CountryH", TotalArea = 150.0m, NumberOfRooms = 2, NumberOfBathrooms = 1, ClientId = 8, ActStep = "Inspection" },
               new Projecty { ProjectId = 9, ProjectName = "Project Iota", ConstructionType = "Residential", Status = "Planning", Budget = 400000, StartDate = new DateTime(2024, 8, 1), Description = "Vacation home", Address = "606 Hemlock St", Neighborhood = "Lakeside", City = "CityI", State = "StateI", PostalCode = "90123", Country = "CountryI", TotalArea = 300.0m, NumberOfRooms = 4, NumberOfBathrooms = 2, ClientId = 9, ActStep = "Budget Approval" },
               new Projecty { ProjectId = 10, ProjectName = "Project Kappa", ConstructionType = "Commercial", Status = "In Progress", Budget = 800000, StartDate = new DateTime(2024, 9, 1), Description = "Restaurant", Address = "707 Juniper St", Neighborhood = "Downtown", City = "CityJ", State = "StateJ", PostalCode = "01234", Country = "CountryJ", TotalArea = 250.0m, NumberOfRooms = 5, NumberOfBathrooms = 3, ClientId = 10, ActStep = "Interior Design" },
               new Projecty { ProjectId = 11, ProjectName = "Project Lambda", ConstructionType = "Residential", Status = "Completed", Budget = 350000, StartDate = new DateTime(2023, 10, 1), EndDate = new DateTime(2024, 4, 1), Description = "Townhouse", Address = "808 Willow St", Neighborhood = "Historic District", City = "CityK", State = "StateK", PostalCode = "12346", Country = "CountryK", TotalArea = 200.0m, NumberOfRooms = 4, NumberOfBathrooms = 2, ClientId = 11, ActStep = "Landscaping" },
               new Projecty { ProjectId = 12, ProjectName = "Project Mu", ConstructionType = "Commercial", Status = "Planning", Budget = 950000, StartDate = new DateTime(2024, 10, 1), Description = "Corporate office", Address = "909 Poplar St", Neighborhood = "Business District", City = "CityL", State = "StateL", PostalCode = "23457", Country = "CountryL", TotalArea = 400.0m, NumberOfRooms = 8, NumberOfBathrooms = 4, ClientId = 12, ActStep = "Permitting" },
               new Projecty { ProjectId = 13, ProjectName = "Project Nu", ConstructionType = "Residential", Status = "In Progress", Budget = 700000, StartDate = new DateTime(2024, 11, 1), Description = "Condo complex", Address = "1010 Redwood St", Neighborhood = "Urban Area", City = "CityM", State = "StateM", PostalCode = "34568", Country = "CountryM", TotalArea = 350.0m, NumberOfRooms = 6, NumberOfBathrooms = 4, ClientId = 13, ActStep = "Framing" },
               new Projecty { ProjectId = 14, ProjectName = "Project Xi", ConstructionType = "Commercial", Status = "Completed", Budget = 1100000, StartDate = new DateTime(2023, 12, 1), EndDate = new DateTime(2024, 5, 1), Description = "Tech campus", Address = "1111 Cedar St", Neighborhood = "Innovation Hub", City = "CityN", State = "StateN", PostalCode = "45679", Country = "CountryN", TotalArea = 1000.0m, NumberOfRooms = 30, NumberOfBathrooms = 15, ClientId = 14, ActStep = "Final Inspection" },
               new Projecty { ProjectId = 15, ProjectName = "Project Omicron", ConstructionType = "Residential", Status = "Planning", Budget = 550000, StartDate = new DateTime(2025, 1, 1), Description = "Eco-friendly home", Address = "1212 Birch St", Neighborhood = "Green Valley", City = "CityO", State = "StateO", PostalCode = "56790", Country = "CountryO", TotalArea = 275.0m, NumberOfRooms = 4, NumberOfBathrooms = 3, ClientId = 15, ActStep = "Design Approval" }
           );

            modelBuilder.Entity<ProjectProfessional>().HasData(
                new ProjectProfessional { Id = 1, ProjectId = 1, ProfessionalId = 1, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 2, ProjectId = 1, ProfessionalId = 6, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 3, ProjectId = 2, ProfessionalId = 2, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 4, ProjectId = 2, ProfessionalId = 7, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 5, ProjectId = 3, ProfessionalId = 3, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 6, ProjectId = 3, ProfessionalId = 8, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 7, ProjectId = 4, ProfessionalId = 4, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 8, ProjectId = 4, ProfessionalId = 9, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 9, ProjectId = 5, ProfessionalId = 5, ContractedAs = new List<string> { "Encanador" } },
                new ProjectProfessional { Id = 10, ProjectId = 5, ProfessionalId = 10, ContractedAs = new List<string> { "Encanador" } },
                new ProjectProfessional { Id = 11, ProjectId = 6, ProfessionalId = 11, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 12, ProjectId = 6, ProfessionalId = 12, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 13, ProjectId = 7, ProfessionalId = 13, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 14, ProjectId = 7, ProfessionalId = 14, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 15, ProjectId = 8, ProfessionalId = 15, ContractedAs = new List<string> { "Encanador" } },
                new ProjectProfessional { Id = 16, ProjectId = 8, ProfessionalId = 1, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 17, ProjectId = 9, ProfessionalId = 6, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 18, ProjectId = 9, ProfessionalId = 2, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 19, ProjectId = 10, ProfessionalId = 7, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 20, ProjectId = 10, ProfessionalId = 3, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 21, ProjectId = 11, ProfessionalId = 8, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 22, ProjectId = 11, ProfessionalId = 4, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 23, ProjectId = 12, ProfessionalId = 9, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 24, ProjectId = 12, ProfessionalId = 5, ContractedAs = new List<string> { "Encanador" } },
                new ProjectProfessional { Id = 25, ProjectId = 13, ProfessionalId = 10, ContractedAs = new List<string> { "Encanador" } },
                new ProjectProfessional { Id = 26, ProjectId = 13, ProfessionalId = 11, ContractedAs = new List<string> { "Eletricista" } },
                new ProjectProfessional { Id = 27, ProjectId = 14, ProfessionalId = 12, ContractedAs = new List<string> { "Arquiteto" } },
                new ProjectProfessional { Id = 28, ProjectId = 14, ProfessionalId = 13, ContractedAs = new List<string> { "Engenheiro" } },
                new ProjectProfessional { Id = 29, ProjectId = 15, ProfessionalId = 14, ContractedAs = new List<string> { "Pedreiro" } },
                new ProjectProfessional { Id = 30, ProjectId = 15, ProfessionalId = 15, ContractedAs = new List<string> { "Encanador" } }
            );

        }
    }
}

