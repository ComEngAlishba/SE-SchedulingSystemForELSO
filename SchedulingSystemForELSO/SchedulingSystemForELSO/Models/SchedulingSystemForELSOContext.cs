using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchedulingSystemForELSO.Models
{
    public partial class SchedulingSystemForELSOContext : DbContext
    {
        public SchedulingSystemForELSOContext()
        {
        }

        public SchedulingSystemForELSOContext(DbContextOptions<SchedulingSystemForELSOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTable { get; set; }
        public virtual DbSet<BookMeetingTable> BookMeetingTable { get; set; }
        public virtual DbSet<LoginTable> LoginTable { get; set; }
        public virtual DbSet<NotificationTable> NotificationTable { get; set; }
        public virtual DbSet<RegisterTable> RegisterTable { get; set; }
        public virtual DbSet<RescheduleDeleteTable> RescheduleDeleteTable { get; set; }
        public virtual DbSet<TeacherTable> TeacherTable { get; set; }
        public virtual DbSet<TimeSlotsTable> TimeSlotsTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JHGIJIU\\SQLEXPRESS;Initial Catalog=SchedulingSystemForELSO;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.ToTable("Admin_Table");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName).HasColumnName("Full_Name");
            });

            modelBuilder.Entity<BookMeetingTable>(entity =>
            {
                entity.ToTable("Book_Meeting_Table");

                entity.Property(e => e.MeetingId).HasColumnName("Meeting_Id");

                entity.Property(e => e.StudentEmail).HasColumnName("Student_Email");

                entity.Property(e => e.StudentRegisteration).HasColumnName("Student_Registeration");

                entity.Property(e => e.StudentUsername).HasColumnName("Student_Username");
            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.ToTable("Login_Table");

                entity.Property(e => e.UserChoice)
                    .HasColumnName("User_Choice")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationTable>(entity =>
            {
                entity.ToTable("Notification_Table");

                entity.Property(e => e.CurrentDate)
                    .HasColumnName("Current_Date")
                    .HasMaxLength(50);

                entity.Property(e => e.NotiMessage).HasColumnName("Noti_Message");
            });

            modelBuilder.Entity<RegisterTable>(entity =>
            {
                entity.ToTable("Register_Table");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.DepName).HasColumnName("Dep_Name");

                entity.Property(e => e.FullName).HasColumnName("Full_Name");

                entity.Property(e => e.RegNo).HasColumnName("Reg_No");

                entity.Property(e => e.UserChoice).HasColumnName("User_Choice");
            });

            modelBuilder.Entity<RescheduleDeleteTable>(entity =>
            {
                entity.ToTable("Reschedule_Delete_Table");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingId).HasColumnName("Meeting_Id");

                entity.Property(e => e.MeetingTopic).HasColumnName("Meeting_Topic");

                entity.Property(e => e.RescheduleDeleteChoice)
                    .HasColumnName("Reschedule_Delete_Choice")
                    .HasMaxLength(50);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeacherUsername).HasColumnName("Teacher_Username");
            });

            modelBuilder.Entity<TeacherTable>(entity =>
            {
                entity.ToTable("Teacher_Table");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName).HasColumnName("Full_Name");
            });

            modelBuilder.Entity<TimeSlotsTable>(entity =>
            {
                entity.ToTable("Time_Slots_Table");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingTopic).HasColumnName("Meeting_Topic");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeacherUsername).HasColumnName("Teacher_Username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
