pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet-sdk'
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Check NuGet Sources') {
            steps {
                script {
                    bat 'dotnet nuget list source'
                }
            }
        }
        stage('Configure NuGet Source') {
            steps {
                script {
                    bat 'dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org'
                }
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
        stage('List Test Results') {
            steps {
                script {
                    bat 'dir MyConsoleApp.Tests/TestResults'
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
            junit '**/MyConsoleApp.Tests/TestResults/test_results.trx'
        }
    }
}



 
