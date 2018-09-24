# Dotnet-CSharp-Client-SNowIntegration

The solution have two projects and these are very basic C# application, that communicate with SNow dev instance and the purpuse is to READ/WRITE data into the dev service now instance.
Docker support is optional that you utilized/can be added with the help of Visual Studio.

I have created customers table in my personel SN dev instance, you can create basically any table and add some columns with datatypes. 
Create user and assign appropriate user role to the user.
Go to -> servicenow -> dev instance - > from navigation pane - > type System web services -> properties - > enable SOAP / REST web services last third checkbox from the bottom.

ServiceNow Dev instance is FREE but if there's no activity for 10 days then you will loose your instance and your work will be gone and you might need to recreate the instance again.

1) SNow - Basic C# library
2) Temp Project - C# Web Form Generic template application
               - GetIncident.aspx -button click have code to communicate with ServiceNow.
               
