﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebLongChau.Data;

#nullable disable

namespace WebLongChau.Migrations
{
    [DbContext(typeof(LongChauWebContext))]
    partial class LongChauWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebLongChau.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("AdminID");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly?>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte?>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FisrtName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .HasColumnType("int")
                        .HasColumnName("ImageID");

                    b.Property<string>("ImageName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("CutomerId")
                        .HasColumnType("int")
                        .HasColumnName("CutomerID");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentMethodID");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("totalPrice");

                    b.HasKey("OrderId");

                    b.HasIndex("CutomerId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("Quanity")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentMethodID");

                    b.Property<string>("PaymentMethodType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductIamge")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("SupplierID");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("WebLongChau.Models.Image", b =>
                {
                    b.HasOne("WebLongChau.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Image_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebLongChau.Models.Order", b =>
                {
                    b.HasOne("WebLongChau.Models.Customer", "Cutomer")
                        .WithMany("Orders")
                        .HasForeignKey("CutomerId")
                        .HasConstraintName("FK_Order_Customer");

                    b.HasOne("WebLongChau.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentMethodId")
                        .HasConstraintName("FK_Order_PaymentMethod");

                    b.Navigation("Cutomer");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("WebLongChau.Models.OrderDetail", b =>
                {
                    b.HasOne("WebLongChau.Models.Order", "Order")
                        .WithOne("OrderDetail")
                        .HasForeignKey("WebLongChau.Models.OrderDetail", "OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetail_Order");

                    b.HasOne("WebLongChau.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDetail_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebLongChau.Models.Product", b =>
                {
                    b.HasOne("WebLongChau.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_Category");

                    b.HasOne("WebLongChau.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Product_Supplier");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("WebLongChau.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebLongChau.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebLongChau.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("WebLongChau.Models.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebLongChau.Models.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WebLongChau.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
