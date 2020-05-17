# BukSub

BukSub is a place where you can purchase a subscription to number of books.
BukSub offers book subscription API where 3rd party resellers can subscribe clients to books.

# Workflow

* Determine objectives and design goals (Done)
* Design API
  * Entities
  * Operations
* Implement API, unit test at controller/action level
* Research Angular and implement Web UI
* Research and implement secure login
* [Opt.] Choose and implement data backend
* [Opt.] Deploy to cloud (azure)
* [Opt.] Measure performance of public API
* [Opt.] Measure performance of Web UI
* [Opt.] Determine and possibly tune components to meet non-functional objectives

# Design Objectis

* Easy 3rd party integrations
  * API-first design
* Web client for users to manage their subscriptions

# Non-functional Objectis [Opt.]

* API response time (excl. network latency): <= 50ms @ 95th percentile
* API troughput: 500 req/s
  * Approximately 35% small read, 25% medium read, 25% write, 15% search/cpu
* Web UI Load time on Regular 4G/LTE <= 3000ms 
* Web UI Interations <= 100 ms

## Cloud Resources

I want to run tests on Standard_A1_v2 and/or Standard_A2_v2 to see how much can be squeezed from small servers.
 
# API Design

## Entities

### User Entity

Fields:
* Email address - email address of user, also used as login name, string 250
* Last Name, string 250
* First Name, string 250

### Book Entity

Fields:
* Name - Title of the book, string 250
* Text - Complete text of the book, string long
* Purchase Price - Price of the book in EUR, double

### User-Book Subscription Aggregate

Conceptual subscription, links Book to User

## Operations

CRUD Books
CRUD Users
CRUD User-Book Subscriptions

# Implementation Notes

* [NSwag Toolchain](https://github.com/RicoSuter/NSwag)
* [MSDN Getting Started with NSwag and asp.net core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [AspNetCore Middleware](https://github.com/RicoSuter/NSwag/wiki/AspNetCore-Middleware)
* [Azure SQL Server DTUs and Tiers](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-service-tiers-dtu)
* [Azure VM Av2-series](https://docs.microsoft.com/en-us/azure/virtual-machines/av2-series)
* [Azure AD](https://azure.microsoft.com/en-us/services/active-directory/integrate/)
* [Scaffold Identiy in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio)
* [Angular SPA on .net core](https://go.microsoft.com/fwlink/?linkid=864501)
* [Controller action return types in ASP.NET Core web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1)
* [Alternative Identity Storage?](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-custom-storage-providers?view=aspnetcore-3.1)
