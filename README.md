# rotamaster_techtest
# Part 1 - API
To run this project download the entire solution and open it in Visual Studio (or similar). The API layer should be the one set to run by default (but ensure it is). Build it and run it and you should be greeted with:
![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/4075fd11-3537-47f4-abd8-b945db1d021b)
four API methods.

### Locations
No input values needed.
Press: ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/88c9f290-3a75-4105-9ba1-ba2dc10c0966)
And ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/2c70b2fc-e34f-41f5-aa61-23140e7a81a4)
It will return a list of locations.

### Roles
No input values needed.
Press: ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/88c9f290-3a75-4105-9ba1-ba2dc10c0966)
And ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/2c70b2fc-e34f-41f5-aa61-23140e7a81a4)
It will return a list of Roles and the number of shifts they appear on.

### ShiftsInDateRange
Press: ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/88c9f290-3a75-4105-9ba1-ba2dc10c0966)
Then enter two values in the star date fields:
![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/547c0481-eeae-4b07-acf5-992c59eb9ddb)
in the format yyyy-MM-dd e.g. 2023-11-13
Followed by the EXECUTE button.
It will return a list of shifts, their locations and roles that start in the interval you specified.


### ShiftsPerPerson
Press: ![image](https://github.com/jobiekirkwood/rotamaster_techtest/assets/36970443/88c9f290-3a75-4105-9ba1-ba2dc10c0966)
Then enter the name of a person: e.g Joseph White
Followed by EXECUTE.
It will return the shifts for this person.


# Part 2 - SQL
In addition, there is a folder at root named SQL which contains a SQL file with the commands to retreive the same data (as part one) out of a database if the user has created the same tables using the CreatePeopleShiftsTablesData.sql file.



