pipeline {
    agent any

    stages {
        stage('Clonar repo') {
            steps {
                git 'https://github.com/tuusuario/tu-repo.git'
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
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
