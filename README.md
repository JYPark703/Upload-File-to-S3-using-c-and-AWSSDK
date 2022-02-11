# Upload-File-to-S3-using-c-and-AWSSDK

Name: Jin Young Park 

To demonstrate this program, I need to reveal my aws access key, my aws id, and password, so I submit my demo video.

ASW S3 is Blobs and has direct access to the API. And Amazon uses ASWADK to help us use them. I used this to create a program that uploads files to S3 using C#, ASWADK to access the API directly.

===Usage===
1. To access the ASW as an API, you need an access key. Create this key in your ASW account and save it in a text file with the folliwing format:
[default]
aws_access_key_id={Your key id}
aws_secret_access_key={Your secret key}

2. Then modify the App.config:
    <add key="AWSProfilesLocation" value="{your key storage file path}"/>
    <add key="AWSRegion" value="{your s3 region}"/>

3. And also modify the Program.cs:
	static string bucketName = "{Your bucket name}";
        static string folderName = "{Folder name in bucket where you want to save image}";
        static string keyName = "{File name you want to save}";
        static string filePath = @"{The location where you want to save the file}";

4. Running
