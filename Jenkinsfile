pipeline {
    agent any
    environment { 
        CI = 'true'
    }
     stages {
        stage('Build') {
            steps {
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
                    if [ $( sudo docker ps -a | grep react-ce | wc -l ) -gt 0 ] 
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
