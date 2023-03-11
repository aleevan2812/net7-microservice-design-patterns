﻿global using EventSourcing.API.BackgroundServices;
global using EventSourcing.API.Command.ChangeProductName;
global using EventSourcing.API.Command.ChangeProductPrice;
global using EventSourcing.API.Command.CreateProduct;
global using EventSourcing.API.Command.DeleteProduct;
global using EventSourcing.API.Infrastructure;
global using EventSourcing.API.Models;
global using EventSourcing.API.Queries;
global using EventSourcing.API.Store;
global using EventSourcing.Shared.Events;
global using EventStore.ClientAPI;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using System.Text;
global using System.Text.Json;
