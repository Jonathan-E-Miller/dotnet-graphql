﻿using Repository;
using Repository.Models;

namespace GraphQL.Queries;

public class Query
{   
    public IEnumerable<DimProduct> DimProducts([Service]ContosoDbContext context) => context.DimProducts;

    public DimProduct? GetDimProductById(int id, [Service] ContosoDbContext context) =>
        context.DimProducts.FirstOrDefault(product => product.ProductKey == id);

    public IEnumerable<DimProduct> GetDimProductBySubCat(int subCat, [Service] ContosoDbContext context) =>
        context.DimProducts.Where(x => x.ProductSubcategoryKey == subCat);
}
