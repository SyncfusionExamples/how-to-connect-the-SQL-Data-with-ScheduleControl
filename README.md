# How to connect the SQL Data with ScheduleControl
This repository contains a concise C# example that demonstrates connecting SQL data sources to a ScheduleControl component and binding schedule items from local database files.

## Project Overview
This project is a small Windows Forms example that shows how to read schedule records from local SQL databases and display them in a ScheduleControl. Source files such as `Active.cs`, `Dashboard.cs`, and `SampleDataProvider.cs` provide the sample UI and data binding logic. Sample database files (`ScheduleData.mdf`, `Database1.sdf`) and an `app.config` are included to illustrate configuration and connection strings.

## Features
- Demonstrates data binding from SQL databases to a ScheduleControl UI component.
- Includes sample provider code and local database files for offline testing.
- Shows simple configuration via `app.config`.

## Prerequisites
- Visual Studio (solutions for 2015 and 2017 are provided: SFCDB_2015.sln, SFCDB_2017.sln).
- .NET Framework compatible with the provided projects.
- LocalDB / SQL Server Compact installation as needed to open the included `.mdf` or `.sdf` files.

## Installation and Usage
1. Open the appropriate solution (`SFCDB_2015.sln` or `SFCDB_2017.sln`) in Visual Studio.
2. Review and, if necessary, update the connection strings in `app.config` to match your local SQL environment.
3. Build the solution and run the `Dashboard` or `Active` sample to view schedule data populated from the included databases.

## Configuration
Edit the `connectionStrings` section in `app.config` to point at your LocalDB or SQL Compact file paths. The sample projects read from the included `ScheduleData.mdf`/`Database1.sdf` by default.

## Support & Contribution
Issues and improvements can be proposed by opening an issue or submitting a pull request. Keep changes focused on examples and documentation.

## Troubleshooting
- If schedules do not appear, verify the connection string and database file paths.
- Ensure the required local SQL runtimes are installed and the solution is built for the correct .NET target.

---