﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using slovar;

namespace slovar.Migrations
{
    [DbContext(typeof(DictionaryEntryContext))]
    partial class DictionaryEntryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("slovar.DictionaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Definition");

                    b.Property<string>("Lemma");

                    b.Property<int?>("StressIndex");

                    b.Property<string>("Translation");

                    b.HasKey("Id");

                    b.ToTable("DictionaryEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
