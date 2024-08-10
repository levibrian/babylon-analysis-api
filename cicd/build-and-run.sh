#!/bin/bash
echo "building and composing babylon analysis api"

cd ../src/Babylon.Analysis/ || exit

docker build -f Babylon.Analysis.Api/Dockerfile -t babylon-analysis-api .

cd ../../cicd || exit

echo "composing babylon analysis api"

docker-compose -f docker-compose.yml up