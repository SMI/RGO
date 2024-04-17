# RGO Install Notes
RGO runs as a web server.
It comes built as a docker image [TODO_ADD_LINK](https://docker.com), or can be [built from source](./DEVELOPER_NOTES.md).

## Requirements
### Compute Resources
RGO is very resource light and will typically require ~512Mb of RAM and a nominal anount of local disk space (This is used to host uploaded files before they are uploaded to the database).

### Database Resources
RGO requires read/write access to a database server to run. Currently, it supports Postgres and Micrcosoft SQL servers (such as SQL express).
The database server is expected to be provided by the installer and does not come prepacked with RGO.
RGO will create the "R-GO" database on the provided server and operate using this generated database.


## Setup
### Postgres
If using a postgres database, the following docker command will run RGO
```
docker run -e "DatabaseType=Postgres" -e "ConnectionStrings:DefaultConnection=Host={SOME_CONNECTION_STRING}; Database=R-GO; Username={Username}; Password={password};" --expose 8080 -p 8080:8080 --expose 8081 -p 8081:8081 rgo:0.0.1
```
This will create the "R-GO" database and expose the web app on post 8080

### Microsoft SQL
If using an SQL database, the following docker command will run RGO
```
docker run -e "DatabaseType=MicrosoftSQL" -e "ConnectionStrings:DefaultConnection=Host={SOME_CONNECTION_STRING}; Database=R-GO; Username={Username}; Password={password};" --expose 8080 -p 8080:8080 --expose 8081 -p 8081:8081 rgo:0.0.1
```
This will create the "R-GO" database and expose the web app on post 8080