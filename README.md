templeschedule
==============

Utility to Schedule Appointments at a Temple

This program is used to generate the schedule for several wards in several stakes to come to a temple and perform baptisms for the dead.

First required input is a list of wards in .csv with headers Wards,Stakes. Sample file looks like:
```
Wards,Stakes
First Ward,Ogden Stake
Second Ward,Ogden Stake
```

Second required input is a list of blackout dates (no headers). Sample file looks like:
```
1-Jan-15
16-Mar-15
17-Mar-15
18-Mar-15
```

Other inputs include how many parts of the year to section off, the max number of saturday appointments each ward would get, and the may number of weekday appointments each ward gets.

Output will be a full schedule in a .csv file.

To add in timeslots for weekdays and saturdays you'll need to edit the source code of the program. Also, to tune the tolerance of the minimum days between appointments you'll need to edit the source code as well.

