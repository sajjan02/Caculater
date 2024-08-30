pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet-sdk'  // Use the name you gave the .NET SDK in Global Tool Configuration
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Restore') {
            steps {
                script {
                    bat 'dotnet restore MyConsoleApp/MyConsoleApp.csproj'
                }
            }
        }
        stage('Build') {
            steps {
                script {
                    bat 'dotnet build MyConsoleApp/MyConsoleApp.csproj'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    bat 'dotnet test MyConsoleApp.Tests/MyConsoleApp.Tests.csproj --logger "trx;LogFileName=test_results.trx"'
                }
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying application...'
                // Deployment steps go here
            }
        }
    }

    post {
        always {
            junit '**/TestResults/test_results.trx'  // Ensure this path is correct
        }
    }
}

 
