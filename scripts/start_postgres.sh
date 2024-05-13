#run postgres exposing it on port 5433 so no clash with system postgres
docker run --name postgres-rgo -e POSTGRES_PASSWORD=postgres -d -p 5433:5432 postgres

