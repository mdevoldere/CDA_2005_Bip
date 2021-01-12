﻿// <auto-generated />
using LiteChatWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LiteChatWebsite.Migrations
{
    [DbContext(typeof(LiteChatContext))]
    [Migration("20210112095153_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("LiteChatWebsite.Models.RoleModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id")
                        .UseIdentityColumn();

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("role_type");

                    b.HasKey("ID");

                    b.ToTable("t_roles");
                });

            modelBuilder.Entity("LiteChatWebsite.Models.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id")
                        .UseIdentityColumn();

                    b.Property<int>("RoleModelID")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("user_name");

                    b.Property<string>("UserPassWord")
                        .IsRequired()
                        .HasColumnType("char(72)")
                        .HasColumnName("user_password");

                    b.HasKey("ID");

                    b.HasIndex("RoleModelID");

                    b.ToTable("t_users");
                });

            modelBuilder.Entity("LiteChatWebsite.Models.UserModel", b =>
                {
                    b.HasOne("LiteChatWebsite.Models.RoleModel", "RoleModel")
                        .WithMany()
                        .HasForeignKey("RoleModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
