#!/bin/bash

exposeport=8081

pgip=$(sudo docker network inspect bridge | jq -r '.[0].Containers[]|.IPv4Address' | sed 's,/.*,,')
echo "Postgres IP address: $pgip"

echo "Starting RGO, use Ctrl-C to stop"
sudo docker run --name rgo-app -e "DatabaseType=Postgres" -e "ConnectionStrings:DefaultConnection=Host=${pgip}:5432; Database=R-GO; Username=postgres; Password=mysecretpassword;" --expose ${exposeport} -p ${exposeport}:8080 taggenblu/rgo:0.0.5
