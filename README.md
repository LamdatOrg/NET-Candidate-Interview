# NET-Candidate-Test

Hi

Below is an exercise to examine your knowledge in c#, zip your code and send it to aharon.mizrahi@lamdat.com.

Azure DevOps is a development work system, it enables dev teams to work together on requirements, developing code, testing and DevOps tasks. 

The code in this repository is partiality ready and should export workitems (entities) data from Azure DevOps API, do some processing and export the items into a comma delimited file.

The expected output file result should be like this:

ID,                            URL                                                                                                                                     , Length
938125 https://../SyncNowCollection/Lamdat-Unified/_workitems/938125                               	  xxxx	
938126 https://../SyncNowCollection/Lamdat-Unified/_workitems/938126                                        yyy

Check all TODO remarks in the code and fill in the missing code

1.	Add the configuration details token in common->consts file

2.	Add code to fill in an the SyncEntity by the data received from Azure DevOps In AzureDevOpsAPIWrapper.cs and return the list to the caller

3.	Implement exception | logger handing in AzureDevOpsConnector.cs

4.	Implement SetEntities function in CSVConnector class. The set function should export the csv to the current running location of the app – you can use – CsvHelper NuGet library for this or another ,

5.	ConnectorServices, Sync option is executing the main logic, after getting the entities, process them in parallel and add the length of the workitem URL to the SyncEntity object.

6.	Add exception, write to log when you think it is suitable 


Thank you

Good Luck

