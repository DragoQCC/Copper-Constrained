# Copper Constrained
![image](https://user-images.githubusercontent.com/15575425/158693889-06c8a5dd-5fcc-4bb4-848f-08c98f9b9e29.png)  
Copper Constrained serves as a CLM bypass to get around protections put in place to damper PowerShell command execution. This is automatically put in place when AppLocker is enabled or could be enabled as a standalone feature on a target. 


## usage
execute the exe and then input commands it will be ran in an unmanaged state and will be in full language. 

Going too add instructions for a Applocker bypass that uses this with lolbas files such as msbuild.  

## Compile?
load into vs , set build ot relase and arch to x64 and build. 

## In memory?
Well, PowerShell being locked and unable to download and load this in memory would make that a challenge. I will add directions on how to use this with a lolbas like msbuild to load it from a csproj/xml file and to also have the code be downloaded in memory and only need a boilerplate for msbuild on disk.  

## what is CLM?
Constrained Language Mode is a PowerShell v5 feature that is enabled when applocker or WDAC is enabled and can be a standalone feature turned on by a system administrator. This limits a user to only core PowerShell types, and that's no fun if you are an attacker. This small project serves as just another showcase of the ease of bypassing this protection technique.  

## Disclaimer 
I am not responsible for actions taken by users of Copper Constrained. Copper Constrained was released solely for educational and ethical purposes.  
