var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.StupiAttendor>("stupiattendor");

builder.Build().Run();
