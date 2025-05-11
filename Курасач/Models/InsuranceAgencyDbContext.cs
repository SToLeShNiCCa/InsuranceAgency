using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Курасач.Models;

public partial class InsuranceAgencyDbContext : DbContext
{
    public InsuranceAgencyDbContext()
    {
    }

    public InsuranceAgencyDbContext(DbContextOptions<InsuranceAgencyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<CommonUser> CommonUsers { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<HealthInsurance> HealthInsurances { get; set; }

    public virtual DbSet<InsuranceClaim> InsuranceClaims { get; set; }

    public virtual DbSet<LifeInsurance> LifeInsurances { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Policy> Policies { get; set; }

    public virtual DbSet<PolicyType> PolicyTypes { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VersionUpdate> VersionUpdates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ITa4IK;Database=InsuranceAgency;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("PK__Agents__9AC3BFD1A51891F5");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.ContactNumber).HasMaxLength(15);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullAgentsName)
                .HasMaxLength(100)
                .HasColumnName("Full_Agents_Name");
            entity.Property(e => e.Stat)
                .HasMaxLength(20)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branches__3213E83FE024473C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.EmployeeCount).HasColumnName("employee_count");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CommonUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Common_U__3214EC276E91DF7C");

            entity.ToTable("Common_User");

            entity.HasIndex(e => e.UsersMail, "UQ__Common_U__2FB2F31021894295").IsUnique();

            entity.HasIndex(e => e.UsersLogin, "UQ__Common_U__4DF299E60AFE24D9").IsUnique();

            entity.HasIndex(e => e.PassportId, "UQ__Common_U__A6C3B540101978FB").IsUnique();

            entity.HasIndex(e => e.PassportNumber, "UQ__Common_U__EC266AD93892A158").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CardsNumber).HasColumnName("Cards_Number");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PassportId).HasColumnName("Passport_ID");
            entity.Property(e => e.PassportNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Passport_Number");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.UsersLogin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Users_Login");
            entity.Property(e => e.UsersMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Users_Mail");
            entity.Property(e => e.UsersPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Users_Password");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacts__3214EC27A3580288");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MessageContacts)
                .HasColumnType("text")
                .HasColumnName("Message_Contacts");
            entity.Property(e => e.NameOfMessager)
                .HasColumnType("text")
                .HasColumnName("Name_of_Messager");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__3213E83F1E331B48");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ContractDate).HasColumnName("contract_date");
            entity.Property(e => e.Terms)
                .HasColumnType("text")
                .HasColumnName("terms");

            entity.HasOne(d => d.Agent).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contracts__agent__6A30C649");

            entity.HasOne(d => d.Client).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contracts__clien__6B24EA82");
        });

        modelBuilder.Entity<HealthInsurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HealthIn__3213E83F43DE6109");

            entity.ToTable("HealthInsurance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CoverageLimit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("coverage_limit");
            entity.Property(e => e.MedicalConditions)
                .HasColumnType("text")
                .HasColumnName("medical_conditions");

            entity.HasOne(d => d.Client).WithMany(p => p.HealthInsurances)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HealthIns__clien__59063A47");
        });

        modelBuilder.Entity<InsuranceClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Insuranc__3213E83FB28608C4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("claim_status");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.IncidentDate).HasColumnName("incident_date");
            entity.Property(e => e.PolicyId).HasColumnName("policy_id");

            entity.HasOne(d => d.Policy).WithMany(p => p.InsuranceClaims)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Insurance__polic__6E01572D");
        });

        modelBuilder.Entity<LifeInsurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LifeInsu__3213E83F2C0D22B8");

            entity.ToTable("LifeInsurance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.InsuredAmount)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("insured_amount");

            entity.HasOne(d => d.Client).WithMany(p => p.LifeInsurances)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LifeInsur__clien__70DDC3D8");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.IdPayment).HasName("PK__Payments__C2118ADE0E433BB5");

            entity.Property(e => e.IdPayment).HasColumnName("ID_Payment");
            entity.Property(e => e.DateOfPay)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Date_of_pay");
            entity.Property(e => e.IdClients).HasColumnName("ID_Clients");
            entity.Property(e => e.IdPolices).HasColumnName("ID_Polices");
            entity.Property(e => e.Summa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TypeOfPay)
                .HasMaxLength(50)
                .HasColumnName("Type_of_pay");

            entity.HasOne(d => d.IdClientsNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.IdClients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clients_Payment");
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasName("PK__Policies__2E13394422DFE35E");

            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CoverageAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.Premium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Stat)
                .HasMaxLength(20)
                .HasDefaultValue("Active");

            entity.HasOne(d => d.Client).WithMany(p => p.Policies)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Policies_Clients");
        });

        modelBuilder.Entity<PolicyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolicyTy__3213E83FD4FC7218");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BasePrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("base_price");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Property__3213E83F33F856D7");

            entity.ToTable("Property");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.InsuredValue)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("insured_value");
            entity.Property(e => e.PropertyType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("property_type");

            entity.HasOne(d => d.Client).WithMany(p => p.Properties)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Property__client__60A75C0F");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reviews__3213E83F7801039F");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.ReviewDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("review_date");

            entity.HasOne(d => d.Client).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__client___5DCAEF64");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vehicles__3213E83F33F7BEBE");

            entity.HasIndex(e => e.RegistrationNumber, "UQ__Vehicles__125DB2A3F4B512EA").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.InsuredValue)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("insured_value");
            entity.Property(e => e.Mark)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mark");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("registration_number");
            entity.Property(e => e.YearOfMade).HasColumnName("year_of_made");

            entity.HasOne(d => d.Client).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vehicles__client__6477ECF3");
        });

        modelBuilder.Entity<VersionUpdate>(entity =>
        {
            entity.HasKey(e => e.NumberOfUpdate).HasName("PK__Version___5546AFC7697D25DD");

            entity.ToTable("Version_Update");

            entity.Property(e => e.NumberOfUpdate)
                .ValueGeneratedNever()
                .HasColumnName("Number_of_Update");
            entity.Property(e => e.ContentUpdate)
                .HasColumnType("text")
                .HasColumnName("Content_Update");
            entity.Property(e => e.DateOfUpdate).HasColumnName("Date_of_update");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
