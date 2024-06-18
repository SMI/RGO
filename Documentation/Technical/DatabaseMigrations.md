## Database Migrations
Database migrations for RGO follow the standard Entity Framework process, with some slight modifications to allow for the various database types it supports.

To begin, create a new migration using the nuget manager console
```
> Add-migration <My_Migration_Name>
```
This will create an empty migration file, add your updates here. See existing migrations in RGO.DataAccess for examples.
With the migration file, a designer file is created.
This designer file is created for an SQL environment, as such, we need to replace the type strings it generates with FansiSQL variants.
Again, these can be seen within existing migration designer files.
e.g. "nvarchar(max)" becomes "dbTranslator.GetStringDataTypeWithUnlimitedWidth()"

This will allow you to run your migrations on both sql and postgres databases with the command 
```
> upate-database
```
within the nuget manager console