# dotnet-openapi-autogen-dockercompose
Simple example of an "API-first" developetment set up: Define your API, and then auto-generate the libraries for your Server or Client using NSwag Studio. 

I'm using Docker compose to run Swagger Editor locally with minimal setup (which will allow us to edit the API file) to service the API specification to the Nswag executable (that gets used by the dotnetcore project via it's MSBuild cycle), but that doesn't have to be part of a larger solution.

# Steps to Run
	- Install Docker: https://hub.docker.com/editions/community/docker-ce-desktop-windows/
	- From the `Docker` folder, run `docker up -d` (via command line), and then open the browser 
		- to `http://localhost:8081/` (to see the editor and the API view side by side) 
		- or `http://localhost:8082` (to see just the API)
	

# Sources:
- Swagger Image: https://github.com/paulito-bandito/swagger-all-in-one-docker-compose
