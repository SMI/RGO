## Building the docker image
From the root of this project run the comand 
```
docker image build . --tag rgo:0.0.1
```
This will build the rgo:0.0.1 docker image

You can run it with the following command to run the image and expose it on port 8080
```
docker run -e "DatabaseType=Postgres" -e "ConnectionStrings:DefaultConnection=Host=host.docker.internal:5432; Database=R-GO; Username=postgres; Password=postgres;" --expose 8080 -p 8080:8080 rgo:0.0.1
```

