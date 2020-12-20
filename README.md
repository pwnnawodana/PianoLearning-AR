# Piano Learning Sample AR Prototype

##### Introduction
This porject directed to bring the Augmented reality to gamification field. Simple idea for this project is about use simple augmented reality android application to teach and learn piano instrument.
Basically this prototype can move into whatever possible instrument type by simple modification to the project.For this project use 3D piano assets and virtually project this piano into a predefined image target via android mobile device. 

##### Developement background
To develop this application, used 
- unity [2019(.4.13f1) LTS](https://unity.com/releases/2019-lts "Unity 2019 LTS download page") and 
- for developing AR foundation used vuforia [engine (9.6)](https://developer.vuforia.com/downloads/sdk "Vuforia SDK download page").

##### what is [unity](https://unity.com "Unity Official Web Page")
>>Unity’s real-time 3D development platform lets artists, designers and developers work together to create amazing immersive and interactive experiences. 
(Available for Windows, Mac, and Linux.) Also, it is the world’s leading platform for creating and operating interactive, real-time 3D content,providing the tools to make amazing games and publish them to a wide range of devices.The Unity core platform enables entire creative teams to be more productive together. 

##### what is [vuforia] (https://developer.vuforia.com "Vuforia Offcial Web Page")
>> Vuforia is an augmented reality software development kit for mobile devices that enables the creation of augmented reality applications. It uses computer vision technology to recognize and track planar images and 3D objects in real time.

##### Setup vuforia sdk for this project on unity 2019 LTS
1. First go to the viforia [registration page] (https://developer.vuforia.com/vui/auth/register "Registration page") and register in it then verify the account.
2. After that go to the [developer page](https://developer.vuforia.com/license-manager "developer page") to get a license key
>>Keep in mind, upto 2020 according to their terms, you can use vuforia for free, but under the free license it includes vuforia watermark in every project you use it. 
3. Then copy the license and move in to the unity empty project( fresh project )
4. Go to the windows --> package manager in unity then search for vuforia latest sdk then install it in your project.
>> or you can download it via vuforia [downlod page](https://developer.vuforia.com/downloads "Vuforia download page") and then import it. 
>> But when developing it, I faced a problem when do it. Problem is without any problem you can import the package to the project. But when if you want to remove that package and import another version of it, you cannot find any vuforia package via unity package manager. this is not affect to the development in any case but just in case when search that vuforia in unity package manage, you cannot see it for now.
5. After installing the package go to windows vuforia configuration. it opens a  menu in inspector.
6. Now enter your vuforia license key in the app lincese key field in the inspector. then voforia sdk ready to go.
7. Again back to the vuforia web page and go the the [target manager](https://developer.vuforia.com/vui/develop/databases "Vuforia taget manager") in the developer page.
8. Click "Add database" and then give a name to the database after that select the type of the database you want to use then select create.
>> for this I used "device".
9. Then click your database and select "add target manager" to add a target for project the assets. 
10. Now select the target type you want then select the image file then set a width and a name of the target as well.
>> For this I used - image as a target - for the target used a mobile captured image - for the width set it as 5 too.
>> Keep in mind when selecting a image target use very trackable image target. such as a mouse pad (which has a image on it) and crop the unnessary areas of the image and in that image keep only the target(mouse pad).
11. After finishing the image target select "download database"
12. then import that package in to unity.
13. Select the image traget object in unity heararchy and in inspector under the Image target behavior script select  your imported database and select the image target under it.

14. ##### most important
>> Have a fun with your own development :)

Good luck.
Nimesh Nawodana
[Linkedin](https://www.linkedin.com/in/pwnnawodana/ "Linkedin profile web link")
