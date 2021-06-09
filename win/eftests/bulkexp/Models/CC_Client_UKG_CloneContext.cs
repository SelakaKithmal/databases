using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bulkexp.Models
{
    public partial class CC_Client_UKG_CloneContext : DbContext
    {
        public CC_Client_UKG_CloneContext(DbContextOptions<CC_Client_UKG_CloneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlertType> AlertTypes { get; set; }
        public virtual DbSet<AlertVium> AlertVia { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentComment> AppointmentComments { get; set; }
        public virtual DbSet<AppointmentServiceRequest> AppointmentServiceRequests { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public virtual DbSet<AppointmentType> AppointmentTypes { get; set; }
        public virtual DbSet<AssistType> AssistTypes { get; set; }
        public virtual DbSet<AuditAction> AuditActions { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<Checklist> Checklists { get; set; }
        public virtual DbSet<CollectedStat> CollectedStats { get; set; }
        public virtual DbSet<ConcurrencyMode> ConcurrencyModes { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<CustomField> CustomFields { get; set; }
        public virtual DbSet<CustomFieldValue> CustomFieldValues { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<KioskConfiguration> KioskConfigurations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Lobby> Lobbies { get; set; }
        public virtual DbSet<LobbyComment> LobbyComments { get; set; }
        public virtual DbSet<LobbyEntry> LobbyEntries { get; set; }
        public virtual DbSet<LobbyEntryEditHistory> LobbyEntryEditHistories { get; set; }
        public virtual DbSet<LobbyInteraction> LobbyInteractions { get; set; }
        public virtual DbSet<LobbyServiceProvided> LobbyServiceProvideds { get; set; }
        public virtual DbSet<LobbyServiceRequest> LobbyServiceRequests { get; set; }
        public virtual DbSet<LobbySource> LobbySources { get; set; }
        public virtual DbSet<LobbyStatus> LobbyStatuses { get; set; }
        public virtual DbSet<LocalizedField> LocalizedFields { get; set; }
        public virtual DbSet<LocalizedText> LocalizedTexts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationHierarchy> LocationHierarchies { get; set; }
        public virtual DbSet<LocationHoursOfOperation> LocationHoursOfOperations { get; set; }
        public virtual DbSet<LocationService> LocationServices { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<Lwareason> Lwareasons { get; set; }
        public virtual DbSet<MessageFormatType> MessageFormatTypes { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<MessageTemplateConfig> MessageTemplateConfigs { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }
        public virtual DbSet<NotificationMessageStatus> NotificationMessageStatuses { get; set; }
        public virtual DbSet<NotificationMessageTemplate> NotificationMessageTemplates { get; set; }
        public virtual DbSet<OngoingTimeStat> OngoingTimeStats { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<QueueConfiguration> QueueConfigurations { get; set; }
        public virtual DbSet<QueueStrategy> QueueStrategies { get; set; }
        public virtual DbSet<ResourceExceptionType> ResourceExceptionTypes { get; set; }
        public virtual DbSet<ResourceType> ResourceTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<SourceType> SourceTypes { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserHoursOfOperation> UserHoursOfOperations { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserService> UserServices { get; set; }
        public virtual DbSet<UserSignIn> UserSignIns { get; set; }
        public virtual DbSet<UserSignInHistory> UserSignInHistories { get; set; }
        public virtual DbSet<UserSignInStatus> UserSignInStatuses { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<UserWorkLocation> UserWorkLocations { get; set; }
        public virtual DbSet<WorkAvailTemplate> WorkAvailTemplates { get; set; }
        public virtual DbSet<WorkAvailTemplateDay> WorkAvailTemplateDays { get; set; }
        public virtual DbSet<WorkAvailTemplateTimeRange> WorkAvailTemplateTimeRanges { get; set; }
        public virtual DbSet<WorkExceptionType> WorkExceptionTypes { get; set; }
        public virtual DbSet<WorkScheduleType> WorkScheduleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=BUWANEKA-S;Initial Catalog=CC_Client_UKG_Clone;Integrated Security=true;Column Encryption Setting=enabled;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AlertType>(entity =>
            {
                entity.ToTable("AlertType");

                entity.Property(e => e.AlertTypeId).ValueGeneratedNever();

                entity.Property(e => e.AlertType1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AlertType");
            });

            modelBuilder.Entity<AlertVium>(entity =>
            {
                entity.HasKey(e => e.AlertViaId);

                entity.Property(e => e.AlertViaId).ValueGeneratedNever();

                entity.Property(e => e.AlertVia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmationNumber).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtCustomerId).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.OldLtappointmentId).HasColumnName("OldLTAppointmentId");

                entity.Property(e => e.OltcheckInTime)
                    .HasColumnType("datetime")
                    .HasColumnName("OLTCheckInTime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.AppointmentChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Appointment_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AppointmentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_CreatedBy");

                entity.HasOne(d => d.FkAppointmentStatus)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkAppointmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_AppointmentStatus");

                entity.HasOne(d => d.FkAppointmentType)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkAppointmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_AppointmentType");

                entity.HasOne(d => d.FkAssignedUser)
                    .WithMany(p => p.AppointmentFkAssignedUsers)
                    .HasForeignKey(d => d.FkAssignedUserId)
                    .HasConstraintName("FK_Appointment_AssignedUser");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkLocationId)
                    .HasConstraintName("FK_Appointment_Location");

                entity.HasOne(d => d.FkSourceType)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkSourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_SourceType");
            });

            modelBuilder.Entity<AppointmentComment>(entity =>
            {
                entity.ToTable("AppointmentComment");

                entity.Property(e => e.AppointmentCommentId).ValueGeneratedNever();

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.AppointmentComments)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_AppointmentComment_User_Changed");

                entity.HasOne(d => d.FkAppointment)
                    .WithMany(p => p.AppointmentComments)
                    .HasForeignKey(d => d.FkAppointmentId)
                    .HasConstraintName("FK_AppointmentComment_Appointment");
            });

            modelBuilder.Entity<AppointmentServiceRequest>(entity =>
            {
                entity.ToTable("AppointmentServiceRequest");

                entity.HasIndex(e => e.FkAppointmentId, "IX_AppointmentServiceRequest_FkAppointmentId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.AppointmentServiceRequests)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK__AppointmentServiceRequest_ChangedBy");

                entity.HasOne(d => d.FkAppointment)
                    .WithMany(p => p.AppointmentServiceRequests)
                    .HasForeignKey(d => d.FkAppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentServiceRequest_Appointment");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.AppointmentServiceRequests)
                    .HasForeignKey(d => d.FkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentServiceRequest_Service");
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.ToTable("AppointmentStatus");

                entity.Property(e => e.AppointmentStatusId).ValueGeneratedNever();

                entity.Property(e => e.AppointmentStatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocalizedKey)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointmentType>(entity =>
            {
                entity.ToTable("AppointmentType");

                entity.Property(e => e.AppointmentTypeId).ValueGeneratedNever();

                entity.Property(e => e.AppointmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColorCode).HasMaxLength(20);
            });

            modelBuilder.Entity<AssistType>(entity =>
            {
                entity.ToTable("AssistType");

                entity.Property(e => e.AssistTypeId).ValueGeneratedNever();

                entity.Property(e => e.AssistTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditAction>(entity =>
            {
                entity.ToTable("AuditAction");

                entity.Property(e => e.AuditActionId).ValueGeneratedNever();

                entity.Property(e => e.AuditActionName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__Audit");

                entity.ToTable("AuditLog");

                entity.Property(e => e.AuditData).UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkuserId).HasColumnName("FKUserId");

                entity.HasOne(d => d.FkAuditAction)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.FkAuditActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Audit__AuditAction");

                entity.HasOne(d => d.FkEntityType)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.FkEntityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Audit__AuditEntityType");

                entity.HasOne(d => d.Fkuser)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.FkuserId)
                    .HasConstraintName("FK__Audit__User");
            });

            modelBuilder.Entity<Checklist>(entity =>
            {
                entity.ToTable("Checklist");

                entity.Property(e => e.ChangedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ChecklistItem)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.LinkName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.ChecklistChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Checklist_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ChecklistCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checklist_CreatedBy");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.Checklists)
                    .HasForeignKey(d => d.FkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checklist_Service");
            });

            modelBuilder.Entity<CollectedStat>(entity =>
            {
                entity.ToTable("CollectedStat");

                entity.Property(e => e.CollectedDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.GroupbyField1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupbyField2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConcurrencyMode>(entity =>
            {
                entity.ToTable("ConcurrencyMode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.ConfigurationId).ValueGeneratedNever();

                entity.Property(e => e.ConfigurationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigurationValue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomField>(entity =>
            {
                entity.ToTable("CustomField");

                entity.Property(e => e.CustomFieldId).ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaData).IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomFieldValue>(entity =>
            {
                entity.HasKey(e => new { e.FkCustomFieldId, e.FkEntityId });

                entity.ToTable("CustomFieldValue");

                entity.Property(e => e.CustomFieldValue1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CustomFieldValue")
                    .UseCollation("Latin1_General_BIN2");

                entity.HasOne(d => d.FkAddedByNavigation)
                    .WithMany(p => p.CustomFieldValueFkAddedByNavigations)
                    .HasForeignKey(d => d.FkAddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomFieldValue_AddedByUser");

                entity.HasOne(d => d.FkCustomField)
                    .WithMany(p => p.CustomFieldValues)
                    .HasForeignKey(d => d.FkCustomFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomFieldValue_CustomField");

                entity.HasOne(d => d.FkUpdatedByNavigation)
                    .WithMany(p => p.CustomFieldValueFkUpdatedByNavigations)
                    .HasForeignKey(d => d.FkUpdatedBy)
                    .HasConstraintName("FK_CustomFieldValue_UpdatedByUser");
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.ToTable("EntityType");

                entity.Property(e => e.EntityTypeId).ValueGeneratedNever();

                entity.Property(e => e.AuditEnabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntityTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.HolidayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsAllDay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.HolidayChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Holiday_UserChanged");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.HolidayCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Holiday_UserCreated");

                entity.HasOne(d => d.FkHolidayParent)
                    .WithMany(p => p.InverseFkHolidayParent)
                    .HasForeignKey(d => d.FkHolidayParentId)
                    .HasConstraintName("FK_Holiday_Holiday");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.Holidays)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Holiday_Location");
            });

            modelBuilder.Entity<KioskConfiguration>(entity =>
            {
                entity.HasKey(e => e.FkLocationId);

                entity.ToTable("KioskConfiguration");

                entity.HasIndex(e => e.LocalizedRowId, "UQ_KioskConfiguration_LocalizedRowId")
                    .IsUnique();

                entity.Property(e => e.FkLocationId).ValueGeneratedNever();

                entity.Property(e => e.ChangedByDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DefaultSelectedPersonOrGroup)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultThankyouText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultWelcomeText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FontSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SortServiceListBy)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WaitOption)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.KioskConfigurationChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_KioskConfiguration_User_Changed ");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.KioskConfigurationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KioskConfiguration_User_Created ");

                entity.HasOne(d => d.FkLocation)
                    .WithOne(p => p.KioskConfiguration)
                    .HasForeignKey<KioskConfiguration>(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KioskConfiguration_Location");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.LanguageId).ValueGeneratedNever();

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageShortName)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocalizedKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lobby>(entity =>
            {
                entity.ToTable("Lobby");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Default')");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.Lobbies)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lobby_Location");

                entity.HasOne(d => d.FkQueueStrategy)
                    .WithMany(p => p.Lobbies)
                    .HasForeignKey(d => d.FkQueueStrategyId)
                    .HasConstraintName("FK_Lobby_QueueStrategy");
            });

            modelBuilder.Entity<LobbyComment>(entity =>
            {
                entity.ToTable("LobbyComment");

                entity.Property(e => e.AddedTime).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.FkAddedByNavigation)
                    .WithMany(p => p.LobbyComments)
                    .HasForeignKey(d => d.FkAddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyComment_User");

                entity.HasOne(d => d.FkLobbyEntry)
                    .WithMany(p => p.LobbyComments)
                    .HasForeignKey(d => d.FkLobbyEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyComment_LobbyEntry");
            });

            modelBuilder.Entity<LobbyEntry>(entity =>
            {
                entity.ToTable("LobbyEntry");

                entity.Property(e => e.AccountNoLastFourDigits)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.AddedLocalTime).HasColumnType("datetime");

                entity.Property(e => e.AddedTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedLocalTime).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.VirtualAddedTimeForWaitCalculation).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_LobbyEntry_Appointment");

                entity.HasOne(d => d.FkAddedByNavigation)
                    .WithMany(p => p.LobbyEntryFkAddedByNavigations)
                    .HasForeignKey(d => d.FkAddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntry_AddedByUser");

                entity.HasOne(d => d.FkLobby)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.FkLobbyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntry_Lobby");

                entity.HasOne(d => d.FkLobbySource)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.FkLobbySourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntry_LobbySource");

                entity.HasOne(d => d.FkLwaReason)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.FkLwaReasonId)
                    .HasConstraintName("FK_LobbyEntry_LWAReason");

                entity.HasOne(d => d.FkPreferredLanguageNavigation)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.FkPreferredLanguage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntry_PreferredLanguage");

                entity.HasOne(d => d.FkStatusNavigation)
                    .WithMany(p => p.LobbyEntries)
                    .HasForeignKey(d => d.FkStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntry_Status");

                entity.HasOne(d => d.FkUpdatedByNavigation)
                    .WithMany(p => p.LobbyEntryFkUpdatedByNavigations)
                    .HasForeignKey(d => d.FkUpdatedBy)
                    .HasConstraintName("FK_LobbyEntry_UpdatedByUser");

                entity.HasOne(d => d.FkUserRequestedNavigation)
                    .WithMany(p => p.LobbyEntryFkUserRequestedNavigations)
                    .HasForeignKey(d => d.FkUserRequested)
                    .HasConstraintName("FK_LobbyEntry_UserRequested");
            });

            modelBuilder.Entity<LobbyEntryEditHistory>(entity =>
            {
                entity.ToTable("LobbyEntryEditHistory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EditedTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkEditedBy)
                    .WithMany(p => p.LobbyEntryEditHistories)
                    .HasForeignKey(d => d.FkEditedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntryEditHistory_EditedBy");

                entity.HasOne(d => d.FkLobbyEntry)
                    .WithMany(p => p.LobbyEntryEditHistories)
                    .HasForeignKey(d => d.FkLobbyEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyEntryEditHistory_LobbyEntry");
            });

            modelBuilder.Entity<LobbyInteraction>(entity =>
            {
                entity.HasKey(e => e.InteractionId);

                entity.ToTable("LobbyInteraction");

                entity.Property(e => e.AssistedLocalTime).HasColumnType("datetime");

                entity.Property(e => e.AssistedTime).HasColumnType("datetime");

                entity.Property(e => e.CompletedLocalTime).HasColumnType("datetime");

                entity.Property(e => e.CompletedTime).HasColumnType("datetime");

                entity.HasOne(d => d.FkAssistType)
                    .WithMany(p => p.LobbyInteractions)
                    .HasForeignKey(d => d.FkAssistTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyInteraction_AssistType");

                entity.HasOne(d => d.FkAssistedByNavigation)
                    .WithMany(p => p.LobbyInteractions)
                    .HasForeignKey(d => d.FkAssistedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyInteraction_AssistedUser");

                entity.HasOne(d => d.FkAssistedUserSessionNavigation)
                    .WithMany(p => p.LobbyInteractions)
                    .HasForeignKey(d => d.FkAssistedUserSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyInteraction_UserSignInSession");

                entity.HasOne(d => d.FkLobbyEntry)
                    .WithMany(p => p.LobbyInteractions)
                    .HasForeignKey(d => d.FkLobbyEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyInteraction_LobbyEntry");
            });

            modelBuilder.Entity<LobbyServiceProvided>(entity =>
            {
                entity.HasKey(e => e.ServiceProvidedId);

                entity.ToTable("LobbyServiceProvided");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvidedTime).HasColumnType("datetime");

                entity.HasOne(d => d.FkLobbyEntry)
                    .WithMany(p => p.LobbyServiceProvideds)
                    .HasForeignKey(d => d.FkLobbyEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyServiceProvided_LobbyEntry");

                entity.HasOne(d => d.FkLobbyInteraction)
                    .WithMany(p => p.LobbyServiceProvideds)
                    .HasForeignKey(d => d.FkLobbyInteractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyServiceProvided_LobbyInteraction");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.LobbyServiceProvideds)
                    .HasForeignKey(d => d.FkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyServiceProvided_Service");
            });

            modelBuilder.Entity<LobbyServiceRequest>(entity =>
            {
                entity.HasKey(e => e.ServiceRequestId);

                entity.ToTable("LobbyServiceRequest");

                entity.HasOne(d => d.FkLobbyEntry)
                    .WithMany(p => p.LobbyServiceRequests)
                    .HasForeignKey(d => d.FkLobbyEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyServiceRequest_LobbyEntry");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.LobbyServiceRequests)
                    .HasForeignKey(d => d.FkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LobbyServiceRequest_Service");
            });

            modelBuilder.Entity<LobbySource>(entity =>
            {
                entity.ToTable("LobbySource");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LobbyStatus>(entity =>
            {
                entity.ToTable("LobbyStatus");

                entity.Property(e => e.LobbyStatusId).ValueGeneratedNever();

                entity.Property(e => e.LobbyStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocalizedField>(entity =>
            {
                entity.ToTable("LocalizedField");

                entity.Property(e => e.LocalizedFieldId).ValueGeneratedNever();

                entity.Property(e => e.LocalizedFieldName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocalizedText>(entity =>
            {
                entity.ToTable("LocalizedText");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.LocalizedTextChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_LocalizedText_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LocalizedTextCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_LocalizedText_CreatedBy");

                entity.HasOne(d => d.FkLanguage)
                    .WithMany(p => p.LocalizedTexts)
                    .HasForeignKey(d => d.FkLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalizedText_Language");

                entity.HasOne(d => d.FkLocalizedField)
                    .WithMany(p => p.LocalizedTexts)
                    .HasForeignKey(d => d.FkLocalizedFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalizedText_LocalizedField");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.HasIndex(e => e.LocationCode, "AK_Location_LocationCode")
                    .IsUnique();

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.AppointmentCutOffDays).HasDefaultValueSql("((90))");

                entity.Property(e => e.AutoAssignFloatPriorityMode)
                    .HasColumnName("AutoAssign_FloatPriorityMode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoWrapupTime)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('23:00:00')");

                entity.Property(e => e.AvailabilityWindowDays).HasDefaultValueSql("((180))");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ffffff')");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DailySummaryEmailTime)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('18:00')");

                entity.Property(e => e.DurationBeforeFirstApptHours)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((24))");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FaxNumber).HasMaxLength(50);

                entity.Property(e => e.FkTimeZoneId).HasDefaultValueSql("((15))");

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.LocationDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.PhoneExtention).HasMaxLength(4);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ReminderBeforeApptEmailHours)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((24))");

                entity.Property(e => e.ReminderBeforeApptSmsHours)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.ShowInWidget)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TimeBeforeBranchCloseForOnlineCheckIn)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('00:30:00')");

                entity.Property(e => e.TimeInAdvanceForOnlineCheckIn)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('02:00:00')");

                entity.Property(e => e.UseAppointments)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.AutoWrapupApptStatusNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.AutoWrapupApptStatus)
                    .HasConstraintName("FK_Location_AppointmentStatus");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.LocationChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Location_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LocationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Location_CreatedBy");

                entity.HasOne(d => d.FkLocationType)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.FkLocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_LocationType");

                entity.HasOne(d => d.FkParentLocation)
                    .WithMany(p => p.InverseFkParentLocation)
                    .HasForeignKey(d => d.FkParentLocationId)
                    .HasConstraintName("FK_Location_ParentLocation");

                entity.HasOne(d => d.FkTimeZone)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.FkTimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_TimeZone");
            });

            modelBuilder.Entity<LocationHierarchy>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("LocationHierarchy");

                entity.Property(e => e.LocationId).ValueGeneratedNever();

                entity.Property(e => e.Hierarchy)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithOne(p => p.LocationHierarchyLocation)
                    .HasForeignKey<LocationHierarchy>(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationHierarchy_Location");

                entity.HasOne(d => d.ParentLocation)
                    .WithMany(p => p.LocationHierarchyParentLocations)
                    .HasForeignKey(d => d.ParentLocationId)
                    .HasConstraintName("FK_LocationHierarchy_ParentLocation");
            });

            modelBuilder.Entity<LocationHoursOfOperation>(entity =>
            {
                entity.ToTable("LocationHoursOfOperation");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OnlineCheckInEnabledForDay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.LocationHoursOfOperationChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_LocationHoursOfOperation_User2");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LocationHoursOfOperationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_LocationHoursOfOperation_User1");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.LocationHoursOfOperations)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationHoursOfOperation_Branch");
            });

            modelBuilder.Entity<LocationService>(entity =>
            {
                entity.HasKey(e => new { e.FkServiceId, e.FkLocationId })
                    .HasName("PK_FkService_FkBranch");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.LocationServices)
                    .HasForeignKey(d => d.FkLocationId)
                    .HasConstraintName("FK_Map_Branch");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.LocationServices)
                    .HasForeignKey(d => d.FkServiceId)
                    .HasConstraintName("FK_Map_Service");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.ToTable("LocationType");

                entity.Property(e => e.LocationTypeId).ValueGeneratedNever();

                entity.Property(e => e.LocalizedKey)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeDisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocationTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lwareason>(entity =>
            {
                entity.ToTable("LWAReason");

                entity.Property(e => e.LwareasonId).HasColumnName("LWAReasonId");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.LwareasonChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_LWAReason_UserChanged");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LwareasonCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_LWAReason_UserCreated");
            });

            modelBuilder.Entity<MessageFormatType>(entity =>
            {
                entity.ToTable("MessageFormatType", "ac");

                entity.Property(e => e.MessageFormatTypeId).ValueGeneratedNever();

                entity.Property(e => e.MessageFormatTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.ToTable("MessageTemplate", "ac");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.MessageSubject)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MessageTemplateBody)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.MessageTemplateChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_MessageTemplate_UserChanged");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MessageTemplateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageTemplate_UserCreated");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.MessageTemplates)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageTemplate_Location");

                entity.HasOne(d => d.FkMessageFormatType)
                    .WithMany(p => p.MessageTemplates)
                    .HasForeignKey(d => d.FkMessageFormatTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageTemplate_MessageFormatType");

                entity.HasOne(d => d.FkMessageType)
                    .WithMany(p => p.MessageTemplates)
                    .HasForeignKey(d => d.FkMessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageTemplate_MessageType");
            });

            modelBuilder.Entity<MessageTemplateConfig>(entity =>
            {
                entity.ToTable("MessageTemplateConfig", "ac");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.ToTable("MessageType", "ac");

                entity.Property(e => e.MessageTypeId).ValueGeneratedNever();

                entity.Property(e => e.MessageTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationMessage>(entity =>
            {
                entity.ToTable("NotificationMessage");

                entity.Property(e => e.AddedTime).HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAttemptTime).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.SentTime).HasColumnType("datetime");

                entity.HasOne(d => d.FkAlertVia)
                    .WithMany(p => p.NotificationMessages)
                    .HasForeignKey(d => d.FkAlertViaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationMessage_AlertVia");

                entity.HasOne(d => d.FkStatus)
                    .WithMany(p => p.NotificationMessages)
                    .HasForeignKey(d => d.FkStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationMessage_NotificationMessageStatus");
            });

            modelBuilder.Entity<NotificationMessageStatus>(entity =>
            {
                entity.ToTable("NotificationMessageStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationMessageTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("NotificationMessageTemplate");

                entity.Property(e => e.TemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("TemplateID");

                entity.Property(e => e.NotifyEvent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendVia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Template).IsRequired();
            });

            modelBuilder.Entity<OngoingTimeStat>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.Entity, e.EntityId, e.Stat });

                entity.ToTable("OngoingTimeStat");

                entity.Property(e => e.Entity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedTime).HasColumnType("datetime");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.GroupbyField1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupbyField2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.PermissionId).ValueGeneratedNever();

                entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PermissionDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.PermissionChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("Fk_Permission_ChangedUser");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PermissionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Permission_CreatedUser");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.HasIndex(e => e.LocalizedRowId, "UQ_ProductCategory_LocalizedRowId")
                    .IsUnique();

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IconName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('menu-icon-0')");

                entity.Property(e => e.ProductCategoryCode).HasMaxLength(50);

                entity.Property(e => e.ProductCategoryDisplayName).HasMaxLength(50);

                entity.Property(e => e.ProductCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<QueueConfiguration>(entity =>
            {
                entity.ToTable("QueueConfiguration");

                entity.Property(e => e.Priority).HasDefaultValueSql("((1))");

                entity.Property(e => e.QueueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WaitOption)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('donotshow')");

                entity.HasOne(d => d.FkLobby)
                    .WithMany(p => p.QueueConfigurations)
                    .HasForeignKey(d => d.FkLobbyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QueueConfiguration_Lobby");
            });

            modelBuilder.Entity<QueueStrategy>(entity =>
            {
                entity.ToTable("QueueStrategy");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Strategy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResourceExceptionType>(entity =>
            {
                entity.ToTable("ResourceExceptionType");

                entity.Property(e => e.ResourceExceptionTypeId).ValueGeneratedNever();

                entity.Property(e => e.ColorCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LocalizedKey)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceExceptionCode).HasMaxLength(5);

                entity.Property(e => e.ResourceExceptionTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ResourceType>(entity =>
            {
                entity.ToTable("ResourceType");

                entity.Property(e => e.ResourceTypeId).ValueGeneratedNever();

                entity.Property(e => e.LocalizedKey).HasMaxLength(800);

                entity.Property(e => e.ResourceTypeDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ResourceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.RoleChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("Fk_Role_ChangedUser");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RoleCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("Fk_Role_CreatedUser");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission");

                entity.Property(e => e.RolePermissionId).ValueGeneratedNever();

                entity.HasOne(d => d.FkPermission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.FkPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_RolePermission_Permission");

                entity.HasOne(d => d.FkRole)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.FkRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_RolePermission_RoleId");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.ToTable("RoleType");

                entity.Property(e => e.RoleTypeId).ValueGeneratedNever();

                entity.Property(e => e.RoleTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.HasIndex(e => e.ServiceCode, "UK_Service_Code")
                    .IsUnique();

                entity.HasIndex(e => e.ServiceName, "UK_Service_ServiceName")
                    .IsUnique();

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddToAllUsers).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChangedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Duration).HasDefaultValueSql("((30))");

                entity.Property(e => e.FkProductCategoryId).HasDefaultValueSql("((1))");

                entity.Property(e => e.FkServiceTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('S_'+CONVERT([nvarchar](40),newid()))");

                entity.Property(e => e.ServiceDescription).HasMaxLength(300);

                entity.Property(e => e.ServiceDisplayName).HasMaxLength(50);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTimeStandard).HasDefaultValueSql("((5))");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.ServiceChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Service_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ServiceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Service_CreatedBy");

                entity.HasOne(d => d.FkProductCategory)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.FkProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Category");

                entity.HasOne(d => d.FkServiceType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.FkServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_ServiceType");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType");

                entity.Property(e => e.ServiceTypeId).ValueGeneratedNever();

                entity.Property(e => e.LocalizedKey)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SourceType>(entity =>
            {
                entity.ToTable("SourceType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId)
                    .HasName("PK_TimeZoneList");

                entity.ToTable("TimeZone");

                entity.Property(e => e.TimeZoneId).ValueGeneratedNever();

                entity.Property(e => e.DaylightName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StandardName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UtcoffsetInMinutes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("UTCOffsetInMinutes");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.PrimaryEmail, "UK_User_PrimaryEmail")
                    .IsUnique();

                entity.HasIndex(e => e.UserCode, "UK_User_UserCode")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UK_User_UserName")
                    .IsUnique();

                entity.Property(e => e.ChangedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalUserId).HasMaxLength(450);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkPreferredLanguageId).HasDefaultValueSql("((1))");

                entity.Property(e => e.FkUserTypeId).HasDefaultValueSql("((3))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.OldAcId).HasColumnName("OldAcID");

                entity.Property(e => e.OldLtid).HasColumnName("OldLTID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.PrimaryEmail)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.SecondaryEmail)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.ShowInKiosk)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowInLobby)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('U_'+CONVERT([nvarchar](40),newid()))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.InverseChangedByNavigation)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_User_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_User_CreatedBy");

                entity.HasOne(d => d.FkDefaultLocation)
                    .WithMany(p => p.UserFkDefaultLocations)
                    .HasForeignKey(d => d.FkDefaultLocationId)
                    .HasConstraintName("FK_User_DefaultBranch");

                entity.HasOne(d => d.FkHomeLocation)
                    .WithMany(p => p.UserFkHomeLocations)
                    .HasForeignKey(d => d.FkHomeLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_HomeLocation");

                entity.HasOne(d => d.FkPreferredLanguage)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkPreferredLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Language");

                entity.HasOne(d => d.FkPreferredTimeZone)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkPreferredTimeZoneId)
                    .HasConstraintName("FK_User_TimeZone");

                entity.HasOne(d => d.FkSupervisor)
                    .WithMany(p => p.InverseFkSupervisor)
                    .HasForeignKey(d => d.FkSupervisorId)
                    .HasConstraintName("FK_User_FkSupervisor");

                entity.HasOne(d => d.FkUserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkUserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserHoursOfOperation>(entity =>
            {
                entity.ToTable("UserHoursOfOperation");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.UserHoursOfOperationChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_UserHoursOfOperation_User3");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserHoursOfOperationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_UserHoursOfOperation_User2");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.UserHoursOfOperationFkUsers)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserHoursOfOperation_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.FkUserId, e.FkRoleId })
                    .HasName("Pk_UserRole");

                entity.ToTable("UserRole");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserRoleCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("Fk_UserRole_CreatedBy");

                entity.HasOne(d => d.FkRole)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.FkRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_UserRole_RoleId");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.UserRoleFkUsers)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_UserRole_UserId");
            });

            modelBuilder.Entity<UserService>(entity =>
            {
                entity.HasKey(e => new { e.FkUserId, e.FkServiceId });

                entity.ToTable("UserService");

                entity.HasIndex(e => e.FkUserId, "IX_UserService_FkUserId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Proficiency).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.UserServiceChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_UserService_ChangedBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserServiceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_UserService_CreatedBy");

                entity.HasOne(d => d.FkService)
                    .WithMany(p => p.UserServices)
                    .HasForeignKey(d => d.FkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserService_Service");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.UserServiceFkUsers)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserService_User");
            });

            modelBuilder.Entity<UserSignIn>(entity =>
            {
                entity.HasKey(e => e.UserSignInSessionId);

                entity.ToTable("UserSignIn");

                entity.Property(e => e.CurrentStatusChangeTime).HasColumnType("datetime");

                entity.Property(e => e.SignInTime).HasColumnType("datetime");

                entity.Property(e => e.SignOutTime).HasColumnType("datetime");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkLobby)
                    .WithMany(p => p.UserSignIns)
                    .HasForeignKey(d => d.FkLobbyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignIn_Lobby");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.UserSignIns)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignIn_Location");

                entity.HasOne(d => d.FkSignInStatus)
                    .WithMany(p => p.UserSignIns)
                    .HasForeignKey(d => d.FkSignInStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignIn_SignInStatus");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.UserSignIns)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignIn_User");
            });

            modelBuilder.Entity<UserSignInHistory>(entity =>
            {
                entity.ToTable("UserSignInHistory");

                entity.Property(e => e.StatusChangeTime).HasColumnType("datetime");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkSignInStatus)
                    .WithMany(p => p.UserSignInHistories)
                    .HasForeignKey(d => d.FkSignInStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignInHistory_SignInStatus");

                entity.HasOne(d => d.FkUserSignInSession)
                    .WithMany(p => p.UserSignInHistories)
                    .HasForeignKey(d => d.FkUserSignInSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSignInHistory_UserSignInSession");
            });

            modelBuilder.Entity<UserSignInStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("UserSignInStatus");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.UserTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserWorkLocation>(entity =>
            {
                entity.ToTable("UserWorkLocation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.UserWorkLocations)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserWorkLocation_Location");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.UserWorkLocations)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserWorkLocation_UserId");
            });

            modelBuilder.Entity<WorkAvailTemplate>(entity =>
            {
                entity.ToTable("WorkAvailTemplate", "ac");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberOfRotations).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.WorkAvailTemplateChangedByNavigations)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_WorkAvail_UserChanged");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WorkAvailTemplateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_WorkAvail_UserCreated");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.WorkAvailTemplates)
                    .HasForeignKey(d => d.FkLocationId)
                    .HasConstraintName("FK_WorkAvailTemplate_Location");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.WorkAvailTemplateFkUsers)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_WorkAvailTemplate_User");
            });

            modelBuilder.Entity<WorkAvailTemplateDay>(entity =>
            {
                entity.ToTable("WorkAvailTemplateDay", "ac");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.WorkAvailTemplateDays)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_WorkAvailTemplateDay_ChangedBy");

                entity.HasOne(d => d.FkWorkAvailTemplate)
                    .WithMany(p => p.WorkAvailTemplateDays)
                    .HasForeignKey(d => d.FkWorkAvailTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkAvailTemplateDay_WorkAvailTemplate");
            });

            modelBuilder.Entity<WorkAvailTemplateTimeRange>(entity =>
            {
                entity.ToTable("WorkAvailTemplateTimeRange", "ac");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.WorkAvailTemplateTimeRanges)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK__WorkAvailTemplateTimeRange__ChangedBy");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.WorkAvailTemplateTimeRanges)
                    .HasForeignKey(d => d.FkLocationId)
                    .HasConstraintName("FK_WorkAvailTemplateTimeRange_Location");

                entity.HasOne(d => d.FkWorkAvailTemplateDay)
                    .WithMany(p => p.WorkAvailTemplateTimeRanges)
                    .HasForeignKey(d => d.FkWorkAvailTemplateDayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkAvailTemplateTimeRange_WorkAvailTemplateDay");
            });

            modelBuilder.Entity<WorkExceptionType>(entity =>
            {
                entity.ToTable("WorkExceptionType");

                entity.Property(e => e.WorkExceptionTypeId).ValueGeneratedNever();

                entity.Property(e => e.ColorCode).HasMaxLength(20);

                entity.Property(e => e.LocalizedKey)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.WorkExceptionCode)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkExceptionTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkScheduleType>(entity =>
            {
                entity.ToTable("WorkScheduleType");

                entity.Property(e => e.WorkScheduleTypeId).ValueGeneratedNever();

                entity.Property(e => e.WorkScheduleTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
