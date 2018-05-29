# Hosting ASP.NET Core 2.0 on Linux using Docker-for-Windows
Simple Asp.Net Core 2.0 Docker App 

## Getting Started
These instructions will get you a copy of the project up and running on linux container uisng docker for windows.

### Prerequisites
- Enable Virtualization from BIOS setting if not enabled, you can check the virtualization is enabled on your machine task manager as shown below.

<a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/1.JPG" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/1.JPG" alt="text" width=500px  height=300px></a>

- Install Hyper V from windows turn on feature, check all the Hyper V, and restart the machine.

<a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/2_HyperV.JPG" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/2_HyperV.JPG" alt="text" width=500px  height=300px></a>

#### Installations:
1) Install the Docker for windows from https://www.docker.com/docker-windows on your Windows 10 machine.

2) Open command Prompt or PowerShell Prompt, and run the docker version command to check whether the docker has been successfully installed on your machine, as shown below

  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/3_docker_version.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/3_docker_version.png" alt="text" width=100%  height=300px></a>
  
  ## Create Asp.Net Core 2 Project
  
#### 1.	Open Visual Studio 2017, File->New->Project

  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/4_VSProject.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/4_VSProject.png" alt="text" width=100%  height=400px></a>
  
#### 2. Click Web API Type, and check the docker and select OS: Linux

 <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/5_ProjectType.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/5_ProjectType.png" alt="text" width=90%  height=400px></a>
 
 #### 3. Click Ok
 
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/5.5_VS.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/5.5_VS.png" alt="text" width=100%  height=300px></a>

 #### 4. Open docker-compose.yml and add port details to run on 8080, 8080 will be map to container port 80, you can set any port.
 
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/6_dockeryml.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/6_dockeryml.png" alt="text" width=100%  height=300px></a>
 
  #### 5. (Optional) Create Home Controller and add the below code, and create the class Info to return the response
  
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/7_ActionResult.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/7_ActionResult.png" alt="text" width=100%  height=300px></a>
    
   #### 6. Open windows/powershell command prompt, and set the current directory to your project directory
       - Run the command doker-compose -f .\docker-compose.ci.build.yml -p netcorebuild run ci-build
       
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/8_Docker_Build.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/8_Docker_Build.png" alt="text" width=100%  height=300px></a>
   
   #### 7. You will get the Error for shared drive, as shown above in the image, To resolve this follow the below steps 
   - Click the arrow on the taskbar screen, then you will see the Docker icon, right click on that, and click settings then select shared drives, then check C drive and click on apply
   
      <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/8_DockerSettings.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/8_DockerSettings.png" alt="text" width=65%  height=400px></a>
      
    
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/9_DockerShareDrive.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/9_DockerShareDrive.png" alt="text" width=75%  height=400px></a>
  
   ### 8. Run the command again doker-compose -f .\docker-compose.ci.build.yml -p netcorebuild run ci-build
   
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/10_DockerBuilkd_Again.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/10_DockerBuilkd_Again.png" alt="text" width=90%  height=200px></a>
  
  ### 9. Run the below command to create the Docker Image
  -  docker-compose -f .\docker-compose.yml -p aspnetcore2docker build
  
  <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/12_Docker_Yml_Build.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/12_Docker_Yml_Build.png" alt="text" width=90%  height=200px></a>
  
  ### 10. Run below command to see the Docker images 
  - docker images

 <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/13_Docker_Images.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/13_Docker_Images.png" alt="text" width=90%  height=200px></a>
  
  ### 11. Run the below command to run the App into the Docker Container
  
  - docker-compose -f .\docker-compose.yml -p aspnetcore2docker up -d
  
   <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/14_Docker_Run.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/14_Docker_Run.png" alt="text" width=90%  height=200px></a>
  
### 12. Run the below command to see the conatiner up and running on port 8080:80 
- docker ps

<a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/13_Docker_Images.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/13_Docker_Images.png" alt="text" width=90%  height=200px></a>
 
 ### 13. Open the browser and access the URL http://localhost:8080/api/home 
 
 <a target="_blank" href="https://github.com/AkbaraliShaikh/AspNetCore2Docker/blob/master/img/15_Browser.png" class="rich-diff-level-one"><img src="https://github.com/AkbaraliShaikh/AspNetCore2Docker/raw/master/img/15_Browser.png" alt="text" width=90%  height=200px></a>
  
##  Happy Coding!
