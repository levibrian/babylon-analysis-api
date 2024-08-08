echo "running babylon analysis api container"

docker build -f Babylon.Analysis.Api/Dockerfile -t babylon-analysis-api .

docker run --rm -it -p 2550:80 babylon-analysis-api