﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.Persistence;

namespace Northwind.Persistence.Migrations
{
    [DbContext(typeof(NorthwindDbContext))]
    partial class NorthwindDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Northwind.Domain.Entities.Calendar", b =>
                {
                    b.Property<int>("CalendarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalendarDate");

                    b.Property<int?>("RoomId");

                    b.HasKey("CalendarId");

                    b.HasIndex("RoomId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("image");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25);

                    b.HasKey("EmployeeId");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeId", "TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasMaxLength(5);

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15);

                    b.Property<int?>("ShipVia");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductID");

                    b.Property<float>("Discount");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Order Details");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20);

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SupplierId")
                        .HasColumnName("SupplierID");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RegionId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Region");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShipperID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupplierID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage")
                        .HasColumnType("ntext");

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Territory", b =>
                {
                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Calendar", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Room", "Room")
                        .WithMany("Calendars")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Employee", "Manager")
                        .WithMany("DirectReports")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.EmployeeTerritory", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeTerritories_Employees");

                    b.HasOne("Northwind.Domain.Entities.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId")
                        .HasConstraintName("FK_EmployeeTerritories_Territories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Order", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("Northwind.Domain.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("Northwind.Domain.Entities.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Orders_Shippers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Order_Details_Orders");

                    b.HasOne("Northwind.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Order_Details_Products");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Product", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("Northwind.Domain.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Products_Suppliers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Territory", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_Territories_Region");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.User", b =>
                {
                    b.OwnsOne("Northwind.Domain.ValueObjects.AdAccount", "AdAccount", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Domain");

                            b1.Property<string>("Name");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.HasOne("Northwind.Domain.Entities.User")
                                .WithOne("AdAccount")
                                .HasForeignKey("Northwind.Domain.ValueObjects.AdAccount", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
