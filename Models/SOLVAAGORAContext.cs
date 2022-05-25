using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SolvaBlazorBoard.Models
{
    public partial class SOLVAAGORAContext : DbContext
    {
        public SOLVAAGORAContext()
        {
        }

        public SOLVAAGORAContext(DbContextOptions<SOLVAAGORAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAgoraBoardMaster> TblAgoraBoardMasters { get; set; } = null!;
        public virtual DbSet<TblAgoraChatMaster> TblAgoraChatMasters { get; set; } = null!;
        public virtual DbSet<TblAgoraFileMaster> TblAgoraFileMasters { get; set; } = null!;
        public virtual DbSet<TblAgoraNewsMaster> TblAgoraNewsMasters { get; set; } = null!;
        public virtual DbSet<TblAgoraTagMaster> TblAgoraTagMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=121.78.112.116;Initial Catalog=SOLVAAGORA;User ID=solvatech;Password=solva17$$");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAgoraBoardMaster>(entity =>
            {
                entity.ToTable("TBL_AGORA_BOARD_MASTER");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .HasColumnName("TITLE");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .HasColumnName("USER");
            });

            modelBuilder.Entity<TblAgoraChatMaster>(entity =>
            {
                entity.ToTable("TBL_AGORA_CHAT_MASTER");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("CONTENT");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .HasColumnName("USER");
            });

            modelBuilder.Entity<TblAgoraFileMaster>(entity =>
            {
                entity.ToTable("TBL_AGORA_FILE_MASTER");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.BoardFileId)
                    .HasMaxLength(50)
                    .HasColumnName("BOARD_FILE_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("PATH");

                entity.Property(e => e.Size)
                    .HasMaxLength(100)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<TblAgoraNewsMaster>(entity =>
            {
                entity.ToTable("TBL_AGORA_NEWS_MASTER");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .HasColumnName("TITLE");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .HasColumnName("USER");
            });

            modelBuilder.Entity<TblAgoraTagMaster>(entity =>
            {
                entity.ToTable("TBL_AGORA_TAG_MASTER");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.BoardTagId)
                    .HasMaxLength(50)
                    .HasColumnName("BOARD_TAG_ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
