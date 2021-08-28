﻿// <auto-generated />
using Bar.Models.E;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210823162952_Initial_with_Value")]
    partial class Initial_with_Value
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bar.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Bar.Models.Cocktail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("Bar.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Degrees")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Bar.Models.Ingredient_Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Ingredient_Values");
                });

            modelBuilder.Entity("CocktailIngredient_Value", b =>
                {
                    b.Property<int>("CocktailsId")
                        .HasColumnType("int");

                    b.Property<int>("Ingredient_ValuesId")
                        .HasColumnType("int");

                    b.HasKey("CocktailsId", "Ingredient_ValuesId");

                    b.HasIndex("Ingredient_ValuesId");

                    b.ToTable("CocktailIngredient_Value");
                });

            modelBuilder.Entity("Bar.Models.Cocktail", b =>
                {
                    b.HasOne("Bar.Models.Category", "Category")
                        .WithMany("Cocktails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bar.Models.Ingredient_Value", b =>
                {
                    b.HasOne("Bar.Models.Ingredient", "Ingredient")
                        .WithMany("Ingredient_Values")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("CocktailIngredient_Value", b =>
                {
                    b.HasOne("Bar.Models.Cocktail", null)
                        .WithMany()
                        .HasForeignKey("CocktailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar.Models.Ingredient_Value", null)
                        .WithMany()
                        .HasForeignKey("Ingredient_ValuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar.Models.Category", b =>
                {
                    b.Navigation("Cocktails");
                });

            modelBuilder.Entity("Bar.Models.Ingredient", b =>
                {
                    b.Navigation("Ingredient_Values");
                });
#pragma warning restore 612, 618
        }
    }
}
