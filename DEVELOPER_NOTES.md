## Building the docker image
From the root of this project
```
docker image build . --tag rgo:0.0.1
```
```
docker run -e "DatabaseType=Postgres" -e "ConnectionStrings:DefaultConnection=Host=host.docker.internal:5432; Database=R-GO; Username=postgres; Password=postgres;" --expose 8080 -p 8080:8080 --expose 8081 -p 8081:8081 rgo:0.0.1
```