# Shopping Microservices

[![Build Status](https://dev.azure.com/mabt2206/shopping/_apis/build/status%2Fshoppingclient-pipeline?branchName=main)](https://dev.azure.com/mabt2206/shopping/_build/latest?definitionId=4&branchName=main)

[![Build Status](https://dev.azure.com/mabt2206/shopping/_apis/build/status%2Fshoppingapi-pipeline?branchName=main)](https://dev.azure.com/mabt2206/shopping/_build/latest?definitionId=3&branchName=main)

A simple microservices-based shopping application built with .NET 9, demonstrating containerization and Kubernetes deployment patterns.

## 🏗️ Architecture

- **Shopping.API**: RESTful API service for product management using MongoDB
- **Shopping.Client**: MVC web application for product display
- **MongoDB**: NoSQL database for product storage

## 🚀 Quick Start

### Local Development (Docker)

```bash
# Clone the repository
git clone https://github.com/your-username/shopping-microservices.git
cd shopping-microservices

# Run with Docker Compose
docker-compose up -d
```

**Access the application:**
- Web App: http://localhost:8001
- API Swagger: http://localhost:8000/swagger

### Kubernetes Deployment

```bash
# Deploy to local Kubernetes
kubectl apply -f k8s/

# Deploy to Azure Kubernetes Service (AKS)
kubectl apply -f aks/
```

## 🛠️ Technologies

- **.NET 9** - Latest .NET framework
- **ASP.NET Core** - Web framework
- **MongoDB** - NoSQL database
- **Docker** - Containerization
- **Kubernetes** - Container orchestration
- **Azure DevOps** - CI/CD pipelines
- **Azure Container Registry** - Container registry

## 📦 Project Structure

```
Shopping/
├── Shopping.API/          # Product API service
├── Shopping.Client/       # MVC web application
├── docker-compose.yaml    # Local development setup
aks/                       # Azure Kubernetes manifests
k8s/                       # Local Kubernetes manifests
pipelines/                 # Azure DevOps pipelines
```

## 🔧 Configuration

The application uses environment-specific configurations:

- **Development**: Uses local MongoDB connection
- **Production**: Configured for Azure/cloud deployment

## 📝 API Endpoints

- `GET /product` - Retrieve all products

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Author**: Miguel Barreto  
**Year**: 2025
