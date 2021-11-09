# Clear builder cache
docker builder prune -a

# Stop all containers
docker stop `docker ps -qa`

# Remove all containers
docker rm `docker ps -qa`

# Remove all images
docker rmi -f `docker images -qa`

# Remove all volumes
docker volume rm $(docker volume ls -qf dangling="true")

# Remove all networks
docker network rm `docker network ls -q` --filter type=custom

# Your installation should now be all fresh and clean.

# The following commands should not output any items:
# docker ps -a
# docker images -a 
# docker volume ls

# The following command show only show the default networks:
# docker network ls
