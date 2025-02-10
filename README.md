# dotnet-graphql

## Prerequisites
Download the `Contoso.bak` file from [here](https://www.microsoft.com/en-ca/download/details.aspx?id=18279) and place at the root of the repository.

## Getting started

Build and run the docker container using the following commands.
```
docker-compose -f .\docker-compose.yaml build
docker-compose -f .\docker-compose.yaml up
```
This will restore the database to sql server running at `localhost,1433`

## Running queries
Go to `/graphql`

### All products
```
query {
  dimProducts {
    productLabel,
    productName
  }
}
```

### By Id
```
query {
  dimProductBySubCat(subCat: {subCategory}) {
    productLabel,
    productName
  }
}
```

### By subcategory
```
query {
  dimProductById(id: {id}) {
    productLabel,
    productName
  }
}
```
