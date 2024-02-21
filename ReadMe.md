# TProfile Code Assessment

This is designed to be a simple assessment to establish your skill level and coding style. The aim is to create a file upload component in Vue that allows for the upload of an image to an Azure blob storage account and for it then to then be displayed in the page.

The plugins and site have all been configured and tested so you should only need to alter the existing files to help speed up the assessment. 

**Front End Plugins**
 - [Vue.js (2.6.11)](https://v2.vuejs.org/)
 - [ElementUI  - Upload Component](https://element.eleme.io/#/en-US/component/upload#upload)
 - [VeeValidate](https://vee-validate.logaretm.com/v2/)
 - [Axios (0.18.0)](https://github.com/axios/axios)

## Vue Test
Build out the existing component located in `\wwwroot\js\vue-components\file-uploader.js` you can choose to use the [ElementUI](https://element.eleme.io/#/en-US/component/upload#upload) upload component above or the native html file upload.

**Requirements**
 - Restrict to images
 - Max file size is 2MB

## Code Test
Add a controller to handle the file upload request. Create a service based on the `IFileUploadService` interface and implement the logic to upload to the container `dev-test-files` in Azure Storage. The storage account has been created specifically for this test so don't worry about deleting anything here.
**Requirements**
File must check for name conflicts when uploading and 


