﻿using System.Threading.Tasks;
using Microsoft.Identity.Client;

const string _clientId = "APPLICATION_CLIENT_ID";
const string _tenantId = "DIRECTORY_TENANT_ID";

var app = PublicClientApplicationBuilder
    .Create(_clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
    .WithRedirectUri("http://localhost")
    .Build();

string[] scopes = { "user.read" };


AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

Console.WriteLine($"Token:\t{result.AccessToken}");