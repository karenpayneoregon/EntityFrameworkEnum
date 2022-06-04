# TechNet article
Entity Framework database/Code First Enum support

https://social.technet.microsoft.com/wiki/contents/articles/53169.entity-framework-databasecode-first-enum-support.aspx

**See also**

[Windows forms Entity Framework Code first from database](https://social.technet.microsoft.com/wiki/contents/articles/53154.windows-forms-entity-framework-code-first-from-database.aspx)

# EF Core Value Conversions

See the following [repository](https://github.com/karenpayneoregon/ef-core-transforming) for working with `enum` and more.

Example, `BookCatgory` is an `enum`

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


    modelBuilder
        .Entity<Book>()
        .Property(e => e.BookCategory)
        .HasConversion<int>();

    modelBuilder
        .Entity<BookVariant>().HasData(
            Enum.GetValues(typeof(BookCategory))
                .Cast<BookCategory>()
                .Select(e => new BookVariant()
                {
                    BookCategoryId = e,
                    Name = e.ToString()
                })
        );
}
```

**Sample query**

```csharp
var list = bookList.Where(books => books.BookCategory == BookCategory.Adventure).ToList();
```