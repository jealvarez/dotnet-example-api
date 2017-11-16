# **ASP.NET Core API**

Example of how to build an API based on ASP.NET Core

## **Prerequisites**

* Java 8
* MySQL 5.7.15
* [Flyway Command-line](https://flywaydb.org/getstarted/firststeps/commandline)
* [ASP.NET Core](https://www.microsoft.com/net/core)

# **Database Migrations**

To execute SQL Scripts, it was used [Flyway](https://flywaydb.org/)

## **Properties**

The properties and its default values are the following: 

```
flyway.driver=com.mysql.jdbc.Driver
flyway.url=jdbc:mysql://127.0.0.1:3306
flyway.user=root
flyway.password=r00t
flyway.schemas=example
flyway.locations=filesystem:../Sql
flyway.encoding=UTF-8
flyway.baselineOnMigrate=true
```

**Note.** The above properties can be overwritten. To overwrite just go to  ```Migrations/Configuration/flyway.conf``` and change the properties with the values that you want. 

## **Migrating**

```sh
$ cd Migrations/Commands/
$ sh migrate.sh
```

## **Application Configuration**

In the file `appsettings.json` set your own database connection configuration under the tag `DatabaseConfiguration`
 
# **Execution**

On the main directory where is located the ```project.json``` follow the nexts steps:

1. To build
```sh
$ dotnet build
```

2. To run
```sh
$ dotnet run
```

3. Finally, [test it here!!](http://127.0.0.1:5000)