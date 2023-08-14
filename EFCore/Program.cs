using EFCore;

Northwind db = new();
WriteLine($"Provider: {db.Database.ProviderName}");