The following setup is required in the Web.Config file:

1. Connection String:

	SQL Server name, username password etc

2. Password 
(This enable editing of the parameters)

<appSettings>
..
<add key="PASS" value="brmo"> <== change "brmo" to other password if necessary

3. Password TimeOut
(time of inactivity that will revert the app to "Editing Disabled". Password will then need to be reentered.

<sessionState mode="InProc" timeout="30"> <== timeout in minutes

