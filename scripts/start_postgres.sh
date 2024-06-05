#!/bin/bash
echo "Starting postgres, use stop_postgres.sh to stop it"
pgdatadir="$(pwd)/pgdata"
echo "Storing postgres database in $pgdatadir"
mkdir -p "$pgdatadir"

# To expose the port as 5433:
#  -p 5433:5432 
# To use an external volume:
#  -e PGDATA=/var/lib/postgresql/data/pgdata \
#  -v /home/abrooks/src/RGO/pgdata:/var/lib/postgresql/data \

sudo docker run -d --name postgres-rgo \
    -e POSTGRES_PASSWORD=mysecretpassword \
    -e PGDATA=/var/lib/postgresql/data/pgdata \
    -v "$pgdatadir":/var/lib/postgresql/data \
    postgres
