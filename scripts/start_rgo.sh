#!/bin/bash
exposeport=8081
# Find out which IP address postgres is using inside the docker bridge network
pgip=$( docker network inspect bridge | jq -r '.[0].Containers[]|.IPv4Address' | sed 's,/.*,,')
docker run --name rgo-app -e "DatabaseType=Postgres" -e "ConnectionStrings:DefaultConnection=Host=${pgip},5433; Database=R-GO; Username=postgres; Password=postgres;" --expose ${exposeport} -p ${exposeport}:8080 taggenblu/rgo:0.0.5
