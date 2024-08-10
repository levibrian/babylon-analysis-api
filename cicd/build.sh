#!/bin/bash
echo "building and composing babylon analysis api"

cd ../src/Babylon.Analysis/ || exit

docker build -f Babylon.Analysis.Api/Dockerfile -t babylon-analysis-api .

cd ../../cicd || exit