﻿using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(book => book.BookId);
            builder.Property(book => book.Title)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(128);
            builder.HasIndex(book => book.Title)
                   .IsUnique();
            builder.Property(book => book.PublishedYear)
                   .IsRequired()
                   .HasColumnType("char")
                   .HasMaxLength(4);
            builder.Property(book => book.Publisher)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(64);
            builder.Property(book => book.Authors)
                   .IsRequired();
            builder.Property(book => book.Category)
                   .IsRequired()
                   .HasColumnType("tinyint");
        }
    }
}
