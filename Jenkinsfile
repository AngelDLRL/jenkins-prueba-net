pipeline {
    agent any

    stages {
        stage('Clonar repo') {
            steps {
                git branch: 'main', url: 'https://github.com/AngelDLRL/jenkins-prueba-net'
            }
        }

        stage('Restaurar dependencias') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Compilar') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Ejecutar pruebas') {
            steps {
                sh 'dotnet test ./AppPrincipal.Tests/AppPrincipal.Tests.csproj'
            }
        }
    }
}
