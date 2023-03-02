pipeline {
    agent any
    environment { 
        CI = 'true'
    }
     stages {
        stage('Build') {
            steps {
                configFileProvider([configFile(fileId: "b2d93d76-2cfa-4158-a9c7-b1a8c40e2a58", targetLocation: 'ClinicEsteticManagement.API/appsettings.json', variable: 'ENV_CONFIG')]) {
                  
                }
                echo 'Building...'
                sh 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing...'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
                sh ''' 
                    echo "checking for container react-ce-netcoreapi installation and status"
                    if [ $( sudo docker ps -a | grep react-ce-netcoreapi | wc -l ) -gt 0 ] 
                    then   
                        sudo docker stop react-ce-netcoreapi
                        sudo docker rm react-ce-netcoreapi
                    fi
                '''
                echo 'Build dockerfile...'
                sh 'sudo docker buildx build . -f ./ClinicEsteticManagement.API/Dockerfile --tag react-ce-netcoreapi'
                echo 'starting docker container react-ce-netcoreapi'
                sh 'sudo docker run --name react-ce-netcoreapi -d --publish 8200:8200 react-ce-netcoreapi'
            }
        }
    }
}
